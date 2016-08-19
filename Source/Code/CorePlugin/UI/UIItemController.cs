namespace CampGame.UI
{
    [Duality.RequiredComponent(typeof(UIRenderer))]
    public abstract class UIItemController : Duality.Component
    {
        public abstract void OnMouseEnter();

        public abstract void OnMouseLeave();

        public abstract void OnClick(Duality.Input.MouseButtonEventArgs e);
    }
}
