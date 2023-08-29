using CustomValidations.Utility;

namespace CustomValidations.Models
{
    public class Profile
    {
        public string Name { get; set; }

        //We want to allow only some of the file formats like png jpeg etc 

        [MaxFileResolutions(1)]
        [AllowedExtensions(new string[] {".png",".jpg",".jpeg"})]
        public IFormFile?  ProfileImage { get; set; }
    }
}
