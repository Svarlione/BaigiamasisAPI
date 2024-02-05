using System.ComponentModel.DataAnnotations;

namespace BaigiamasisAPI.Models
{
    public class User //zmogaus ingormacija
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LaststName { get; set; } = string.Empty;
        public long PhoneNumber { get; set; }
        public long PersonalIndefication { get; set; }
        public string Email { get; set; } = string.Empty;


        public List<UserAdress> LivingInfo { get; set; } = new List<UserAdress>();

        [Required]
        public Image Image { get; set; }

    }
}
