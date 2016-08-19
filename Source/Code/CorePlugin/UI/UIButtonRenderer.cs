using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Drawing;
using Duality.Resources;

namespace CampGame.UI
{
    public class UIButtonRenderer : UIRenderer
    {
        UIRenderer panelRenderer = null;

        public GameObject Panel { get; set; } = null;

        //ColorRgba HighlightColor { get; set; } = ColorRgba.Red;

        public override void Draw(IDrawDevice device)
        {
            if (panelRenderer != null)
            {
                Canvas canvas = new Canvas(device);

                Pos = panelRenderer.Pos + Offset;

                ContentRef<Material> matRef = Material == null ? Duality.Resources.Material.Checkerboard : Material;

                canvas.State.SetMaterial(matRef);

                canvas.FillRect(Pos.X, Pos.Y, ZOffset, Size.X, Size.Y);
            }
            else
            {
                base.Draw(device);
            }
        }

        public override void OnInit(Component.InitContext context)
        {
            panelRenderer = Panel?.GetComponent<UIRenderer>();
        }
    }
}
