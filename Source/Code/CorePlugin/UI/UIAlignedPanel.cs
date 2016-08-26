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
    public class UIAlignedPanel : UIPanel
    {
        protected Alignment screenAlignment;
        protected Vector2 alignOffset;

        public Alignment ScreenAlignment
        {
            get { return screenAlignment; }
            set { dirtyFlags |= DirtyFlags.All; screenAlignment = value; }
        }

        public Vector2 AlignmentOffset
        {
            get { return alignOffset; }
            set { dirtyFlags |= DirtyFlags.All; alignOffset = value; }
        }

        protected override void Draw(IDrawDevice device, Rect drawArea)
        {
            if ((dirtyFlags & DirtyFlags.Layout) != DirtyFlags.None)
            {
                Vector2 parentSize = (parentContainer == null) ? device.TargetSize : parentContainer.Size;

                Vector2 panelSize = drawArea.Size;
                Vector2 panelPos = Vector2.Zero;

                switch (ScreenAlignment)
                {
                    case Alignment.Center:
                        panelPos.X = (parentSize.X / 2) - (panelSize.X / 2);
                        panelPos.Y = (parentSize.Y / 2) - (panelSize.Y / 2);
                        break;
                    case Alignment.Left:
                        panelPos.Y = (parentSize.Y / 2) - (panelSize.Y / 2);
                        break;
                    case Alignment.Right:
                        panelPos.X = parentSize.X - panelSize.X;
                        panelPos.Y = (parentSize.Y / 2) - (panelSize.Y / 2);
                        break;
                    case Alignment.Top:
                        panelPos.X = (parentSize.X / 2) - (panelSize.X / 2);
                        break;
                    case Alignment.TopLeft:
                        break;
                    case Alignment.TopRight:
                        panelPos.X = parentSize.X - panelSize.X;
                        break;
                    case Alignment.Bottom:
                        panelPos.X = (parentSize.X / 2) - (panelSize.X / 2);
                        panelPos.Y = parentSize.Y - panelSize.Y;
                        break;
                    case Alignment.BottomLeft:
                        panelPos.Y = parentSize.Y - panelSize.Y;
                        break;
                    case Alignment.BottomRight:
                        panelPos.X = parentSize.X - panelSize.X;
                        panelPos.Y = parentSize.Y - panelSize.Y;
                        break;
                }
                panelPos += AlignmentOffset;

                Location = panelPos;
                drawArea = GetScreenRect();
            }

            base.Draw(device, drawArea);
        }
    }
}
