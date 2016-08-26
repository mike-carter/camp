using System;
using System.Collections.Generic;
using System.Linq;

using Duality;
using Duality.Components;
using Duality.Drawing;
using Duality.Input;

namespace CampGame.UI
{
    public class UICursor : UIPanel
    {
        public override void OnInit(InitContext context)
        {
            bordersVisible = false;
        }

        protected override void Draw(IDrawDevice device, Rect drawArea)
        {
            Vector2 mousePos = DualityApp.Mouse.Pos;

            

            if (Location != mousePos) Location = mousePos;

            base.Draw(device, rect);
        }

        public override Rect GetScreenRect()
        {
            return rect;
        }
    }
}
