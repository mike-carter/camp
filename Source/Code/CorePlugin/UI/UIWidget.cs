using System;

using Duality;
using Duality.Editor;
using Duality.Properties;
using Duality.Components;
using Duality.Drawing;
using Duality.Input;
using Duality.Resources;

using CampGame.Resources;

namespace CampGame.UI
{
    [EditorHintImage(CoreResNames.ImageSpriteRenderer)]
    [RequiredComponent(typeof(Transform))]
    public class UIWidget : Component, ICmpInitializable
    {
        [Flags]
        public enum DirtyFlags
        {
            None = 0,
            Background = 1,
            Border = 2,
            Text = 4,
            All = 0x07
        }

        protected Vector2 size = new Vector2(100, 100);

        protected ContentRef<UISkin> skin = UISkin.Default;

        protected ColorRgba bgTint = ColorRgba.White;

        protected ColorRgba borderTint = ColorRgba.White;

        [DontSerialize] protected Rect screenArea;

        [DontSerialize] protected VertexC1P3T2[] bgVertices;

        [DontSerialize] protected VertexC1P3T2[] borderVertices;

        [DontSerialize] protected DirtyFlags dirtyFlags;

        public Vector2 Size
        {
            get { return size; }
            set
            {
                size = value;
                dirtyFlags |= DirtyFlags.All;
            }
        }

        public ContentRef<UISkin> Skin
        {
            get { return skin; }
            set
            {
                skin = value;
                dirtyFlags |= DirtyFlags.All;
            }
        }

        public ColorRgba BackgroundTint
        {
            get { return bgTint; }
            set
            {
                bgTint = value;
                dirtyFlags |= DirtyFlags.Background;
            }
        }

        public ColorRgba BorderTint
        {
            get { return borderTint; }
            set
            {
                borderTint = value;
                dirtyFlags |= DirtyFlags.Border;
            }
        }

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect ScreenArea { get { return screenArea; } }
        

        public virtual void OnInit(InitContext context)
        {
        }
        
        public virtual void OnShutdown(ShutdownContext context)
        {
        }

        public virtual void Draw(IDrawDevice device)
        {
            UISkin skinRes = (skin == null) ? null : skin.Res;
            if (skinRes == null) return;

            Rect oldScreenArea = screenArea;

            screenArea.Pos = device.GetScreenCoord(GameObj.Transform.Pos).Xy;
            screenArea.Size = size * GameObj.Transform.Scale;

            if (screenArea != oldScreenArea)
                dirtyFlags |= DirtyFlags.All;
            
            Texture baseTexture = skinRes.BackgroundMaterial;

            if (skinRes == null || skinRes.BackgroundMaterial) return;

            if (vertices == null || vertices.Length != 36)
                vertices = new VertexC1P3T2[36];

            ColorRgba 
            
            /*****************************
			 *  0     3| 4     7| 8    11
			 *
			 *  1     2| 5     6| 9    10
			 * --    --+--    --+--    --
			 * 12    15|16    19|20    23
			 *
			 * 13    14|17    18|21    22
			 * --    --+--    --+--    --
			 * 24    27|28    31|32    35
			 *
			 * 25    26|29    30|33    34
			 *****************************/
        }

        protected virtual void PrepareBGVertices(IDrawDevice device, ColorRgba mainColor, Rect uvRect)
        {
            if (bgVertices == null || bgVertices.Length != 4) bgVertices = new VertexC1P3T2[4];

            bgVertices[0].Pos.Xy = screenArea.TopLeft;
            bgVertices[0].Pos.Z = 0f;
            bgVertices[0].TexCoord = uvRect.TopLeft;
            bgVertices[0].Color = mainColor;

            bgVertices[1].Pos.Xy = screenArea.BottomLeft;
            bgVertices[1].Pos.Z = 0f;
            bgVertices[1].TexCoord = uvRect.BottomLeft;
            bgVertices[1].Color = mainColor;

            bgVertices[2].Pos.Xy = screenArea.BottomRight;
            bgVertices[2].Pos.Z = 0f;
            bgVertices[2].TexCoord = uvRect.BottomRight;
            bgVertices[2].Color = mainColor;

            bgVertices[3].Pos.Xy = screenArea.TopRight;
            bgVertices[3].Pos.Z = 0f;
            bgVertices[3].TexCoord = uvRect.TopRight;
            bgVertices[3].Color = mainColor;
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
