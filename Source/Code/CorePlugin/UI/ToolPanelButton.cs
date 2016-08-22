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
    public class ToolPanelButton : UIWidget
    {
        ContentRef<Material> temp;

        public enum Button
        {
            None,
            Build
        }

        public Button ButtonID { get; set; }

        public override void OnMouseEnter()
        {
            //temp = BaseMaterial;
            //BaseMaterial = Material.DualityIcon;
        }

        public override void OnMouseLeave()
        {

        }

        public override void OnClick(MouseButtonEventArgs e)
        {
            if (BaseMaterial == Material.DualityIcon)
                BaseMaterial = temp;
            else
            {
                temp = BaseMaterial;
                BaseMaterial = Material.DualityIcon;
            }
        }
    }
}
