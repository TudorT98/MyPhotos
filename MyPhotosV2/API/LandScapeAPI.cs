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
                return (int)(id.SingleOrDefault());
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
    }
}
