using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duality;
using Duality.Drawing;

namespace CampGame.UI
{

    public class UIWindow : UIControl
    {
        public override void OnInit(InitContext context)
        {
            Location = Vector2.Zero;
            Size = DualityApp.TargetResolution;
        }

        protected override void Draw(IDrawDevice device, Rect drawArea)
        {
            if (Size != device.TargetSize)
            {
                Size = device.TargetSize;
            }
        }
    }
}
