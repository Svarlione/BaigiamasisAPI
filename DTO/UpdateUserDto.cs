namespace BaigiamasisAPI.DTO
{
    public class UpdateUserDto
    {
        public string Email { get; set; }
        public AddressDto Address { get; set; }
        public ImageDto Image { get; set; }
        public long PhoneNumber { get; set; }
        public byte[] Password { get; set; }
    }
}
