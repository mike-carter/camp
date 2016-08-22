using System;
using System.Linq;
using System.Collections.Generic;

using Duality;
using Duality.Input;

namespace CampGame.UI
{
    public class UIInputManager : Component, ICmpInitializable
    {
        [DontSerialize]
        protected List<UIWidget> allWidgets;

        [DontSerialize]
        protected List<UIWidget> hoveredWidgets;

        [DontSerialize]
        protected UIWidget focusedWidget;

        [DontSerialize]
        private EventHandler<KeyboardKeyEventArgs> keyboardHandler;

        [DontSerialize]
        private EventHandler<MouseMoveEventArgs> mouseMoveHandler;

        [DontSerialize]
        private EventHandler<MouseButtonEventArgs> mouseButtonDownHandler;

        [DontSerialize]
        private EventHandler<MouseButtonEventArgs> mouseButtonUpHandler;

        [DontSerialize]
        private EventHandler<MouseWheelEventArgs> mouseWheelHandler;
        
        public IList<UIWidget> Widgets { get { return allWidgets; } }

        public UIInputManager()
        {
            allWidgets = new List<UIWidget>();

            hoveredWidgets = new List<UIWidget>();

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

        public void AddWidget(UIWidget widget)
        {
            if (!allWidgets.Contains(widget))
            {
                allWidgets.Add(widget);
            }
        }

        private void KeyboardKeyPress(object sender, KeyboardKeyEventArgs e)
        {
            if (focusedWidget != null)
            {
                focusedWidget.OnKeyPress(e);
            }
        }

        private void MouseMove(object sender, MouseMoveEventArgs e)
        {
            if (!Active)
                return;

            Vector2 mousePos = e.Position;

            for (int i = 0; i < hoveredWidgets.Count; i++)
            {
                if (!hoveredWidgets[i].ScreenArea.Contains(mousePos))
                {
                    hoveredWidgets[i].OnMouseLeave();
                    hoveredWidgets.RemoveAt(i);
                    i--;
                }
            }

            bool needsSort = false;
            var mouseIsOver = allWidgets.Where((x) => x.ScreenArea.Contains(mousePos));
            foreach (var widget in mouseIsOver)
            {
                if (!hoveredWidgets.Contains(widget))
                {
                    widget.OnMouseEnter();
                    hoveredWidgets.Add(widget);
                    needsSort = true;
                }
            }

            if (needsSort)
                hoveredWidgets.Sort(new Comparison<UIWidget>((w1, w2) => w1.ZOffset.CompareTo(w2.ZOffset)));
        }

        private void MouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (hoveredWidgets.Count > 0) 
            {
                focusedWidget = hoveredWidgets.First();
                focusedWidget.OnClick(e);
            }
        }

        private void MouseButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (focusedWidget != null)
            {
                focusedWidget.OnRelease(e);
            }
        }

        private void MouseWheelMove(object sender, MouseWheelEventArgs e)
        {

        }
    }
}
