using Duality;
using Duality.Resources;
using Duality.Drawing;
using DuFont = Duality.Resources.Font;

namespace CampGame.Resources
{
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
        
        public UISkin(ContentRef<Material> bgMat, ContentRef<UIBorderMaterial> borderMat, ContentRef<DuFont> font)
        {
            BackgroundMaterial = bgMat;
            BorderMaterial = borderMat;
            Font = font;
        }

        public ContentRef<Material> BackgroundMaterial { get; set; } = Material.SolidWhite;

        public ContentRef<UIBorderMaterial> BorderMaterial { get; set; } = null;

        public ContentRef<DuFont> Font { get; set; } = DuFont.GenericMonospace10;

        internal void PrepareVertices(ref VertexC1P3T2[] baseVertices, ColorRgba baseColor, ref VertexC1P3T2[] borderVertices, ColorRgba borderColor)
        {
            Texture baseTex = BackgroundMaterial.Res?.MainTexture.Res;
            Texture borderTex = BorderMaterial.Res?.Texture.Res;

            if (baseTex == null || borderTex == null) return;

            if (baseVertices == null || baseVertices.Length != 4)
                baseVertices = new VertexC1P3T2[4];

            if (borderVertices == null || borderVertices.Length != 32)
                borderVertices = new VertexC1P3T2[32];


        }
    }
}
