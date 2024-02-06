using System.ComponentModel.DataAnnotations;

namespace BaigiamasisAPI.Models
{
    public class User //zmogaus ingormacija
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LaststName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public long PersonalIndefication { get; set; }
        public string Email { get; set; } = string.Empty;

        public LoginInfo LoginInfo { get; set; }


        public List<UserAdress> LivingInfo { get; set; } = new List<UserAdress>();

        [Required]
        public Image Image { get; set; }

    }
}
