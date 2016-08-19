using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Components;
using Duality.Drawing;
using Duality.Resources;

namespace CampGame.UI
{
    public class UIRenderer : Component, ICmpRenderer, ICmpInitializable
    {
        public bool Visible { get; set; } = true;

        public Vector2 Size { get; set; } = new Vector2(100f, 100f);

        public Vector2 Offset { get; set; } = Vector2.Zero;

        public float ZOffset { get; set; } = 0f;

        public ContentRef<Material> Material { get; set; } = null;

        public Alignment Position { get; set; } = Alignment.Bottom;

        public Vector2 Pos { get; protected set; } = Vector2.Zero;

        public Rect ScreenArea { get { return new Rect(Pos.X, Pos.Y, Size.X, Size.Y); } }

        public virtual void OnInit(InitContext context)
        {

        }

        public virtual void OnShutdown(ShutdownContext context)
        {
            if (context == ShutdownContext.Deactivate)
            {
                Material.Detach();
            }
        }

        public virtual bool IsVisible(IDrawDevice device)
        {
            return Visible &&
                (device.VisibilityMask & VisibilityFlag.ScreenOverlay) != VisibilityFlag.None &&
                (device.VisibilityMask & VisibilityFlag.AllGroups) != VisibilityFlag.None;
        }

        public virtual void Draw(IDrawDevice device)
        {
            Canvas canvas = new Canvas(device);

            Vector2 screenSize = device.TargetSize;
            Vector2 panelSize = Size;
            Vector2 panelPos = Vector2.Zero;

            switch (Position)
            {
                case Alignment.Center:
                    panelPos.X = (screenSize.X / 2) - (panelSize.X / 2);
                    panelPos.Y = (screenSize.Y / 2) - (panelSize.Y / 2);
                    break;
                case Alignment.Left:
                    panelPos.Y = (screenSize.Y / 2) - (panelSize.Y / 2);
                    break;
                case Alignment.Right:
                    panelPos.X = screenSize.X - panelSize.X;
                    panelPos.Y = (screenSize.Y / 2) - (panelSize.Y / 2);
                    break;
                case Alignment.Top:
                    panelPos.X = (screenSize.X / 2) - (panelSize.X / 2);
                    break;
                case Alignment.TopLeft:
                    break;
                case Alignment.TopRight:
                    panelPos.X = screenSize.X - panelSize.X;
                    break;
                case Alignment.Bottom:
                    panelPos.X = (screenSize.X / 2) - (panelSize.X / 2);
                    panelPos.Y = screenSize.Y - panelSize.Y;
                    break;
                case Alignment.BottomLeft:
                    panelPos.Y = screenSize.Y - panelSize.Y;
                    break;
                case Alignment.BottomRight:
                    panelPos.X = screenSize.X - panelSize.X;
                    panelPos.Y = screenSize.Y - panelSize.Y;
                    break;
            }

            panelPos += Offset;

            Pos = panelPos;

            ContentRef<Material> matRef = Material == null ? Duality.Resources.Material.Checkerboard : Material;

            canvas.State.SetMaterial(matRef);

            canvas.FillRect(panelPos.X, panelPos.Y, ZOffset, Size.X, Size.Y);
        }

        float ICmpRenderer.BoundRadius { get { return Size.Length / 2; } }
    }
}
