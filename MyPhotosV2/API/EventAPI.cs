using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosV2
{
    public class EventAPI
    {
        public void AddEvent(Event myEvent)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.EventSet.Add(myEvent);
                ctx.SaveChanges();
            }
        }
        public List<String> GetEventsName()
        {
            List<string> eventsName = new List<string>();
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var events = (from e in ctx.EventSet select e.EventName);
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
                var id = from e in ctx.EventSet where (e.EventName == name) select e.Id;
                return (int)(id.FirstOrDefault());
            }
     }
        public Event GetEventByName(string name)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var myevent = from e in ctx.EventSet where (e.EventName == name) select e;
                if (myevent != null)
                    return myevent.SingleOrDefault();
                return null;
            }
        }

        public bool DeleteEvent(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                ctx.Database.ExecuteSqlCommand("Delete From Events where Id =@p0", id);
                return true;
            }
        }
        public bool UpdateEvent(int id,string EventName,string EventDescription)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var result = ctx.EventSet.SingleOrDefault(e => e.Id == id);
                if (result != null)
                {
                    result.EventName = EventName;
                    result.EventDescription = EventDescription;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Event> GetEvents()
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var myevents = from e in ctx.EventSet  select e;
                if (myevents != null)
                    return myevents.ToList();
                return null;
            }
        }

        public Event GetEventById(int id)
        {
            using (PhotoContainer ctx = new PhotoContainer())
            {
                var myEvent = from e in ctx.EventSet where (e.Id == id) select e;
                return myEvent.FirstOrDefault();
            }
        }

    }
    }
