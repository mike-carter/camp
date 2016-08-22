using Duality;
using Duality.Components;
using Duality.Drawing;
using Duality.Input;
using Duality.Resources;

namespace CampGame.UI
{
    [RequiredComponent(typeof(Transform))]
    public class UIWidget : Component, ICmpInitializable
    {
        protected Rect widgetArea = Rect.Empty;

        [DontSerialize]
        protected Rect screenArea = Rect.Empty;

        public float BoundRadius { get { return Rect.Size.Length; } }

        public Rect Rect
        {
            get { return widgetArea; }
            set { widgetArea = value; }
        }

        /// <summary>
        /// [GET] The area that this widget covers on the screen
        /// </summary>
        public Rect ScreenArea { get { return screenArea; } }

        public ContentRef<Material> BaseMaterial { get; set; } = Material.Checkerboard;

        public float ZOffset { get; set; } = 0f;
        
        public virtual void OnInit(InitContext context)
        {
            if (context == InitContext.Activate)
            {
                //if (BaseMaterial != null)
                //{
                //    widgetArea.Size = BaseMaterial.Res.MainTexture.Res.Size;
                //}

                UIInputManager inputManager = GameObj.ParentScene.FindComponent<UIInputManager>();
                if (inputManager != null)
                {
                    inputManager.AddWidget(this);
                }

                foreach (UIRenderer renderer in GameObj.ParentScene.FindComponents<UIRenderer>())
                {
                    if (GameObj.IsChildOf(renderer.GameObj))
                    {
                        renderer.AddWidget(this);
                    }
                }

            }
        }
        
        public virtual void OnShutdown(ShutdownContext context)
        {
            if (context == ShutdownContext.Deactivate)
            {
                if (BaseMaterial != null)
                    BaseMaterial.Detach();
            }
        }

        public virtual void Draw(IDrawDevice device)
        {
            if (GameObj.Transform == null)
                return;

            Canvas canvas = new Canvas(device);

            if (BaseMaterial == null)
                BaseMaterial = Material.Checkerboard;

            screenArea.Pos = device.GetScreenCoord(GameObj.Transform.Pos).Xy;
            screenArea.Size = Rect.Size * device.GetScaleAtZ(GameObj.Transform.Pos.Z);

            canvas.State.SetMaterial(BaseMaterial);

            canvas.FillRect(screenArea.X, screenArea.Y, screenArea.W, screenArea.H);
        }

        // Events

        public virtual void OnKeyPress(KeyboardKeyEventArgs e) { }

        public virtual void OnMouseEnter() { }

        public virtual void OnMouseLeave() { }

        public virtual void OnClick(MouseButtonEventArgs e) { }

        public virtual void OnRelease(MouseButtonEventArgs e) { }

        public virtual void OnMouseWheelMove(MouseWheelEventArgs e) { }
    }
}
