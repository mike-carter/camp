using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Input;
using Duality.Resources;

namespace CampGame.UI
{
    public class ToolPanelButton : UIImagePanel
    {
        GameObject Action;

        public override void OnInit(InitContext context)
        {
            base.OnInit(context);

            if (context == InitContext.Activate)
            {
                bordersVisible = false;
            }
        }


        public override void OnMouseEnter(MouseMoveEventArgs e)
        {
            BordersVisible = true;
        }

        public override void OnMouseLeave(MouseMoveEventArgs e)
        {
            BordersVisible = false;
        }

        public override void OnClick(MouseButtonEventArgs e)
        {

        }
    }
}
