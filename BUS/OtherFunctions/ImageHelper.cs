using System;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace BUS.OtherFunctions
{
    public class ImageHelper
    {
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                try { image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg); }
                catch { image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png); }
                return memoryStream.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    // Thử chuyển đổi dữ liệu byte thành hình ảnh
                    try
                    {
                        Image image = Image.FromStream(memoryStream);
                        return image;
                    }
                    catch (ArgumentException ex)
                    {
                        Debug.WriteLine("Lỗi: " + ex.Message);
                        return null;
                    }
                }
            }
            else
            {
                Debug.WriteLine("Dữ liệu hình ảnh không hợp lệ!");
                return null;
            }
        }
    }
}
