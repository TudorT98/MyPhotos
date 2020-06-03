using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotosRazor.Model;
using ServiceReferenceMyPhotos;

namespace MyPhotosRazor.Pages.PhotoDetails
{
    public class PhotoDetailsModel : PageModel
    {
        [BindProperty]
        public PhotoDTO photoDTO { get; set; }
       // public int Count;

        MyPhotosClient myPhotosClient = new MyPhotosClient();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = myPhotosClient.GetPhotoByIdAsync(id.Value);

            if (photo == null)
            {
                return NotFound();
            }

            photoDTO.Id = id.Value;
            photoDTO.isMovie = photo.Result.isMovie;
            photoDTO.isRemoved = photo.Result.isRemoved;
            photoDTO.EventId = photo.Result.EventId;
            photoDTO.LandScapeId = photo.Result.LandScapeId;
            photoDTO.LocationId = photo.Result.LocationId;

            LandScape landScape = await myPhotosClient.GetLandScapeByIdAsync(photoDTO.LandScapeId);
            photoDTO.LandScapeName = landScape.LandScapeName;
            string landscapeDescpritpion = landScape.LandScapeDescription;

            Location location = await myPhotosClient.GetLocationByIdAsync(photoDTO.LocationId);
            photoDTO.LocationName = location.LocationName;
            string locationDescription = location.LocationDescription;

            Event myEvent = await myPhotosClient.GetEventByIdAsync(photoDTO.EventId);
            photoDTO.EventName = myEvent.EventName;
            string eventDescription = myEvent.EventDescription;



            return Page();
        }
    }
}