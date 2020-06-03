using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosV2
{
    public class LandScapeAPI
    {
        public void AddLandScape(LandScape landscape)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.LandScapeSet.Add(landscape);
                ctx.SaveChanges();
            }
        }
        public List<String> GetLandScapeName()
        {
            List<string> landscapeName = new List<string>();
            using (PhotoContainer ctx = new PhotoContainer())
            {
               var landscapes = from l in ctx.LandScapeSet select l.LandScapeName;
                if (landscapes != null)
                {
                    landscapeName = landscapes.ToList();
                }
                return landscapeName;
            }
        }
        public int GetIdByName(string name)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var id = from l in ctx.LandScapeSet where (l.LandScapeName == name) select l.Id;
                return (int)(id.FirstOrDefault());
            }
        }
        public LandScape GetLandScapeByName(string name)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var landScape = from l in ctx.LandScapeSet where (l.LandScapeName == name) select l;
                if (landScape != null)
                    return landScape.SingleOrDefault();
                return null;
            }
        }
        public bool UpdateLandScape(int id,string landscapeName,string landscapeDescription)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var result = ctx.LandScapeSet.SingleOrDefault(l => l.Id == id);
                if (result != null)
                {
                    result.LandScapeName = landscapeName;
                    result.LandScapeDescription = landscapeDescription;
                    return true;
                }
                return false;
            }
        }
        public bool DeleteLandScape(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Database.ExecuteSqlCommand("Delete From Landscapes where Id =@p0", id);
                return true;
            }
        }

        public List<LandScape> GetLandScapes()
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var landScapes = from l in ctx.LandScapeSet select l;
                if (landScapes != null)
                    return landScapes.ToList();
                return null;
            }
        }

        public LandScape GetLandScapeById(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var landScape = from l in ctx.LandScapeSet where (l.Id == id) select l;
                return landScape.FirstOrDefault();
            }
        }
    }
}
