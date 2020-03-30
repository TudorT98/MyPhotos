using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class EventAPI
    {
        public void AddEvent(Events myEvent)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Events.Add(myEvent);
                ctx.SaveChanges();
            }
        }
        public List<String> GetEventsName()
        {
            List<string> eventsName = new List<string>();
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var events = (from e in ctx.Events select e.EventName);
                if (events != null)
                {
                    eventsName = events.ToList();
                }
                return eventsName;
            }
        }
        public int GetIdByName(string name)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var id = from e in ctx.Events where (e.EventName == name) select e.Id;
                return (int)(id.SingleOrDefault());
            }
     }
}
    }
