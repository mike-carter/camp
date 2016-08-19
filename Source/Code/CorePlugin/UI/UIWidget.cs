using System;
using Duality;
using Duality.Components;
using Duality.Components.Renderers;

namespace CampGame.UI
{
    [RequiredComponent(typeof(SpriteRenderer))]
    [RequiredComponent(typeof(Transform))]
    public abstract class UIWidget : Component, ICmpInitializable
    {
        [DontSerialize]
        protected SpriteRenderer sprite = null;
        
        public abstract void OnMouseEnter();

        public abstract void OnMouseLeave();

        public abstract void OnClick(Duality.Input.MouseButtonEventArgs e);

        public virtual void OnInit(InitContext context)
        {
            if (context == InitContext.Activate || context == InitContext.AddToGameObject)
            {
                SpriteRenderer renderer = GameObj.GetComponent<SpriteRenderer>();
                if (renderer != null)
                {
                    renderer.VisibilityGroup = Duality.Drawing.VisibilityFlag.AllFlags | Duality.Drawing.VisibilityFlag.ScreenOverlay;
                    renderer.Rect = new Rect(0f, 0f, renderer.Rect.W, renderer.Rect.H);
                }
            }
        }
        
        public virtual void OnShutdown(ShutdownContext context)
        {
        }

        public Rect GetAreaOnScreen()
        {
            if (sprite == null) sprite = GameObj.GetComponent<SpriteRenderer>();

            Camera activeCamera = GameObj.ParentScene.FindComponent<Camera>();

            if (activeCamera != null)
            {
                Rect area = new Rect(sprite.Rect.Size);
                area.Pos = activeCamera.GetScreenCoord(GameObj.Transform.Pos).Xy;
                return area;
            }
            else
            {
                return new Rect();
            }
        }

        
    }
}
