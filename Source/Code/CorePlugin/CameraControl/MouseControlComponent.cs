using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Input;
using Duality.Components;
using Duality.Drawing;

namespace CampGame.CameraControl
{
    [RequiredComponent(typeof(Transform))]
    public class MouseControlComponent : Component, ICmpRenderer, ICmpUpdatable, ICmpInitializable
    {
        Camera myCamera = null;
        GameObject myCursor = null;

        public void OnInit(InitContext context)
        {
            foreach (GameObject obj in GameObj.Children)
            {
                myCamera = obj.GetComponent<Camera>();
                if (myCamera != null) break;
            }
        }

        public void OnShutdown(ShutdownContext context) { }
        
        public GameObject Cursor
        {
            get { return myCursor; }
            set { if (value?.Transform != null) myCursor = value; }
        }

        public bool Enabled { get; set; } = true;

        public float CursorDistanceThresholdX { get; set; } = 200f;

        public float CursorDistanceThresholdY { get; set; } = 200f;
        
        public bool UseDistanceScaling { get; set; } = true;

        public float MaxSpeed { get; set; } = 10f;

        public float SpeedScale { get; set; } = 2;

        public bool ShowThresholdArea { get; set; } = false;

        void ICmpUpdatable.OnUpdate()
        {
            if (Cursor == null || myCamera == null || !Enabled)
            {
                return;
            }

            Vector2 myPos = myCamera.GetScreenCoord(this.GameObj.Transform.Pos).Xy;
            Vector2 cursorPos = myCamera.GetScreenCoord(Cursor.Transform.Pos).Xy;

            Vector2 toCursor = cursorPos - myPos;
            
            float ellipseFactor = ((toCursor.X * toCursor.X) / (CursorDistanceThresholdX * CursorDistanceThresholdX))
                + ((toCursor.Y * toCursor.Y) / (CursorDistanceThresholdY * CursorDistanceThresholdY));
            if (ellipseFactor > 1)
            {
                Vector3 velocity = new Vector3(toCursor, 0f);
                velocity.Normalize();

                if (UseDistanceScaling)
                {
                    float speed = ellipseFactor;
                    if (speed > MaxSpeed)
                    {
                        speed = MaxSpeed;
                    }
                    velocity *= speed;
                }
                else
                {
                    velocity *= MaxSpeed;
                }

                GameObj.Transform.MoveByAbs(velocity * Time.TimeMult);
            }
        }

        float ICmpRenderer.BoundRadius { get { return float.MaxValue; } }

        bool ICmpRenderer.IsVisible(IDrawDevice device)
        {
            return ShowThresholdArea;
        }

        void ICmpRenderer.Draw(IDrawDevice device)
        {
            if (myCamera != null)
            {
                Canvas canvas = new Canvas(device);

                Vector2 myPos = myCamera.GetScreenCoord(this.GameObj.Transform.Pos).Xy;

                // Draw threshold outline
                canvas.State.ColorTint = ColorRgba.White.WithAlpha(0.5f);
                canvas.DrawOval(myPos.X - CursorDistanceThresholdX, myPos.Y - CursorDistanceThresholdY, CursorDistanceThresholdX * 2, CursorDistanceThresholdY * 2);

                // Fill the threshold area
                canvas.State.ColorTint = ColorRgba.White.WithAlpha(0.25f);
                canvas.FillOval(myPos.X - CursorDistanceThresholdX, myPos.Y - CursorDistanceThresholdY, CursorDistanceThresholdX * 2, CursorDistanceThresholdY * 2);

                // Draw a line from the center to the mouse cursor
                if (Cursor != null)
                {
                    Vector2 cursorPos = myCamera.GetScreenCoord(Cursor.Transform.Pos).Xy;

                    canvas.State.ColorTint = ColorRgba.White.WithAlpha(0.5f);
                    canvas.DrawLine(myPos.X, myPos.Y, cursorPos.X, cursorPos.Y);
                }
            }
        }

        
    }
}
