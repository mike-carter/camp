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
        void ICmpUpdatable.OnUpdate()
        {
            Camera activeCamera = this.GameObj.ParentScene.ActiveObjects.GetComponents<Camera>().FirstOrDefault();

            Vector2 mousePos = DualityApp.Mouse.Pos;
            if (activeCamera != null)
                this.GameObj.Transform.Pos = activeCamera.GetSpaceCoord(mousePos);
        }
    }
}
