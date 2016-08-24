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
    public class UIPanel : Renderer, ICmpInitializable
    {
        protected const float ZOffsetScale = 0.1f;

        [Flags]
        public enum DirtyFlags : short
        {
            None = 0,
            Background = 1,
            Border = 2,
            Text = 4,
            Icon = 8,

            All = -1
        }

        public enum BorderAlign : short
        {
            Center,
            InsideEdge,
            OutsideEdge
        }

        protected Vector2 size = new Vector2(100, 100);
        protected ContentRef<UISkin> skin = UISkin.Default;
        protected int offset = 0;

        protected ColorRgba bgTint = ColorRgba.White;
        protected ColorRgba borderTint = ColorRgba.White;

        protected bool useCustomWidths = false;
        protected Vector4 borderWidths = Vector4.Zero;
        protected BorderAlign borderAlign = BorderAlign.Center;
        
        protected bool isVisible = true;
        protected bool bordersVisible = true;

        [DontSerialize] protected Rect screenArea;
        [DontSerialize] protected bool hasFocus;
        [DontSerialize] protected bool mouseHovering;

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

        public int ZOffset
        {
            get { return offset; }
            set { offset = value; dirtyFlags |= DirtyFlags.All; }
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

        public bool UseCustomBorderWidths
        {
            get { return useCustomWidths; }
            set
            {
                useCustomWidths = value;
                dirtyFlags |= DirtyFlags.Border;
            }
        }

        /// <summary>
        /// [GET/SET] Allows us to resize the widget border. X, Y, Z, W correspond to Left, Top, Right, Bottom.
        /// Values are ignored unless UseCustomBorderWidths is set to true. Otherwise, the border widths defined
        /// in the UISkin are used.
        /// </summary>
        public Vector4 BorderWidths
        {
            get { return borderWidths; }
            set
            {
                borderWidths = value;
                dirtyFlags |= DirtyFlags.Border;
            }
        }

        public BorderAlign BorderAlignment
        {
            get { return borderAlign; }
            set { borderAlign = value; dirtyFlags |= DirtyFlags.Border; }
        }

        public bool Visible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }

        public bool BordersVisible
        {
            get { return bordersVisible; }
            set { bordersVisible = value; }
        }

        

        [EditorHintFlags(MemberFlags.Invisible)]
        public Rect ScreenArea { get { return screenArea; } }

        public override float BoundRadius
        {
            get { return screenArea.BoundingRadius; }
        }
        
        public virtual void OnInit(InitContext context)
        {
            VisibilityGroup = VisibilityFlag.AllFlags | VisibilityFlag.ScreenOverlay;
        }
        
        public virtual void OnShutdown(ShutdownContext context)
        {
        }

        public override bool IsVisible(IDrawDevice device)
        {
            return (device.VisibilityMask & VisibilityFlag.ScreenOverlay) != VisibilityFlag.None &&
                (device.VisibilityMask & VisibilityFlag.AllGroups) != VisibilityFlag.None;
        }

        public override void Draw(IDrawDevice device)
        {
            DetermineScreenArea(device);

            if (isVisible)
            {
                DrawBackground(device);

                if (bordersVisible) DrawBorders(device);
            }
        }

        protected virtual void DetermineScreenArea(IDrawDevice device)
        {
            Rect oldScreenArea = screenArea;

            screenArea.Pos = device.GetScreenCoord(GameObj.Transform.Pos).Xy;
            screenArea.Size = size * GameObj.Transform.Scale;
            
            if (screenArea != oldScreenArea)
                dirtyFlags |= DirtyFlags.All;
        }

        protected void DrawBackground(IDrawDevice device)
        {
            UISkin skinRes = skin.Res;
            Material bgMat = skinRes?.BackgroundMaterial.Res ?? Material.Checkerboard.Res;
            Texture bgTex = bgMat?.MainTexture.Res ?? Texture.Checkerboard.Res;

            if (bgMat == null || bgTex == null) return;

            if ((dirtyFlags & DirtyFlags.Background) != DirtyFlags.None)
            {
                ColorRgba mainColor = bgMat.MainColor * bgTint;
                Rect uvRect = new Rect(bgTex.UVRatio);

                if (bgVertices == null || bgVertices.Length != 4) bgVertices = new VertexC1P3T2[4];

                float zval = offset * ZOffsetScale;

                bgVertices[0].Pos.Xy = screenArea.TopLeft;
                bgVertices[0].Pos.Z = zval;
                bgVertices[0].TexCoord = uvRect.TopLeft;
                bgVertices[0].Color = mainColor;

                bgVertices[1].Pos.Xy = screenArea.BottomLeft;
                bgVertices[1].Pos.Z = zval;
                bgVertices[1].TexCoord = uvRect.BottomLeft;
                bgVertices[1].Color = mainColor;

                bgVertices[2].Pos.Xy = screenArea.BottomRight;
                bgVertices[2].Pos.Z = zval;
                bgVertices[2].TexCoord = uvRect.BottomRight;
                bgVertices[2].Color = mainColor;

                bgVertices[3].Pos.Xy = screenArea.TopRight;
                bgVertices[3].Pos.Z = zval;
                bgVertices[3].TexCoord = uvRect.TopRight;
                bgVertices[3].Color = mainColor;

                dirtyFlags -= DirtyFlags.Background;
            }
            
            device.AddVertices(bgMat, VertexMode.Quads, bgVertices);
        }

        protected void DrawBorders(IDrawDevice device)
        {
            UISkin skinRes = skin.Res;
            Material borderMat = skinRes?.BorderMaterial.Res ?? Material.Checkerboard.Res;
            Texture borderTex = borderMat?.MainTexture.Res ?? Texture.Checkerboard.Res;

            if (skinRes == null || borderMat == null || borderTex == null) return;

            if ((dirtyFlags & DirtyFlags.Border) != DirtyFlags.None)
            {
                /*****************************
			     *  0     3| 4     7| 8    11
			     *
			     *  1     2| 5     6| 9    10
			     * --    --+--    --+--    --
			     * 12    15|        |16    19
			     *
			     * 13    14|        |17    18
			     * --    --+--    --+--    --
			     * 20    23|24    27|28    31
			     *
			     * 21    22|25    26|29    30
			     *****************************/

                ColorRgba mainColor = borderMat.MainColor * borderTint;
                
                float leftWidth, topWidth, rightWidth, bottomWidth;

                if (useCustomWidths)
                {
                    leftWidth = borderWidths.X;
                    topWidth = borderWidths.Y;
                    rightWidth = borderWidths.Z;
                    bottomWidth = borderWidths.W;
                }
                else
                {
                    leftWidth = skinRes.LeftBorder.Y;
                    topWidth = skinRes.TopBorder.Y;
                    rightWidth = skinRes.RightBorder.Y;
                    bottomWidth = skinRes.BottomBorder.Y;
                }

                Rect topLeftCorner, topRightCorner, bottomLeftCorner, bottomRightCorner;

                if (borderAlign == BorderAlign.InsideEdge)
                {
                    topLeftCorner = Rect.Align(Alignment.BottomRight, screenArea.LeftX, screenArea.TopY, leftWidth, topWidth);
                    topRightCorner = Rect.Align(Alignment.BottomLeft, screenArea.RightX, screenArea.TopY, rightWidth, topWidth);
                    bottomLeftCorner = Rect.Align(Alignment.TopRight, screenArea.LeftX, screenArea.BottomY, leftWidth, bottomWidth);
                    bottomRightCorner = Rect.Align(Alignment.TopLeft, screenArea.RightX, screenArea.BottomY, rightWidth, bottomWidth);
                }
                else if (borderAlign == BorderAlign.Center)
                {
                    topLeftCorner = Rect.Align(Alignment.Center, screenArea.LeftX, screenArea.TopY, leftWidth, topWidth);
                    topRightCorner = Rect.Align(Alignment.Center, screenArea.RightX, screenArea.TopY, rightWidth, topWidth);
                    bottomLeftCorner = Rect.Align(Alignment.Center, screenArea.LeftX, screenArea.BottomY, leftWidth, bottomWidth);
                    bottomRightCorner = Rect.Align(Alignment.Center, screenArea.RightX, screenArea.BottomY, rightWidth, bottomWidth);
                }
                else // outside edge
                {
                    topLeftCorner = Rect.Align(Alignment.TopLeft, screenArea.LeftX, screenArea.TopY, leftWidth, topWidth);
                    topRightCorner = Rect.Align(Alignment.TopRight, screenArea.RightX, screenArea.TopY, rightWidth, topWidth);
                    bottomLeftCorner = Rect.Align(Alignment.BottomLeft, screenArea.LeftX, screenArea.BottomY, leftWidth, bottomWidth);
                    bottomRightCorner = Rect.Align(Alignment.BottomRight, screenArea.RightX, screenArea.BottomY, rightWidth, bottomWidth);
                }

                if (borderVertices == null || borderVertices.Length != 32) borderVertices = new VertexC1P3T2[32];

                PrepareBorderVertices(0, mainColor, topLeftCorner.TopLeft, topLeftCorner.BottomRight, skinRes.GetBorderUV(BorderSections.TopLeft));
                
                PrepareBorderVertices(4, mainColor, topLeftCorner.TopRight, topRightCorner.BottomLeft, skinRes.GetBorderUV(BorderSections.Top));
                
                PrepareBorderVertices(8, mainColor, topRightCorner.TopLeft, topRightCorner.BottomRight, skinRes.GetBorderUV(BorderSections.TopRight));
                
                PrepareBorderVertices(12, mainColor, topLeftCorner.BottomLeft, bottomLeftCorner.TopRight, skinRes.GetBorderUV(BorderSections.Left));
                
                PrepareBorderVertices(16, mainColor, topRightCorner.BottomLeft, bottomRightCorner.TopRight, skinRes.GetBorderUV(BorderSections.Right));
                
                PrepareBorderVertices(20, mainColor, bottomLeftCorner.TopLeft, bottomLeftCorner.BottomRight, skinRes.GetBorderUV(BorderSections.BottomLeft));
                
                PrepareBorderVertices(24, mainColor, bottomLeftCorner.TopRight, bottomRightCorner.BottomLeft, skinRes.GetBorderUV(BorderSections.Bottom));
                
                PrepareBorderVertices(28, mainColor, bottomRightCorner.TopLeft, bottomRightCorner.BottomRight, skinRes.GetBorderUV(BorderSections.BottomRight));

                dirtyFlags -= DirtyFlags.Border;
            }

            device.AddVertices(borderMat, VertexMode.Quads, borderVertices);
        }

        protected void PrepareBorderVertices(int sectionStart, ColorRgba mainColor, Vector2 topLeft, Vector2 bottomRight, Rect uvRect)
        {
            float zval = offset * ZOffsetScale;

            borderVertices[sectionStart].Pos.Xy = topLeft;
            borderVertices[sectionStart].Pos.Z = zval;
            borderVertices[sectionStart].TexCoord = uvRect.TopLeft;
            borderVertices[sectionStart].Color = mainColor;

            borderVertices[sectionStart + 1].Pos.X = topLeft.X;
            borderVertices[sectionStart + 1].Pos.Y = bottomRight.Y;
            borderVertices[sectionStart + 1].Pos.Z = zval;
            borderVertices[sectionStart + 1].TexCoord = uvRect.BottomLeft;
            borderVertices[sectionStart + 1].Color = mainColor;

            borderVertices[sectionStart + 2].Pos.Xy = bottomRight;
            borderVertices[sectionStart + 2].Pos.Z = zval;
            borderVertices[sectionStart + 2].TexCoord = uvRect.BottomRight;
            borderVertices[sectionStart + 2].Color = mainColor;

            borderVertices[sectionStart + 3].Pos.X = bottomRight.X;
            borderVertices[sectionStart + 3].Pos.Y = topLeft.Y;
            borderVertices[sectionStart + 3].Pos.Z = zval;
            borderVertices[sectionStart + 3].TexCoord = uvRect.TopRight;
            borderVertices[sectionStart + 3].Color = mainColor;
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
