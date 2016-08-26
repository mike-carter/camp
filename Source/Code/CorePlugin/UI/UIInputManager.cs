using System;
using System.Linq;
using System.Collections.Generic;

using Duality;
using Duality.Input;

namespace CampGame.UI
{
    public class UIInputManager : Component, ICmpInitializable
    {
        [DontSerialize] protected Stack<UIControl> hoveredWidgets = new Stack<UIControl>();
        [DontSerialize] protected UIControl clickedWidget;
        [DontSerialize] protected UIControl focusedWidget;

        [DontSerialize] private EventHandler<KeyboardKeyEventArgs> keyboardHandler;
        [DontSerialize] private EventHandler<MouseMoveEventArgs> mouseMoveHandler;
        [DontSerialize] private EventHandler<MouseButtonEventArgs> mouseButtonDownHandler;
        [DontSerialize] private EventHandler<MouseButtonEventArgs> mouseButtonUpHandler; 
        [DontSerialize] private EventHandler<MouseWheelEventArgs> mouseWheelHandler;

        public UIInputManager()
        {
            keyboardHandler = new EventHandler<KeyboardKeyEventArgs>(KeyboardKeyPress);
            mouseMoveHandler = new EventHandler<MouseMoveEventArgs>(MouseMove);
            mouseButtonDownHandler = new EventHandler<MouseButtonEventArgs>(MouseButtonDown);
            mouseButtonUpHandler = new EventHandler<MouseButtonEventArgs>(MouseButtonUp);
            mouseWheelHandler = new EventHandler<MouseWheelEventArgs>(MouseWheelMove);
        }

        void ICmpInitializable.OnInit(InitContext context)
        {
            if (context == InitContext.Activate)
            {
                DualityApp.Keyboard.KeyDown += keyboardHandler;
                DualityApp.Mouse.Move += mouseMoveHandler;
                DualityApp.Mouse.ButtonDown += mouseButtonDownHandler;
                DualityApp.Mouse.ButtonUp += mouseButtonUpHandler;
                DualityApp.Mouse.WheelChanged += mouseWheelHandler;
            }
        }

        void ICmpInitializable.OnShutdown(ShutdownContext context)
        {
            if (context == ShutdownContext.Deactivate)
            {
                DualityApp.Keyboard.KeyDown -= keyboardHandler;
                DualityApp.Mouse.Move -= mouseMoveHandler;
                DualityApp.Mouse.ButtonDown -= mouseButtonDownHandler;
                DualityApp.Mouse.ButtonUp -= mouseButtonUpHandler;
                DualityApp.Mouse.WheelChanged -= mouseWheelHandler;
            }
        }

        private void KeyboardKeyPress(object sender, KeyboardKeyEventArgs e)
        {
        }

        private void MouseMove(object sender, MouseMoveEventArgs e)
        {
            if (!Active) return;

            if (clickedWidget != null)
            {
                clickedWidget.OnDrag(e);
                return;
            }

            while (hoveredWidgets.Count > 0)
            {
                if (hoveredWidgets.Peek().GetScreenRect().Contains(e.Position))
                {
                    break;
                }
                else
                {
                    hoveredWidgets.Pop().OnMouseLeave(e);
                }
            }

            foreach (UIControl widget in GameObj.ChildrenDeep.GetComponents<UIControl>()
                .Where((w) => w.GetScreenRect().Contains(e.Position) && !(w is UICursor))
                .OrderByDescending((w) => w.ZOffset))
            {
                widget.OnMouseEnter(e);
                hoveredWidgets.Push(widget);
            }
        }

        private void MouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (hoveredWidgets.Count > 0)
            {
                hoveredWidgets.Peek().OnClick(e);

                if (e.Button == MouseButton.Left)
                {
                    clickedWidget = hoveredWidgets.Peek();
                }
            }
        }

        private void MouseButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.Button == MouseButton.Left)
            {
                clickedWidget = null;
            }
        }

        private void MouseWheelMove(object sender, MouseWheelEventArgs e)
        {

        }
    }
}
