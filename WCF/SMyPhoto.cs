using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotosV2;
namespace WCF
{
    public class SMyPhoto : IMyPhotos
    {
        bool InterfaceEvent.AddEvent(Event @event)
        {
            EventAPI eventAPI = new EventAPI();
            eventAPI.AddEvent(@event);
            return true;
        }
        bool InterfaceEvent.DeleteEvent(int id)
        {
            EventAPI @event = new EventAPI();
            return true;
        }
        Event InterfaceEvent.GetEventByName(string Name)
        {
            EventAPI @event = new EventAPI();
            return @event.GetEventByName(Name);
        }
        List<string> InterfaceEvent.GetEventsName()
        {
            EventAPI @event = new EventAPI();
            return @event.GetEventsName();
        }



        bool InterfaceLandScape.AddLandScape(LandScape landScape)
        {
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            landScapeAPI.AddLandScape(landScape);
            return true;


        }
        bool InterfaceLandScape.DeleteLandScape(int id)
        {
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            return landScapeAPI.DeleteLandScape(id);
          
        }
        LandScape InterfaceLandScape.GetLandScapeByName(string Name)
        {
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            return landScapeAPI.GetLandScapeByName(Name);
        }
        List<string> InterfaceLandScape.GetLandScapesName()
        {
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            return landScapeAPI.GetLandScapeName();
        }

        bool InterfaceLocation.AddLocation(Location location)
        {
            LocationAPI locationAPI = new LocationAPI();
            locationAPI.AddLocation(location);
            return true;
        }
        bool InterfaceLocation.DeleteLocation(int id)
        {
            LocationAPI locationAPI = new LocationAPI();
            return locationAPI.DeleteLocation(id) ;
        }
        Location InterfaceLocation.GetLocationByName(string Name)
        {
            LocationAPI locationAPI = new LocationAPI();
            return locationAPI.GetLocationByName(Name);

        }
        List<string> InterfaceLocation.GetLocationsName()
        {
            LocationAPI locationAPI = new LocationAPI();
            return locationAPI.GetLocationsName(); 
        }


        bool InterfacePerson.AddPerson(Person person)
        {
            PersonAPI personAPI = new PersonAPI();
            personAPI.AddPerson(person);
            return true;
        }
        bool InterfacePerson.DeletePerson(int id)
        {
            PersonAPI personAPI = new PersonAPI();
            personAPI.DeletePerson(id);
            return true;
        }
        Person InterfacePerson.GetPersonByName(string Name)
        {
            PersonAPI personAPI = new PersonAPI();
            return personAPI.GetPersonByName(Name);
        }
        List<string> InterfacePerson.GetPeopleName()
        {
            PersonAPI personAPI = new PersonAPI();
            return personAPI.GetPeopleName();
        }

        bool InterFacePhoto.AddPhoto(Photo photo)
        {
            PhotsAPI photsAPI = new PhotsAPI();
            photsAPI.AddPhoto(photo);
            return true;
        }
        bool InterFacePhoto.DeletePhoto(int id)
        {
            PhotsAPI photsAPI = new PhotsAPI();
            return photsAPI.DeletePhoto(id); 
        }

        List<string> InterFacePhoto.GetPhotosName()
        {
            PersonAPI personAPI = new PersonAPI();
            return personAPI.GetPeopleName();
        }

        bool InterfaceEvent.UpdateEvent(Event @event)
        {

            EventAPI eventAPI = new EventAPI();
            return eventAPI.UpdateEvent(@event.Id, @event.EventName, @event.EventDescription);
        }

        bool InterfaceLandScape.UpdateLandScape(LandScape landScape)
        {
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            return landScapeAPI.UpdateLandScape(landScape.Id, landScape.LandScapeName, landScape.LandScapeDescription);
        }

        bool InterfaceLocation.UpdateLocation(Location location)
        {
            LocationAPI locationAPI = new LocationAPI();
            return locationAPI.UpdateLocation(location.Id, location.LocationName, location.LocationDescription, location.LocationType);
        }

        bool InterfacePerson.UpdatePerson(Person person)
        {
            PersonAPI personAPI = new PersonAPI();
            return personAPI.updatePerson(person.Id, person.FirstName, person.LastName, person.Age);
        }

        bool InterFacePhoto.UpdatePhoto(Photo photo, int @eventId, int landScapeId, int personId, int locationId)
        {
            PhotsAPI photsAPI = new PhotsAPI();
            return photsAPI.UpdatePhoto(photo, eventId, landScapeId, personId, locationId);
        }

        List<Photo> InterFacePhoto.GetPhoto(int LocationId, int LandScapeId, int PersonId, int EventId)
        {
            PhotsAPI photsAPI = new PhotsAPI();
            return photsAPI.GetPhoto(LocationId, LandScapeId, PersonId, EventId);
        }

        void InterFacePhoto.UpdateIsRemoved(Photo photo)
        {
            PhotsAPI photsAPI = new PhotsAPI();
            photsAPI.UpdateIsRemoved(photo);
        }

        

        List<string> InterfaceLandScape.GetLandScapeName()
        { 
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            return landScapeAPI.GetLandScapeName();
        }

      

      

        int InterfaceEvent.GetEventIdByName(string name)
        {
            EventAPI eventAPI = new EventAPI();
            return eventAPI.GetIdByName(name);
        }

        int InterfaceLandScape.GetLandScapeIdByName(string name)
        {
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            return landScapeAPI.GetIdByName(name);
        }

        int InterfaceLocation.GetLocationIdByName(string name)
        {
            LocationAPI locationAPI = new LocationAPI();
            return locationAPI.GetIdByName(name);
        }

        int InterfacePerson.GetPersonIdByName(string name)
        {
            PersonAPI personAPI = new PersonAPI();
            return personAPI.GetIdByName(name);
        }

        public List<Event> GetEvents()
        {
            EventAPI eventAPI = new EventAPI();
            return eventAPI.GetEvents();
        }
        public Event GetEventById(int id)
        {
            EventAPI eventAPI = new EventAPI();
                return eventAPI.GetEventById( id);
        }

        public List<LandScape> GetLandScapes()
        {
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            return landScapeAPI.GetLandScapes();
        }

        public LandScape GetLandScapeById(int id)
        {
            LandScapeAPI landScapeAPI = new LandScapeAPI();
            return landScapeAPI.GetLandScapeById(id);
        }

        public List<Location> GetLocations()
        {
            LocationAPI locationAPI = new LocationAPI();
            return locationAPI.GetLocation();
        }

        public Location GetLocationById(int id)
        {
            LocationAPI locationAPI = new LocationAPI();
            return  locationAPI.GetLocationById(id);
        }

        public List<Person> GetPeople()
        {
            PersonAPI personAPI = new PersonAPI();
            return personAPI.GetPeople();
        }

        public Person GetPersonById(int id)
        {
            PersonAPI personAPI = new PersonAPI();
            return personAPI.GetPersonById(id);
        }

        public List<Photo> GetPhotos()
        {
            PhotsAPI photsAPI = new PhotsAPI();
            return photsAPI.GetPhoto();
        }

        public Photo GetPhotoById(int id)
        {
            PhotsAPI photsAPI = new PhotsAPI();
            return photsAPI.GetPhotoById(id);
        }
    }
}
