using System;
using System.Collections.Generic;
using System.Linq;

using Duality;
using Duality.Input;
using Duality.Drawing;
using Duality.Editor;

namespace CampGame.UI
{
    public abstract class UIControl : Component, ICmpRenderer, ICmpInitializable
    {
        [Flags]
        public enum DirtyFlags : int
        {
            None = 0,
            Parent = 1,
            Children = 2,
            ScreenPos = 4,
            Layout = 1,
            Background = 2,
            Border = 4,
            Text = 8,
            Image = 16,

            All = -1
        }

        private Rect rect = new Rect(100, 100);
        private Rect displayRegion = new Rect(100, 100);
        protected int zOffset = 0;
        protected bool isVisible = true;

        [DontSerialize] protected bool hasFocus;
        [DontSerialize] protected UIControl parentContainer;
        [DontSerialize] private List<UIControl> controls;
        [DontSerialize] private Vector2 screenPos;
        [DontSerialize] private Rect visibleArea;

        [DontSerialize] protected DirtyFlags dirtyFlags;

        #region Properties

        public UIControl ParentControl
        {
            get
            {
                if (CheckFlag(DirtyFlags.Parent))
                {
                    GameObject climber = GameObj.Parent;
                    parentContainer = null;

                    while (climber != null && parentContainer == null)
                    {
                        parentContainer = climber.GetComponents<UIControl>().FirstOrDefault();
                        climber = climber.Parent;
                    }
                    ClearFlag(DirtyFlags.Parent);
                }
                return parentContainer;
            }
        }

        public IEnumerable<UIControl> ChildControls
        {
            get
            {
                if (CheckFlag(DirtyFlags.Children))
                {
                    if (controls.Count > 0) controls.Clear();
                    var childControls = GameObj.Children.GetComponents<UIControl>();
                    controls.AddRange(childControls);
                    ClearFlag(DirtyFlags.Children);
                }
                return controls as IEnumerable<UIControl>;
            }
        }

        

        /// <summary>
        /// [GET / SET] The pixel coordinates of the UI element
        /// </summary>
        [EditorHintDecimalPlaces(0)]
        public Vector2 Location
        {
            get { return rect.Pos; }
            set
            {
                rect.Pos = value;
                SetFlag(DirtyFlags.ScreenPos);
                SetChildFlags(DirtyFlags.ScreenPos, true);
            }
        }

        /// <summary>
        /// [GET / SET] The rectangular size of the UI element.
        /// </summary>
        [EditorHintDecimalPlaces(0)]
        public Vector2 Size
        {
            get { return rect.Size; }
            set { rect.Size = value; }
        }

        /// <summary>
        /// [GET] The actual pixel coordinates of the top left corner of this control.
        /// </summary>
        public Vector2 ScreenPos
        {
            get
            {
                if (CheckFlag(DirtyFlags.ScreenPos))
                {
                    screenPos = (ParentControl == null) ? Location : Location + ParentControl.ScreenPos;
                    ClearFlag(DirtyFlags.ScreenPos);
                }
                return screenPos;
            }
        }

        /// <summary>
        /// [GET / SET] The region of the control in which drawing is allowed. Child controls whose bounds 
        /// exceed this area are cropped.
        /// </summary>
        public Rect DisplayRegion
        {
            get { return displayRegion; }
            set { displayRegion = value; }
        }
        
        /// <summary>
        /// [GET] The region of the screen in which this control is visible and can be interacted with.
        /// </summary>
        public Rect ScreenArea
        {
            get
            {
                if (ParentControl == null) return rect;
                return rect.Intersection(ParentControl.DisplayRegion).WithOffset(ScreenPos);
            }
        }

        /// <summary>
        /// [GET / SET] A virtual Z offset that determines in which order elements are drawn. 
        /// </summary>
        public int ZOffset
        {
            get { return zOffset; }
            set { dirtyFlags |= DirtyFlags.All; zOffset = value; }
        }

        /// <summary>
        /// [GET / SET] Determines if we are to draw this element.
        /// </summary>
        public bool Visible
        {
            get
            {
                if (isVisible)
                {
                    if (ParentControl == null) return true;

                    return ParentControl.Visible;
                }
                return false;
            }
            set { isVisible = value; }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public bool HasFocus
        {
            get { return hasFocus; }
            set { hasFocus = value; }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public virtual bool CanHaveFocus
        {
            get { return false; }
        }
        
        [EditorHintFlags(MemberFlags.Invisible)]
        public float BoundRadius { get { return float.MaxValue; } }

        public virtual void OnInit(InitContext context)
        {
            if (context == InitContext.Activate || context == InitContext.AddToGameObject)
            {
                parentContainer = GetParentWidget();
            }
        }

        #endregion

        public virtual void OnShutdown(ShutdownContext context)
        {
            if (context == ShutdownContext.RemovingFromGameObject)
            {
                parentContainer = null;
            }
        }


        public virtual void Draw(IDrawDevice device)
        {
        }

        protected abstract void Draw(IDrawDevice device, Rect drawArea);

        public bool IsVisible(IDrawDevice device)
        {
            return isVisible &&
                (device.VisibilityMask & VisibilityFlag.ScreenOverlay) != VisibilityFlag.None &&
                (device.VisibilityMask & VisibilityFlag.AllGroups) != VisibilityFlag.None;
        }

        protected UIControl GetParentWidget()
        {
            UIControl parentWidget = null;
            GameObject climber = GameObj.Parent;

            while (climber != null && parentWidget == null)
            {
                parentWidget = climber.GetComponents<UIControl>().FirstOrDefault();
                climber = climber.Parent;
            }
            return parentWidget;
        }

        protected bool CheckFlag(DirtyFlags flag)
        {
            return (dirtyFlags & flag) != DirtyFlags.None;
        }

        protected void SetFlag(DirtyFlags flag)
        {
            dirtyFlags |= flag;
        }

        protected void ClearFlag(DirtyFlags flag)
        {
            dirtyFlags &= ~flag;
        }

        protected void SetChildFlags(DirtyFlags flag, bool deep = false)
        {
            foreach (UIControl child in this.ChildControls)
            {
                child.SetFlag(flag);
                if (deep) child.SetChildFlags(flag);
            }
        }

        #region Events

        public virtual void OnKeyPress(KeyboardKeyEventArgs e) { }

        public virtual void OnMouseEnter(MouseMoveEventArgs e) { }

        public virtual void OnMouseLeave(MouseMoveEventArgs e) { }

        public virtual void OnClick(MouseButtonEventArgs e) { }

        public virtual void OnDrag(MouseMoveEventArgs e) { }

        public virtual void OnMouseWheelMove(MouseWheelEventArgs e) { }

        #endregion
    }
}
