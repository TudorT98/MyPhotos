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
                return (int)(id.FirstOrDefault());
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

        public bool UpdateLocation(int id, string locationName, string locationDescription, string type)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var result = ctx.LocationSet.SingleOrDefault(l => l.Id == id);
                if (result != null)
                {
                    result.LocationName = locationName;
                    result.LocationDescription = locationDescription;
                    result.LocationType = type;
                    return true;
                }
                return false;
            }
        }
        public bool DeleteLocation(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Database.ExecuteSqlCommand("Delete From Locations where Id =@p0", id);
                return true;
            }
        }

        public List<Location> GetLocation()
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var locations = from l in ctx.LocationSet select l;
                if (locations != null)
                    return locations.ToList();
                return null;
            }
        }

        public Location GetLocationById(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var locations = from l in ctx.LocationSet where (l.Id == id) select l;
                return locations.FirstOrDefault();
            }

        }
    }
}
