using System;
using System.Collections.Generic;
using System.Linq;

using Duality;
using Duality.Input;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Drawing;

namespace CampGame.UI
{
    [RequiredComponent(typeof(Transform))]
    public class UIAlignedPanel : UIPanel
    {
        [DontSerialize]
        protected bool MouseEntered = true;

        public Alignment ScreenAlignment { get; set; } = Alignment.TopLeft;

        public Vector2 Offset { get; set; } = Vector2.Zero;

        public override void Draw(IDrawDevice device)
        {
            Vector2 screenSize = device.TargetSize;

            Vector2 panelSize = screenArea.Size;
            Vector2 panelPos = Vector2.Zero;

            switch (ScreenAlignment)
            {
                case Alignment.Center:
                    panelPos.X = (screenSize.X / 2) - (panelSize.X / 2);
                    panelPos.Y = (screenSize.Y / 2) - (panelSize.Y / 2);
                    break;
                case Alignment.Left:
                    panelPos.Y = (screenSize.Y / 2) - (panelSize.Y / 2);
                    break;
                case Alignment.Right:
                    panelPos.X = screenSize.X - panelSize.X;
                    panelPos.Y = (screenSize.Y / 2) - (panelSize.Y / 2);
                    break;
                case Alignment.Top:
                    panelPos.X = (screenSize.X / 2) - (panelSize.X / 2);
                    break;
                case Alignment.TopLeft:
                    break;
                case Alignment.TopRight:
                    panelPos.X = screenSize.X - panelSize.X;
                    break;
                case Alignment.Bottom:
                    panelPos.X = (screenSize.X / 2) - (panelSize.X / 2);
                    panelPos.Y = screenSize.Y - panelSize.Y;
                    break;
                case Alignment.BottomLeft:
                    panelPos.Y = screenSize.Y - panelSize.Y;
                    break;
                case Alignment.BottomRight:
                    panelPos.X = screenSize.X - panelSize.X;
                    panelPos.Y = screenSize.Y - panelSize.Y;
                    break;
            }

            panelPos += Offset;

            GameObj.Transform.MoveToAbs(device.GetSpaceCoord(panelPos));

            base.Draw(device);
        }

        public override void OnMouseEnter()
        {
            MouseEntered = true;
        }

        public override void OnMouseLeave()
        {
            MouseEntered = false;
        }
    }
}
