using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Drawing;

namespace CampGame
{
    public class CursorDebugComponent : Component, ICmpRenderer
    {
        public float BoundRadius { get { return float.MaxValue; } }

        public void Draw(IDrawDevice device)
        {
        }

        public bool IsVisible(IDrawDevice device)
        {
            return false;
        }
    }
}
