using System;
using System.Collections.Generic;
using System.Linq;

using Duality;
using Duality.Components;

namespace CampGame
{
    [RequiredComponent(typeof(Transform))]
    public class CursorLogic : Component, ICmpUpdatable
    {
        public Camera Camera { get; set; }

        void ICmpUpdatable.OnUpdate()
        {
            Vector2 mousePos = DualityApp.Mouse.Pos;
            this.GameObj.Transform.Pos = Camera.GetSpaceCoord(mousePos);
        }
    }
}
