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
        public bool UpdatePhoto(Photo photo, int @eventId, int landScapeId, int personId, int locationId)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var result = ctx.PhotoSet.SingleOrDefault(p => p.Id == photo.Id);
                if (result != null)
                {
                    result.LandScapeId = landScapeId;
                    result.LocationId = locationId;
                    result.EventId = @eventId;
                    result.PersonId = personId;
                    ctx.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeletePhoto(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Database.ExecuteSqlCommand("Delete From Photos where Id =@p0", id);
                return true;
            }
        }

        public List<Photo> GetPhoto()
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var photos = from p in ctx.PhotoSet select p;
                if (photos != null)
                    return photos.ToList();
                return null;
            }
        }

        public Photo GetPhotoById(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var photo = from p in ctx.PhotoSet where (p.Id == id) select p;
                return photo.FirstOrDefault();
            }

        }
    }
}
