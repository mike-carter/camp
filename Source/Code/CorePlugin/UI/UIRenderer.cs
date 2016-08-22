using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Components;
using Duality.Drawing;

namespace CampGame.UI
{
    public class UIRenderer : Renderer, ICmpInitializable
    {
        [DontSerialize]
        List<UIWidget> allWidgets = new List<UIWidget>();

        public override float BoundRadius { get { return float.MaxValue; } }

        public void OnInit(InitContext context)
        {
            VisibilityGroup = VisibilityFlag.ScreenOverlay | VisibilityFlag.AllFlags;
        }

        public void OnShutdown(ShutdownContext context)
        {

        }
        
        public override void Draw(IDrawDevice device)
        {
            foreach (UIWidget widget in allWidgets)
            {
                widget.Draw(device);
            }
        }

        public override bool IsVisible(IDrawDevice device)
        {
            return (device.VisibilityMask & VisibilityFlag.ScreenOverlay) != VisibilityFlag.None &&
                (device.VisibilityMask & VisibilityFlag.AllFlags) != VisibilityFlag.None;
        }

        public void AddWidget(UIWidget widget)
        {
            for (int i = 0; i < allWidgets.Count; i++)
            {
                if (widget.ZOffset >= allWidgets[i].ZOffset)
                {
                    allWidgets.Insert(i, widget);
                    return;
                }
            }
            allWidgets.Add(widget);
        }

        public void RemoveWidget(UIWidget widget)
        {
            allWidgets.Remove(widget);
        }
    }
}
