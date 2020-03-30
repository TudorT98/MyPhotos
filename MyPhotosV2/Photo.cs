//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotosV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photo
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int PersonId { get; set; }
        public int LocationId { get; set; }
        public int LandScapeId { get; set; }
        public string FullPath { get; set; }
        public string isMovie { get; set; }
        public string isRemoved { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual LandScape LandScape { get; set; }
        public virtual Event Event { get; set; }
        public virtual Person Person { get; set; }

        public Photo(string fullPath, string isMovie, string isRemoved, Location location, LandScape landScape, Event @event, Person person)
        {
            FullPath = fullPath;
            this.isMovie = isMovie;
            this.isRemoved = isRemoved;
            Location = location;
            LandScape = landScape;
            Event = @event;
            Person = person;
        }
        public Photo()
        {

        }
    }


}
