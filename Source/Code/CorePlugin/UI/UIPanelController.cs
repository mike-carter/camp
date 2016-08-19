using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Input;

namespace CampGame.UI
{
    public class UIPanelController : Component, ICmpInitializable
    {
        [DontSerialize]
        private EventHandler<MouseMoveEventArgs> mouseMove;

        [DontSerialize]
        private EventHandler<MouseButtonEventArgs> mouseClick;

        [DontSerialize]
        private Vector2 mousePosition;

        [DontSerialize]
        private GameObject currentComponent;

        [DontSerialize]
        List<GameObject> panelControls;

        public UIPanelController()
        {
            mouseMove = new EventHandler<MouseMoveEventArgs>(OnMouseMove);
            mouseClick = new EventHandler<MouseButtonEventArgs>(OnMouseClick);
        }

        public void OnInit(InitContext context)
        {
            if (context == InitContext.Activate)
            {
                panelControls = new List<GameObject>();

                foreach (GameObject obj in GameObj.ChildrenDeep.Where((g) =>
                g.GetComponent<UIItemController>() != null &&
                g.GetComponent<UIRenderer>() != null))
                {
                    panelControls.Add(obj);
                }

                if (GameObj.GetComponent<UIItemController>() != null &&
                    GameObj.GetComponent<UIRenderer>() != null)
                {
                    panelControls.Add(GameObj);
                }

                DualityApp.Mouse.Move += mouseMove;
                DualityApp.Mouse.ButtonDown += mouseClick;
            }
        }

        public void OnShutdown(ShutdownContext context)
        {
            if (context == ShutdownContext.Deactivate)
            {
                DualityApp.Mouse.Move -= mouseMove;
                DualityApp.Mouse.ButtonDown -= mouseClick;
            }
        }

        private void OnMouseMove(object sender, MouseMoveEventArgs e)
        {

        }

        private void OnMouseClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
