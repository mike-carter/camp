using Duality;
using Duality.Drawing;
using Duality.Resources;

namespace CampGame.UI
{
    public class UIImagePanel : UIPanel
    {
        protected ContentRef<Material> image = null;
        protected Rect imageRect = new Rect(100, 100);
        protected ColorRgba imageTint = ColorRgba.White;
        protected bool imageVisible = true;

        [DontSerialize] VertexC1P3T2[] imageVertices = new VertexC1P3T2[4];

        public ContentRef<Material> Image
        {
            get { return image; }
            set { dirtyFlags |= DirtyFlags.Image; image = value; }
        }

        public Rect ImageRect
        {
            get { return imageRect; }
            set { dirtyFlags |= DirtyFlags.Image; imageRect = value; }
        }

        public ColorRgba ImageTint
        {
            get { return imageTint; }
            set { dirtyFlags |= DirtyFlags.Image; imageTint = value; }
        }

        public bool ImageVisible
        {
            get { return imageVisible; }
            set { imageVisible = value; }
        }

        protected override void Draw(IDrawDevice device, Rect drawArea)
        {
            base.Draw(device, drawArea);

            if (imageVisible) DrawIcon(device, drawArea);
        }

        protected void DrawIcon(IDrawDevice device, Rect drawArea)
        {
            Material iconMat = image.Res ?? Material.Checkerboard.Res;
            Texture iconTex = iconMat?.MainTexture.Res ?? Texture.Checkerboard.Res;

            if (iconMat == null || iconTex == null) return;

            if ((dirtyFlags & DirtyFlags.Image) != DirtyFlags.None)
            {
                ColorRgba mainColor = iconMat.MainColor * imageTint;
                Rect uvRect = new Rect(iconTex.UVRatio);
                
                Rect imageScreenRect = new Rect(imageRect.Size);
                imageScreenRect.Pos = drawArea.Pos + imageRect.Pos;
                
                if (!drawArea.Contains(imageScreenRect))
                {
                    CropImage(ref imageScreenRect, ref uvRect, drawArea);
                }

                float zval = zOffset * ZOffsetScale;

                if (imageVertices == null || imageVertices.Length != 4) imageVertices = new VertexC1P3T2[4];

                imageVertices[0].Pos.Xy = imageScreenRect.TopLeft;
                imageVertices[0].Pos.Z = zval;
                imageVertices[0].TexCoord = uvRect.TopLeft;
                imageVertices[0].Color = mainColor;

                imageVertices[1].Pos.Xy = imageScreenRect.BottomLeft;
                imageVertices[1].Pos.Z = zval;
                imageVertices[1].TexCoord = uvRect.BottomLeft;
                imageVertices[1].Color = mainColor;

                imageVertices[2].Pos.Xy = imageScreenRect.BottomRight;
                imageVertices[2].Pos.Z = zval;
                imageVertices[2].TexCoord = uvRect.BottomRight;
                imageVertices[2].Color = mainColor;

                imageVertices[3].Pos.Xy = imageScreenRect.TopRight;
                imageVertices[3].Pos.Z = zval;
                imageVertices[3].TexCoord = uvRect.TopRight;
                imageVertices[3].Color = mainColor;

                dirtyFlags &= ~DirtyFlags.Image;
            }

            device.AddVertices(iconMat, VertexMode.Quads, imageVertices);
        }

        protected void CropImage(ref Rect imgPixRect, ref Rect imgUVRect, Rect cropRect)
        {
            cropRect = imgPixRect.Intersection(cropRect);

            if (cropRect == Rect.Empty || cropRect == Rect.Empty)
            {
                imgPixRect = Rect.Empty;
                imgUVRect = Rect.Empty;
                return;
            }

            Rect scaleRect = new Rect();

            if (cropRect.Pos != imgPixRect.Pos)
            {
                scaleRect.Pos = cropRect.Pos - imgPixRect.Pos;
                scaleRect.X = (cropRect.X - imgPixRect.X) / imgPixRect.W;
                scaleRect.Y = (cropRect.Y - imgPixRect.Y) / imgPixRect.H;
            }

            scaleRect.W = (imgPixRect.W - cropRect.W) / imgPixRect.W;
            scaleRect.H = (imgPixRect.H - cropRect.H) / imgPixRect.H;

            imgUVRect.X += imgUVRect.W * scaleRect.X;
            imgUVRect.Y += imgUVRect.H * scaleRect.Y;
            imgUVRect.W -= imgUVRect.W * scaleRect.W;
            imgUVRect.H -= imgUVRect.H * scaleRect.H;

            imgPixRect = cropRect;
        }
    }
}
