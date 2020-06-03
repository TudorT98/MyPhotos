using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosRazor.Model
{
    public class PhotoDTO
    {
        public int Id { get; set; }
        public int EventId { get; set; }

        public string EventName { get; set; }
        public int PersonId { get; set; }

        public string PersonName { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int LandScapeId { get; set; }

        public string LandScapeName { get; set; }
        public string FullPath { get; set; }
        public string isMovie { get; set; }
        public string isRemoved { get; set; }


        public PhotoDTO(string fullPath, string isMovie, string isRemoved)
        {
            FullPath = fullPath;
            this.isMovie = isMovie;
            this.isRemoved = isRemoved;
            
        }
        public PhotoDTO()
        {

        }
    }
}
