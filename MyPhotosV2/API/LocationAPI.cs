using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosV2
{
    public class LocationAPI
    {
        public void AddLocation(Location location)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.LocationSet.Add(location);
                ctx.SaveChanges();
            }
        }
        public List<String> GetLocationsName()
        {
            List<string> locationsName = new List<string>();
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var locations = from l in ctx.LocationSet select l.LocationName;
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
                var id = from l in ctx.LocationSet where (l.LocationName == name) select l.Id;
                return (int)(id.SingleOrDefault());
            }
        }
        public Location GetLocationByName(string name)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var location = from l in ctx.LocationSet where (l.LocationName == name) select l;
                if (location != null)
                    return location.SingleOrDefault();
                return null;
            }
        }
    }
}
