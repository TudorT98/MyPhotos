using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class LocationAPI
    {
        public void AddLocation(Locations location)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Locations.Add(location);
                ctx.SaveChanges();
            }
        }
        public List<String> GetLocationsName()
        {
            List<string> locationsName = new List<string>();
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var locations = from l in ctx.Locations select l.LocationName;
               if (locations != null)
               {
                    locationsName = locations.ToList();
               }
                return locationsName;
            }
        }
        public int GetIdByName(string name)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var id = from l in ctx.Locations where (l.LocationName == name) select l.Id;
                return (int)(id.SingleOrDefault());
            }
        }
    }
}
