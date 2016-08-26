using Duality;
using Duality.Drawing;
using Duality.Resources;

namespace CampGame.UI
{
    class UIIconPanel : UIPanel
    {
        protected ContentRef<Material> icon = null;
        protected ColorRgba iconTint = ColorRgba.White;
        protected Rect iconRect = new Rect(100, 100);
        protected bool iconVisible = true;

        [DontSerialize] VertexC1P3T2[] iconVertices = new VertexC1P3T2[4];

        public ContentRef<Material> Icon
        {
            get { return icon; }
            set { dirtyFlags |= DirtyFlags.Icon; icon = value; }
        }

        public Rect IconRect
        {
            get { return iconRect; }
            set { dirtyFlags |= DirtyFlags.Icon; iconRect = value; }
        }

        public ColorRgba IconTint
        {
            get { return iconTint; }
            set { dirtyFlags |= DirtyFlags.Icon; iconTint = value; }
        }

        public bool IconVisible
        {
            get { return iconVisible; }
            set { iconVisible = value; }
        }
        
        public override void Draw(IDrawDevice device)
        {
            base.Draw(device);

            if (iconVisible) DrawIcon(device);
        }

        protected void DrawIcon(IDrawDevice device)
        {
            Material iconMat = Icon.Res ?? Material.Checkerboard.Res;
            Texture iconTex = iconMat?.MainTexture.Res ?? Texture.Checkerboard.Res;

            if (iconMat == null || iconTex == null) return;

            if ((dirtyFlags & DirtyFlags.Icon) != DirtyFlags.None)
            {
                ColorRgba mainColor = iconMat.MainColor * bgTint;
                Rect uvRect = new Rect(iconTex.UVRatio);

                if (iconVertices == null || iconVertices.Length != 4) iconVertices = new VertexC1P3T2[4];

                float zval = offset * ZOffsetScale;

                Rect screenRect = new Rect(iconRect.Size);
                screenRect.Pos = screenArea.Pos + iconRect.Pos;

                iconVertices[0].Pos.Xy = screenRect.TopLeft;
                iconVertices[0].Pos.Z = zval;
                iconVertices[0].TexCoord = uvRect.TopLeft;
                iconVertices[0].Color = mainColor;

                iconVertices[1].Pos.Xy = screenRect.BottomLeft;
                iconVertices[1].Pos.Z = zval;
                iconVertices[1].TexCoord = uvRect.BottomLeft;
                iconVertices[1].Color = mainColor;

                iconVertices[2].Pos.Xy = screenRect.BottomRight;
                iconVertices[2].Pos.Z = zval;
                iconVertices[2].TexCoord = uvRect.BottomRight;
                iconVertices[2].Color = mainColor;

                iconVertices[3].Pos.Xy = screenRect.TopRight;
                iconVertices[3].Pos.Z = zval;
                iconVertices[3].TexCoord = uvRect.TopRight;
                iconVertices[3].Color = mainColor;

                dirtyFlags -= DirtyFlags.Icon;
            }

            device.AddVertices(iconMat, VertexMode.Quads, iconVertices);
        }
    }
}
