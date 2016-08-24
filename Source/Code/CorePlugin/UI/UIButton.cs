using Duality;
using Duality.Drawing;
using Duality.Resources;

namespace CampGame.UI
{
    class UIButton : UIPanel
    {
        public ContentRef<Material> Icon { get; set; } = null;

        public Rect IconRect { get; set; } = new Rect(100, 100);

        public override void Draw(IDrawDevice device)
        {
            base.Draw(device);

            
        }

        protected void DrawIcon(IDrawDevice device)
        {

        }

        protected void DrawText(IDrawDevice device)
        {

        }
    }
}
