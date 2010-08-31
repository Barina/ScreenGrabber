using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenGrabber
{
    /// <summary>
    /// A class for holding a detailed snaps
    /// </summary>
    public class Snap
    {
        #region Components
        private byte[] bmp;
        private ImageFormat ext;
        private DateTime date;
        private int accountID;
        #endregion

        // Constructor
        public Snap(Image bmp, ImageFormat ext, DateTime Date, int AccountID)
        {
            this.ext = ext;
            this.bmp = ImageToByteArray(bmp, ext);
            this.date = Date;
            this.accountID = AccountID;
        }

        #region Properties
        public Image BmpAsImage { get { return byteArrayToImage(bmp); } }

        public byte[] BmpAsByteArray { get { return bmp; } }

        public ImageFormat getImageFormat { get { return ext; } }

        public DateTime Date { get { return date; } }

        public int AccountID { get { return accountID; } }
        #endregion

        /// <summary>
        /// Convering Image to byte array
        /// </summary>
        /// <param name="Bmp">The image to be converted</param>
        /// <param name="ext">The desired image format - null accepted(default image format = jpeg)</param>
        /// <returns>byte array from Image</returns>
        static public byte[] ImageToByteArray(Image Bmp, ImageFormat ext)
        {
            if(Bmp == null)
                throw new NullReferenceException("Bmp cannot be null");

            try
            {
                MemoryStream ms = new MemoryStream();
                if(ext != null)
                    Bmp.Save(ms, ext);
                else
                    Bmp.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); throw ex; }
        }

        /// <summary>
        /// Converting byte array to Image
        /// </summary>
        /// <param name="byteArray">The array to be converted</param>
        /// <returns>Image from the byte array</returns>
        static public Image byteArrayToImage(byte[] byteArray)
        {
            if(byteArray == null)
                throw new NullReferenceException("byteArray cannot be null");

            try
            {
                MemoryStream ms = new MemoryStream(byteArray);
                Image returnBmp = Image.FromStream(ms);
                return returnBmp;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); throw ex; }
        }

        /// <summary>
        /// Checking if this Snap equals to another Snap by parameters.
        /// </summary>
        /// <param name="obj">Other Snap to be compare.</param>
        /// <returns>If both are equals.</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Snap;
            if(bmp == other.bmp)
                if(date == other.date)
                    return accountID == other.accountID;
            return false;
        }

        public override int GetHashCode()
        {
            return bmp.GetHashCode() + date.GetHashCode() / 2 + accountID;
        }

        public override string ToString()
        {
            Size size = BmpAsImage.Size;
            return "Taked on: "+date.ToShortDateString()+". Size: "+size.Width+"x"+size.Height+". Format: "+ext+".";
        }

        /// <summary>
        /// Try to convert any Obect to Snap.
        /// </summary>
        /// <param name="Object">The Obect you want to convert.</param>
        /// <param name="snap">Referance that will get the new Object if it can convert to Snap or null if doesnt.</param>
        /// <returns>If Obect was converted to Snap.</returns>
        public static bool tryConvert(object Object, out Snap snap)
        {
            try
            {
                snap = (Snap)Object;
                return true;
            }
            catch
            {
                snap = null;
                return false;
            }
        }
    }
}