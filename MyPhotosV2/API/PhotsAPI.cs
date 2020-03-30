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
        public List<Photo> GetPhoto(int LocationId, int LandScapeId, int PersonId, int EventId)
        {
            List<Photo> photos;
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var queryable = ctx.PhotoSet
                .Where(x => x.EventId == EventId && EventId != 0)
                .Where(x => x.LocationId == LocationId && LocationId != 0)
                .Where(x => x.LandScapeId == LandScapeId && LandScapeId != 0)
                .Where(x => x.PersonId == PersonId && PersonId != 0);
                photos = queryable.ToList();
            }
            return photos;
        }
        public void UpdateIsRemoved(Photo photo)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var result = ctx.PhotoSet.SingleOrDefault(p => p.Id == photo.Id);
                if (result != null)
                {
                    result.isRemoved = "true";
                    ctx.SaveChanges();
                }
            }
        }


    }
}
