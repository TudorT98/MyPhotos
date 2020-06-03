using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPhotosRazor.Model;
using ServiceReferenceMyPhotos;

namespace MyPhotosRazor.Pages.Photos
{
    public class IndexModel : PageModel
    {
        MyPhotosClient myPhotosClient = new MyPhotosClient();
        public List<PhotoDTO> Photos { get; set; }
        public int Count;
    



        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
      

        public IndexModel()
        {
            Photos = new List<PhotoDTO>();
            
        }
        public async Task OnGetAsync()
        {
            var photos = await myPhotosClient.GetPhotosAsync();
            var locations = await myPhotosClient.GetLocationsAsync();
            var events = await  myPhotosClient.GetEventsAsync();
            var landscapes = await myPhotosClient.GetLandScapesAsync();
            foreach (var item in photos)
            {
                
                PhotoDTO pd = new PhotoDTO();
            pd.Id = item.Id;
            pd.FullPath = item.FullPath;
            pd.EventId = item.EventId;
            pd.LandScapeId = item.LandScapeId;
            pd.LocationId = item.LocationId;


           

            Location location = await myPhotosClient.GetLocationByIdAsync(pd.LocationId);
            pd.LocationName = location.LocationName;

            Event @event = await myPhotosClient.GetEventByIdAsync(pd.EventId);
            pd.EventName = @event.EventName;

            LandScape landScape = await myPhotosClient.GetLandScapeByIdAsync(pd.LandScapeId);
            pd.LandScapeName = landScape.LandScapeName;

            Photos.Add(pd);
           


            //  Console.WriteLine("photo " + pd.FullPath);
             }

            if (!string.IsNullOrEmpty(SearchString))
            {
                searchForString();
            }
            sortPhotos();
            Count = Photos.Count();
        }

        public void searchForString ()
        {
            for( int i = 0; i < Photos.Count(); i++)
            {
                if( !(Photos[i].EventName.Contains(SearchString) || Photos[i].LocationName.Contains(SearchString) || Photos[i].LandScapeName.Contains(SearchString)) )
                {
                    Photos.RemoveAt(i);
                }
            }
        }
        public void sortPhotos()
        {
           Photos = Photos.OrderBy(photo => photo.EventName).ThenBy(photo => photo.LandScapeName).ThenBy(photo => photo.LocationName).ToList();
        }
    }
}