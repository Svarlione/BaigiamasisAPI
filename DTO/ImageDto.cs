using System.ComponentModel.DataAnnotations;

namespace BaigiamasisAPI.DTO
{
    public class ImageDto
    {
        [Required(ErrorMessage = "Pavadinimas yra privalomas")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Aprašymas yra privalomas")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Nuotrauka yra privaloma")]
        public byte[] ImageBytes { get; set; }
    }
}
