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
    public class UICursor : UIWidget
    {
        public override void OnInit(InitContext context)
        {
            base.OnInit(context);

            if (context == InitContext.Activate)
            {
                UIInputManager inputManager = GameObj.ParentScene.FindComponent<UIInputManager>();
                if (inputManager != null)
                {
                    inputManager.Widgets.Remove(this);
                }
            }
        }

        public override void Draw(IDrawDevice device)
        {
            Vector2 mousePos = DualityApp.Mouse.Pos;
            GameObj.Transform.Pos = device.GetSpaceCoord(mousePos);

            base.Draw(device);
        }
    }
}
