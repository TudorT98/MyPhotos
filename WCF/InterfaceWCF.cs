using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyPhotosV2;

namespace WCF
{

        [ServiceContract]
     public interface InterfaceEvent
        {
            [OperationContract]
            bool AddEvent(MyPhotosV2.Event @event);
            [OperationContract]
            bool UpdateEvent(MyPhotosV2.Event @event);
            [OperationContract]
            bool DeleteEvent(int id);
            [OperationContract]
            Event GetEventByName(string Name);
            [OperationContract]
            List<String> GetEventsName();
            [OperationContract]
            List<Event> GetEvents();

            [OperationContract]
            Event GetEventById(int id);

 

        [OperationContract]
        int GetEventIdByName(string name);

        }
        [ServiceContract]
     public interface InterfaceLandScape
        {
            [OperationContract]
            bool AddLandScape(LandScape landScape);
            [OperationContract]
            bool UpdateLandScape(LandScape landScape);
            [OperationContract]
            bool DeleteLandScape(int id);
            [OperationContract]
            LandScape GetLandScapeByName(string Name);
            [OperationContract]
            List<string> GetLandScapeName();

            [OperationContract]
            List<string> GetLandScapesName();

        [OperationContract]
        int GetLandScapeIdByName(string name);

        [OperationContract]
        List<LandScape> GetLandScapes();

        [OperationContract]
        LandScape GetLandScapeById(int id);
    }

        [ServiceContract]
      public interface InterfaceLocation
        {
            [OperationContract]
            bool AddLocation(Location location);
            [OperationContract]
            bool UpdateLocation(Location location);
            [OperationContract]
            bool DeleteLocation(int id);
            [OperationContract]
            Location GetLocationByName(string Name);
            [OperationContract]
            List<string> GetLocationsName();

            

        [OperationContract]
        int GetLocationIdByName(string name);


        [OperationContract]
        List<Location> GetLocations();

        [OperationContract]
        Location GetLocationById(int id);
    }

        [ServiceContract]
     public interface InterfacePerson
        {
            [OperationContract]
            bool AddPerson(Person person);
            [OperationContract]
            bool UpdatePerson(Person person);
            [OperationContract]
            bool DeletePerson(int id);
            [OperationContract]
            Person GetPersonByName(string Name);
         
            [OperationContract]
            List<String> GetPeopleName();

        [OperationContract]
        int GetPersonIdByName(string name);

        [OperationContract]
        List<Person> GetPeople();

        [OperationContract]
        Person GetPersonById(int id);


    }
        [ServiceContract]
      public interface InterFacePhoto
        {
            [OperationContract]
            bool AddPhoto(Photo photo);
        [OperationContract]
        bool UpdatePhoto(Photo photo, int @eventId, int landScapeId, int personId, int locationId);
       
            [OperationContract]
            bool DeletePhoto(int id);
          
            [OperationContract]
            List<Photo> GetPhoto(int LocationId, int LandScapeId, int PersonId, int EventId);

            [OperationContract]
            void UpdateIsRemoved(Photo photo);

            [OperationContract]
            List<string> GetPhotosName();

        [OperationContract]
        List<Photo> GetPhotos();

        [OperationContract]
        Photo GetPhotoById(int id);



    }
        [ServiceContract]
        public interface IMyPhotos : InterfaceEvent,InterfaceLandScape,InterfaceLocation,InterfacePerson,InterFacePhoto
        {

        }
}
