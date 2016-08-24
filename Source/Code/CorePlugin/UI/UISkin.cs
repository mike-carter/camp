using Duality;
using Duality.Resources;

namespace CampGame.UI
{
    [System.Flags]
    public enum BorderSections : byte
    {
        None   = 0,
        Left   = 0x01,
        Top    = 0x02,
        Bottom = 0x04,
        Right  = 0x08,
        TopLeft     = Top | Left,
        BottomLeft  = Bottom | Left,
        BottomRight = Bottom | Right,
        TopRight    = Top | Right,
        AllButRight  = Top | Bottom | Left,
        AllButBottom = Top | Left | Right,
        AllButTop    = Bottom | Left | Right,
        AllButLeft   = Top | Bottom | Right,
        All = Left | Top | Bottom | Right,
    }

    [ExplicitResourceReference(typeof(Material))]
    public class UISkin : Resource
    {
        static ContentRef<UISkin> defaultSkin = null;
        public static ContentRef<UISkin> Default
        {
            get
            {
                if (defaultSkin == null || !defaultSkin.IsAvailable)
                {
                    UISkin skin = new UISkin();
                    defaultSkin = new ContentRef<UISkin>(skin);
                }
                return defaultSkin;
            }
        }

        public UISkin() { }
        
        public UISkin(ContentRef<Material> bgMat, ContentRef<Material> borderMat, ContentRef<Font> font)
        {
            BackgroundMaterial = bgMat;
            BorderMaterial = borderMat;
            Font = font;
        }

        public ContentRef<Material> BackgroundMaterial { get; set; } = Material.SolidWhite;

        public ContentRef<Material> BorderMaterial { get; set; } = null;

        public ContentRef<Font> Font { get; set; } = Duality.Resources.Font.GenericMonospace10;

        /// <summary>
        /// [GET/SET] Determines the portion of the border material used for the top border.
        /// X is the distance between the outside edge of the border and the edge of the texture pixmap,
        /// Y is the width of the border.
        /// </summary>
        public Vector2 TopBorder { get; set; } = new Vector2(0, 3);

        /// <summary>
        /// [GET/SET] Determines the portion of the border material used for the left border.
        /// X is the distance between the outside edge of the border and the edge of the texture pixmap,
        /// Y is the width of the border.
        /// </summary>
        public Vector2 LeftBorder { get; set; } = new Vector2(0, 3);

        /// <summary>
        /// [GET/SET] Determines the portion of the border material used for the right border.
        /// X is the distance between the outside edge of the border and the edge of the texture pixmap,
        /// Y is the width of the border.
        /// </summary>
        public Vector2 RightBorder { get; set; } = new Vector2(0, 3);

        /// <summary>
        /// [GET/SET] Determines the portion of the border material used for the bottom border.
        /// X is the distance between the outside edge of the border and the edge of the texture pixmap,
        /// Y is the width of the border.
        /// </summary>
        public Vector2 BottomBorder { get; set; } = new Vector2(0, 3);

        public Rect GetBorderUV(BorderSections borderSection)
        {
            Texture borderTex = BorderMaterial.Res?.MainTexture.Res;
            if (borderTex == null) return Rect.Empty;

            Rect uvRect = new Rect(borderTex.UVRatio);
            Rect pixRect = new Rect(borderTex.Size);

            Vector2 scale;
            scale.X = uvRect.W / pixRect.W;
            scale.Y = uvRect.H / pixRect.H;

            switch (borderSection)
            {
                case BorderSections.Left:
                    pixRect.X = LeftBorder.X;
                    pixRect.Y = TopBorder.X + TopBorder.Y;
                    pixRect.W = LeftBorder.Y;
                    pixRect.H = pixRect.H - (TopBorder.X + TopBorder.Y + BottomBorder.X + BottomBorder.Y);
                    break;
                case BorderSections.Top:
                    pixRect.X = LeftBorder.X + LeftBorder.Y;
                    pixRect.Y = TopBorder.X;
                    pixRect.W = pixRect.W - (LeftBorder.X + LeftBorder.Y + RightBorder.X + RightBorder.Y);
                    pixRect.H = TopBorder.Y;
                    break;
                case BorderSections.Right:
                    pixRect.X = pixRect.W - RightBorder.X - RightBorder.Y;
                    pixRect.Y = TopBorder.X + TopBorder.Y;
                    pixRect.W = RightBorder.Y;
                    pixRect.H = pixRect.H - (TopBorder.X + TopBorder.Y + BottomBorder.X + BottomBorder.Y);
                    break;
                case BorderSections.Bottom:
                    pixRect.X = LeftBorder.X + LeftBorder.Y;
                    pixRect.Y = pixRect.H - BottomBorder.X - BottomBorder.Y;
                    pixRect.W = pixRect.W - (LeftBorder.X + LeftBorder.Y + RightBorder.X + RightBorder.Y);
                    pixRect.H = BottomBorder.Y;
                    break;
                case BorderSections.TopLeft:
                    pixRect.X = LeftBorder.X;
                    pixRect.Y = TopBorder.X;
                    pixRect.W = LeftBorder.Y;
                    pixRect.H = TopBorder.Y;
                    break;
                case BorderSections.TopRight:
                    pixRect.X = pixRect.W - RightBorder.X - RightBorder.Y;
                    pixRect.Y = TopBorder.X;
                    pixRect.W = RightBorder.Y;
                    pixRect.H = TopBorder.Y;
                    break;
                case BorderSections.BottomLeft:
                    pixRect.X = LeftBorder.X;
                    pixRect.Y = pixRect.H - BottomBorder.X - BottomBorder.Y;
                    pixRect.W = LeftBorder.Y;
                    pixRect.H = BottomBorder.Y;
                    break;
                case BorderSections.BottomRight:
                    pixRect.X = pixRect.W - RightBorder.X - RightBorder.Y;
                    pixRect.Y = pixRect.H - BottomBorder.X - BottomBorder.Y;
                    pixRect.W = RightBorder.Y;
                    pixRect.H = BottomBorder.Y;
                    break;
            }

            uvRect.X = pixRect.X * scale.X;
            uvRect.W = pixRect.W * scale.X;
            uvRect.Y = pixRect.Y * scale.Y;
            uvRect.H = pixRect.H * scale.Y;
            
            return uvRect;
        }
    }
}
