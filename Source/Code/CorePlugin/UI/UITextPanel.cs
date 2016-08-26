using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;
using Duality.Components;
using Duality.Drawing;
using Duality.Editor;

namespace CampGame.UI
{
    public class UITextPanel : UIPanel, ICmpInitializable
    {
        protected FormattedText text = null;
        protected ColorRgba textColor = ColorRgba.DarkGrey;
        protected Vector2 textPosition = Vector2.Zero;
        protected bool textVisible = false;
        
        public virtual FormattedText Text
        {
            get { dirtyFlags |= DirtyFlags.Text; return text; }
            set { dirtyFlags |= DirtyFlags.Text; text = value; }
        }

        public virtual Vector2 TextPosition
        {
            get { return textPosition; }
            set { dirtyFlags |= DirtyFlags.Text; textPosition = value; }
        }

        public ColorRgba TextColor
        {
            get { return textColor; }
            set { dirtyFlags |= DirtyFlags.Text; textColor = value; }
        }

        public virtual bool TextVisible
        {
            get { return textVisible; }
            set { textVisible = value; }
        }

        protected override void Draw(IDrawDevice device, Rect drawArea)
        {
        }

        protected void DrawText(IDrawDevice device)
        {

        }
    }
}
