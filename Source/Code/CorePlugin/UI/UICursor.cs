using System;
using System.Collections.Generic;
using System.Linq;

using Duality;
using Duality.Components;
using Duality.Drawing;
using Duality.Input;

namespace CampGame.UI
{
    [RequiredComponent(typeof(Transform))]
    public class UICursor : UIPanel
    {
        public override void OnInit(InitContext context)
        {
            bordersVisible = false;
        }

        public override void Draw(IDrawDevice device)
        {
            Vector2 mousePos = DualityApp.Mouse.Pos;
            GameObj.Transform.Pos = device.GetSpaceCoord(mousePos);
            
            base.Draw(device);
        }
    }
}
