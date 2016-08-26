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
    public class UIPanel : UIControl
    {
        protected const float ZOffsetScale = 0.1f;

        public enum BorderAlign : short
        {
            Center,
            InsideEdge,
            OutsideEdge
        }

        protected ContentRef<UISkin> skin = UISkin.Default;
        protected ColorRgba bgTint = ColorRgba.White;
        protected bool useCustomWidths = false;
        protected Vector4 borderWidths = Vector4.Zero;
        protected BorderAlign borderAlign = BorderAlign.Center;
        protected ColorRgba borderTint = ColorRgba.White;
        protected bool bordersVisible = true;

        
        
        [DontSerialize] protected bool mouseHovering;
        [DontSerialize] protected VertexC1P3T2[] bgVertices;
        [DontSerialize] protected VertexC1P3T2[] borderVertices;

        /// <summary>
        /// [GET / SET] The <see cref="UISkin"/> containing the background and border materials used to draw this element.
        /// </summary>
        [EditorHintDecimalPlaces(0)]
        public ContentRef<UISkin> Skin
        {
            get { return skin; }
            set { dirtyFlags |= DirtyFlags.Background | DirtyFlags.Border; skin = value; }
        }

        /// <summary>
        /// [GET / SET] The color used to tint the background image.
        /// </summary>
        public ColorRgba BackgroundTint
        {
            get { return bgTint; }
            set { dirtyFlags |= DirtyFlags.Background; bgTint = value; }
        }

        /// <summary>
        /// [GET / SET] The color used to tint the border image.
        /// </summary>
        public ColorRgba BorderTint
        {
            get { return borderTint; }
            set { dirtyFlags |= DirtyFlags.Border; borderTint = value; }
        }

        /// <summary>
        /// </summary>
        public bool UseCustomBorderWidths
        {
            get { return useCustomWidths; }
            set { dirtyFlags |= DirtyFlags.Border; useCustomWidths = value; }
        }

        /// <summary>
        /// [GET/SET] Allows us to resize the widget border. X, Y, Z, W correspond to Left, Top, Right, Bottom.
        /// Values are ignored unless UseCustomBorderWidths is set to true. Otherwise, the border widths defined
        /// in the UISkin are used.
        /// </summary>
        public Vector4 BorderWidths
        {
            get { return borderWidths; }
            set { dirtyFlags |= DirtyFlags.Border; borderWidths = value; }
        }

        public BorderAlign BorderAlignment
        {
            get { return borderAlign; }
            set { dirtyFlags |= DirtyFlags.Border; borderAlign = value; }
        }

        public bool BordersVisible
        {
            get { return bordersVisible; }
            set { dirtyFlags |= DirtyFlags.Border; bordersVisible = value; }
        }
        
        public override void OnInit(InitContext context)
        {
            if (skin.Res?.BackgroundMaterial.Res == null)
            {
                bordersVisible = false;
            }
        }
        
        public override void OnShutdown(ShutdownContext context)
        {
        }

        protected Vector4 RetrieveBorderWidths()
        {
            if (useCustomWidths)
            {
                return borderWidths;
            }
            else
            {
                UISkin skinRes = skin.Res;
                if (skinRes == null) return Vector4.Zero;
                return new Vector4(
                    skinRes.LeftBorder.Y,
                    skinRes.TopBorder.Y,
                    skinRes.RightBorder.Y,
                    skinRes.BottomBorder.Y);
            }
        }

        protected override void Draw(IDrawDevice device, Rect drawArea)
        {
            DrawBackground(device, drawArea);

            if (bordersVisible) DrawBorders(device, drawArea);
        }

        protected void DrawBackground(IDrawDevice device, Rect drawArea)
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

                float zval = zOffset * ZOffsetScale;

                bgVertices[0].Pos.Xy = drawArea.TopLeft;
                bgVertices[0].Pos.Z = zval;
                bgVertices[0].TexCoord = uvRect.TopLeft;
                bgVertices[0].Color = mainColor;

                bgVertices[1].Pos.Xy = drawArea.BottomLeft;
                bgVertices[1].Pos.Z = zval;
                bgVertices[1].TexCoord = uvRect.BottomLeft;
                bgVertices[1].Color = mainColor;

                bgVertices[2].Pos.Xy = drawArea.BottomRight;
                bgVertices[2].Pos.Z = zval;
                bgVertices[2].TexCoord = uvRect.BottomRight;
                bgVertices[2].Color = mainColor;

                bgVertices[3].Pos.Xy = drawArea.TopRight;
                bgVertices[3].Pos.Z = zval;
                bgVertices[3].TexCoord = uvRect.TopRight;
                bgVertices[3].Color = mainColor;
            }
            
            device.AddVertices(bgMat, VertexMode.Quads, bgVertices);
        }

        protected void DrawBorders(IDrawDevice device, Rect drawArea)
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

                Vector4 widths = RetrieveBorderWidths();

                Rect topLeftCorner, topRightCorner, bottomLeftCorner, bottomRightCorner;

                if (borderAlign == BorderAlign.InsideEdge)
                {
                    topLeftCorner = Rect.Align(Alignment.BottomRight, drawArea.LeftX, drawArea.TopY, widths.X, widths.Y);
                    topRightCorner = Rect.Align(Alignment.BottomLeft, drawArea.RightX, drawArea.TopY, widths.Z, widths.Y);
                    bottomLeftCorner = Rect.Align(Alignment.TopRight, drawArea.LeftX, drawArea.BottomY, widths.X, widths.W);
                    bottomRightCorner = Rect.Align(Alignment.TopLeft, drawArea.RightX, drawArea.BottomY, widths.Z, widths.W);
                }
                else if (borderAlign == BorderAlign.Center)
                {
                    topLeftCorner = Rect.Align(Alignment.Center, drawArea.LeftX, drawArea.TopY, widths.X, widths.Y);
                    topRightCorner = Rect.Align(Alignment.Center, drawArea.RightX, drawArea.TopY, widths.Z, widths.Y);
                    bottomLeftCorner = Rect.Align(Alignment.Center, drawArea.LeftX, drawArea.BottomY, widths.X, widths.W);
                    bottomRightCorner = Rect.Align(Alignment.Center, drawArea.RightX, drawArea.BottomY, widths.Z, widths.W);
                }
                else // outside edge
                {
                    topLeftCorner = Rect.Align(Alignment.TopLeft, drawArea.LeftX, drawArea.TopY, widths.X, widths.Y);
                    topRightCorner = Rect.Align(Alignment.TopRight, drawArea.RightX, drawArea.TopY, widths.Z, widths.Y);
                    bottomLeftCorner = Rect.Align(Alignment.BottomLeft, drawArea.LeftX, drawArea.BottomY, widths.X, widths.W);
                    bottomRightCorner = Rect.Align(Alignment.BottomRight, drawArea.RightX, drawArea.BottomY, widths.Z, widths.W);
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
            }

            device.AddVertices(borderMat, VertexMode.Quads, borderVertices);
        }

        protected void PrepareBorderVertices(int sectionStart, ColorRgba mainColor, Vector2 topLeft, Vector2 bottomRight, Rect uvRect)
        {
            float zval = zOffset * ZOffsetScale;

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

        
        
    }
}
