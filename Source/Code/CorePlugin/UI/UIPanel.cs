using System;
using System.Collections.Generic;
using System.Linq;

using Duality;
using Duality.Input;
using Duality.Components;
using Duality.Components.Renderers;

namespace CampGame.UI
{
    [RequiredComponent(typeof(SpriteRenderer))]
    [RequiredComponent(typeof(Transform))]
    public class UIPanel : UIWidget, ICmpInitializable, ICmpUpdatable
    {
        [DontSerialize]
        private Vector2 screenSize = Vector2.Zero;

        [DontSerialize]
        private EventHandler<MouseMoveEventArgs> myMouseMove;

        [DontSerialize]
        private EventHandler<MouseButtonEventArgs> myMouseClick;

        [DontSerialize]
        private UIWidget myCurrentWidget;

        [DontSerialize]
        private List<UIWidget> myWidgets;

        [DontSerialize]
        protected bool MouseEntered = true;

        public Alignment ScreenAlignment { get; set; } = Alignment.TopLeft;

        public Vector2 Offset { get; set; } = Vector2.Zero;

        public override void OnInit(InitContext context)
        {
            base.OnInit(context);

            if (context == InitContext.Activate)
            {
                myWidgets = new List<UIWidget>();

                foreach (GameObject obj in GameObj.ChildrenDeep)
                {
                    UIWidget ctrl = obj.GetComponent<UIWidget>();
                    if (ctrl != null) myWidgets.Add(ctrl);
                }

                myMouseMove = new EventHandler<MouseMoveEventArgs>(OnMouseMove);
                myMouseClick = new EventHandler<MouseButtonEventArgs>(OnMouseClick);

                DualityApp.Mouse.Move += myMouseMove;
                DualityApp.Mouse.ButtonDown += myMouseClick;
            }
        }

        public override void OnShutdown(ShutdownContext context)
        {
            if (context == ShutdownContext.Deactivate)
            {
                DualityApp.Mouse.Move -= myMouseMove;
                DualityApp.Mouse.ButtonDown -= myMouseClick;
            }
        }

        void ICmpUpdatable.OnUpdate()
        {
            if (screenSize != DualityApp.TargetResolution)
            {
                screenSize = DualityApp.TargetResolution;

                SpriteRenderer renderer = GameObj.GetComponent<SpriteRenderer>();

                Vector2 panelSize = renderer.Rect.Size;
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

                Camera cam = GameObj.ParentScene.ActiveObjects.GetComponents<Camera>().FirstOrDefault();

                GameObj.Transform.MoveToAbs(cam.GetSpaceCoord(panelPos));
            }
        }

        private void OnMouseMove(object sender, MouseMoveEventArgs e)
        {
            Vector2 mousePosition = e.Position;

            SpriteRenderer renderer = GameObj.GetComponent<SpriteRenderer>();
            if (renderer == null) return;
            
            // First check the current control
            if (myCurrentWidget != null)
            {
                if (myCurrentWidget.GetAreaOnScreen().Contains(mousePosition))
                    return;
                else
                {
                    myCurrentWidget.OnMouseLeave();
                    myCurrentWidget = null;
                }
            }

            // Check to see if the mouse left the panel
            if (GetAreaOnScreen().Contains(mousePosition))
            {
                if (!MouseEntered) OnMouseEnter();

                foreach (UIWidget widget in myWidgets)
                {
                    if (widget.GetAreaOnScreen().Contains(mousePosition))
                    {
                        widget.OnMouseEnter();
                        myCurrentWidget = widget;
                        return;
                    }
                }
            }
            else if (MouseEntered)
            {
                OnMouseLeave();
            }
        }

        private void OnMouseClick(object sender, MouseButtonEventArgs e)
        {
            myCurrentWidget?.OnClick(e);
        }

        public override void OnMouseEnter()
        {
            MouseEntered = true;
        }

        public override void OnMouseLeave()
        {
            MouseEntered = false;
        }

        public override void OnClick(MouseButtonEventArgs e)
        {
        }
    }
}
