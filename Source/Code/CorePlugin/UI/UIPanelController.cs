using System;
using System.Collections.Generic;
using System.Linq;

using Duality;
using Duality.Input;

namespace CampGame.UI
{
    [RequiredComponent(typeof(UIRenderer))]
    public class UIPanelController : UIItemController, ICmpInitializable
    {
        [DontSerialize]
        private EventHandler<MouseMoveEventArgs> myMouseMove;
        [DontSerialize]
        private EventHandler<MouseButtonEventArgs> myMouseClick;
        [DontSerialize]
        private GameObject myCurrentControl;
        [DontSerialize]
        private List<GameObject> myPanelControls;

        [DontSerialize]
        protected bool MouseEntered = true;

        public UIPanelController()
        {
            myMouseMove = new EventHandler<MouseMoveEventArgs>(OnMouseMove);
            myMouseClick = new EventHandler<MouseButtonEventArgs>(OnMouseClick);
        }

        public virtual void OnInit(InitContext context)
        {
            if (context == InitContext.Activate)
            {
                myPanelControls = new List<GameObject>();

                foreach (GameObject obj in GameObj.ChildrenDeep
                    .Where((g) => g.GetComponents<UIItemController>().Count() > 0 && g.GetComponents<UIRenderer>().Count() > 0)
                    .OrderByDescending((g) => g.GetComponents<UIRenderer>().First().ZOffset))
                {
                    myPanelControls.Add(obj);
                }

                DualityApp.Mouse.Move += myMouseMove;
                DualityApp.Mouse.ButtonDown += myMouseClick;
            }
        }

        public virtual void OnShutdown(ShutdownContext context)
        {
            if (context == ShutdownContext.Deactivate)
            {
                DualityApp.Mouse.Move -= myMouseMove;
                DualityApp.Mouse.ButtonDown -= myMouseClick;
            }
        }

        private void OnMouseMove(object sender, MouseMoveEventArgs e)
        {
            UIRenderer renderer = GameObj.GetComponents<UIRenderer>().FirstOrDefault();
            if (renderer == default(UIRenderer)) return;

            Vector2 mousePosition = e.Position;

            // First check the current control
            if (myCurrentControl != null &&
                (renderer = myCurrentControl.GetComponents<UIRenderer>().FirstOrDefault()) != default(UIRenderer))
            {
                if (renderer.ScreenArea.Contains(mousePosition))
                    return;

                // Otherwise, leave the control
                foreach (UIItemController control in myCurrentControl.GetComponents<UIItemController>())
                {
                    control.OnMouseLeave();
                }
                myCurrentControl = null;
            }

            // Check to see if the mouse left the panel
            if (renderer.ScreenArea.Contains(mousePosition))
            {
                if (!MouseEntered) OnMouseEnter();

                foreach (GameObject obj in myPanelControls)
                {
                    var objRenderer = obj.GetComponents<UIRenderer>().FirstOrDefault();
                    var objControllers = obj.GetComponents<UIItemController>();

                    if (objRenderer == null || objControllers.Count() == 0)
                    {
                        continue;
                    }

                    if (objRenderer.ScreenArea.Contains(mousePosition))
                    {
                        myCurrentControl = obj;
                        foreach (UIItemController control in objControllers)
                        {
                            control.OnMouseEnter();
                        }
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
            OnClick(e);
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
            if (myCurrentControl != null)
            {
                foreach (var controller in myCurrentControl.GetComponents<UIItemController>())
                {
                    controller.OnClick(e);
                }
            }
        }
    }
}
