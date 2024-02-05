namespace BaigiamasisAPI.DTO
{
    public class CreateUserDto
    {
        public string FirstName { get; set; }
        public string LaststName { get; set; }
        public long PersonalIndefication { get; set; }
        public string Email { get; set; }
        public LoginInfoDto LoginInfo { get; set; }
        public AddressDto Address { get; set; }
        public ImageDto Image { get; set; }
        public long PhoneNumber { get; set; }
    }
}
