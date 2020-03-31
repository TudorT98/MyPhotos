using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyPhotosV2;

namespace WCF
{
    public class ObjectWCF
    {
        [ServiceContract]
        interface InterfaceEvent
        {
            [OperationContract]
            bool AddEvent(Event @event);
            [OperationContract]
            Event UpdateEvent(Event @event);
            [OperationContract]
            int DeleteEvent(int id);
            [OperationContract]
            Event GetEventById(int id);
            [OperationContract]
            List<Event> GetEvents();

        }

        [ServiceContract]
        interface InterfaceLandScape
        {
            [OperationContract]
            bool AddLandScape(LandScape landScape);
            [OperationContract]
            LandScape UpdateLandScape(LandScape landScape);
            [OperationContract]
            int DeleteLandScape(int id);
            [OperationContract]
            LandScape GetLandScapeById(int id);
            [OperationContract]
            List<LandScape> GetLandScapes();
        }

        [ServiceContract]
        interface InterfaceLocation
        {
            [OperationContract]
            bool AddLocation(Location location);
            [OperationContract]
            Location UpdateLocation(Location location);
            [OperationContract]
            int DeleteLocation(int id);
            [OperationContract]
            Location GetLocationById(int id);
            [OperationContract]
            List<Location> GetLocations();
        }

        [ServiceContract]
        interface InterfacePerson
        {
            [OperationContract]
            bool AddPerson(Person person);
            [OperationContract]
            Person UpdatePerson(Person person);
            [OperationContract]
            int DeletePerson(int id);
            [OperationContract]
            Person GetPersonById(int id);
            [OperationContract]
            List<Person> GetPersons();
        }
        [ServiceContract]
        interface InterFacePhoto
        {
            [OperationContract]
            bool AddPhoto(Photo photo);
            [OperationContract]
            Photo UpdatePhoto(Photo photo);
            [OperationContract]
            int DeletePhoto(int id);
            [OperationContract]
            Photo GetPhotoById(int id);
            [OperationContract]
            List<Photo> GetPhotos();
        }





    }
}
