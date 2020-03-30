using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class LandScapeAPI
    {
        public void AddLandScape(Landscapes landscape)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Landscapes.Add(landscape);
                ctx.SaveChanges();
            }
        }
        public List<String> GetLandScapeName()
        {
            List<string> landscapeName = new List<string>();
            using (PhotoContainer ctx = new PhotoContainer())
            {
               var landscapes = from l in ctx.Landscapes select l.LandScapeName;
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
                var id = from l in ctx.Landscapes where (l.LandScapeName == name) select l.Id;
                return (int)(id.SingleOrDefault());
            }
        }
    }
}
