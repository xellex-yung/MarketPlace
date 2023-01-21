using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;

namespace MarketPlace.DO.Data.Models
{
    public class Picture
	{
        [Key, Required]
        public Guid Id { get; set; }

        public string? Code
        {
            get
            {
                if (Bytes != null)
                {
                    return Encoding.ASCII.GetString(Bytes);
                }
                return null;
            }
            set { }
        }
        public byte[]? Bytes
        {
            get
            {
                if (Code != null)
                {
                    return Encoding.ASCII.GetBytes(Code);
                }
                return null;
            }
            set { }
        }

        public Bitmap? ByteImage
        {
            get
            {
                ImageConverter converter = new ImageConverter();
                if (Bytes != null)
                {
                    Bitmap bm = (Bitmap)converter.ConvertFrom(Bytes);
                    if (bm != null &&
                    (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                        bm.VerticalResolution != (int)bm.VerticalResolution))
                    {
                        bm.SetResolution((int)(bm.HorizontalResolution + 0.5f), (int)(bm.VerticalResolution + 0.5f));
                    }
                    return bm;
                }
                else
                    return null;

            }
            set
            {

            }
        }

    }
}
