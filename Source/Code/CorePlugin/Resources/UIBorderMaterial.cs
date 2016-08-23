using Duality;
using Duality.Resources;
using Duality.Editor;

namespace CampGame.Resources
{
    [ExplicitResourceReference(typeof(Texture))]
    public class UIBorderMaterial : Resource
    {
        public ContentRef<Texture> Texture { get; set; } = Material.SolidWhite.Res.MainTexture;
        
        public Vector2 TopBorder { get; set; } = new Vector2(0, 3);

        public Vector2 LeftBorder { get; set; } = new Vector2(0, 3);

        public Vector2 RightBorder { get; set; } = new Vector2(0, 3);

        public Vector2 BottomBorder { get; set; } = new Vector2(0, 3);

        public UIBorderMaterial(ContentRef<Texture> texture)
        {
            this.Texture = texture;
        }
        
        private Vector2 TopCoords
        {
            get { return new Vector2(TopBorder.X, TopBorder.X + TopBorder.Y); }
        }

        private Vector2 LeftCoords
        {
            get { return new Vector2(LeftBorder.X, LeftBorder.X + LeftBorder.Y); }
        }

        private Vector2 RightCoords
        {
            get { return new Vector2(Texture.Res.Size.X - RightBorder.X, Texture.Res.Size.X - (RightBorder.X + RightBorder.Y)); }
        }

        private Vector2 BottomCoords
        {
            get { return new Vector2(Texture.Res.Size.Y - BottomBorder.X, Texture.Res.Size.Y - (BottomBorder.X + BottomBorder.Y)); }
        }

        [EditorHintFlags(MemberFlags.Invisible)]

        public Rect TopCoordsRect
        {
            get { return new Rect(LeftCoords.Y, TopCoords.X, RightCoords.Y, TopCoords.Y); }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect LeftCoordsRect
        {
            get { return new Rect(LeftCoords.X, TopCoords.Y, LeftCoords.Y, BottomCoords.Y); }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect RightCoordsRect
        {
            get { return new Rect(RightCoords.Y, TopCoords.Y, RightCoords.X, BottomCoords.Y); }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect BottomCoordsRect
        {
            get { return new Rect(LeftCoords.Y, BottomCoords.Y, RightCoords.Y, BottomCoords.X); }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect TopLeftCornerRect
        {
            get { return new Rect(LeftCoords.X, TopCoords.X, LeftCoords.Y, TopCoords.Y); }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect TopRightCornerRect
        {
            get { return new Rect(RightCoords.Y, TopCoords.X, RightCoords.X, TopCoords.Y); }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect BottomLeftCornerRect
        {
            get { return new Rect(LeftCoords.X, BottomCoords.Y, LeftCoords.Y, BottomCoords.X); }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect BottomRightCornerRect
        {
            get { return new Rect(RightCoords.Y, BottomCoords.Y, RightCoords.X, BottomCoords.X); }
        }
    }
}
