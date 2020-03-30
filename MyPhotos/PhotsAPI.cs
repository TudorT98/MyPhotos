using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class PhotsAPI
    {
        public void AddPhoto(Photo photo)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Photos.Add(photo);
                ctx.SaveChanges();
            }
        }
    }
}
