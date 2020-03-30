using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosV2
{
    public class PhotsAPI
    {
        public void AddPhoto(Photo photo)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.PhotoSet.Add(photo);
                ctx.SaveChanges();
            }
        }
    }
}
