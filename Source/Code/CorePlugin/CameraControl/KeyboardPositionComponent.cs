using System;
using System.Collections.Generic;
using System.Linq;

using Duality;
using Duality.Input;
using Duality.Components;
using Duality.Drawing;

namespace CampGame.CameraControl
{
	[RequiredComponent(typeof(Transform))]
	public class KeyboardControlComponent : Component, ICmpUpdatable, ICmpRenderer
	{
        /// <summary>
        /// [GET / SET] The maximum movement speed of the camera.
        /// </summary>
        public float Speed { get; set; } = 10f;

        public bool ShowPosition { get; set; } = false;

        public float CrosshairSize { get; set; } = 32f;

        float ICmpRenderer.BoundRadius { get { return float.MaxValue; } }

        void ICmpRenderer.Draw(IDrawDevice device)
        {
            Canvas canvas = new Canvas(device);

            Vector3 myPos = device.GetScreenCoord(GameObj.Transform.Pos);

            canvas.State.ColorTint = ColorRgba.White.WithAlpha(0.5f);
            canvas.DrawLine(myPos.X, myPos.Y + CrosshairSize, myPos.X, myPos.Y - CrosshairSize);
            canvas.DrawLine(myPos.X + CrosshairSize, myPos.Y, myPos.X - CrosshairSize, myPos.Y);
        }

        bool ICmpRenderer.IsVisible(IDrawDevice device)
        {
            return ShowPosition;
        }

        void ICmpUpdatable.OnUpdate()
		{
			Vector2 movement = Vector2.Zero;

			// Horizontal keyboard movement
			if (DualityApp.Keyboard[Key.Left])
				movement += new Vector2(-1.0f, 0.0f);
			else if (DualityApp.Keyboard[Key.Right])
				movement += new Vector2(1.0f, 0.0f);

			// Vertical keyboard movement
			if (DualityApp.Keyboard[Key.Up])
				movement += new Vector2(0.0f, -1.0f);
			else if (DualityApp.Keyboard[Key.Down])
				movement += new Vector2(0.0f, 1.0f);

			// Is there a Gamepad we can use?
			GamepadInput gamepad = DualityApp.Gamepads.FirstOrDefault(g => g.IsAvailable);
			if (gamepad != null)
			{
				// If the left thumbstick does something significant, use it as movement input.
				if (gamepad.LeftThumbstick.Length > 0.2f)
				{
					movement += gamepad.LeftThumbstick;
				}
			}

			// Make sure we don't move faster than intended when pressing all the keys at once.
			movement /= MathF.Max(movement.Length, 1.0f);

            // Apply movement
            GameObj.Transform.MoveByAbs(movement * this.Speed * Time.TimeMult);
		}
    }
}
