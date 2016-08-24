using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Resources;

namespace CampGame.UI
{
    public class ScrollPanel : UIAlignedPanel
    {
        public ContentRef<Material> ButtonMaterial { get; set; } = null;



        
        public override void OnInit(InitContext context)
        {
            base.OnInit(context);

            if (context == InitContext.Activate)
            {

            }
        }
    }
}
