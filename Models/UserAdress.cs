using System.ComponentModel.DataAnnotations;

namespace BaigiamasisAPI.Models
{
    public class UserAdress //gyvenamoji vieta
    {
        [Key]
        public long Id { get; set; }
        public string Town { get; set; } = string.Empty;
        public string Road { get; set; } = string.Empty;
        public string HomeNumer { get; set; } = string.Empty;
        public string? FlatNumber { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; //home, work, hollyday
    }
}
