namespace Anandashram.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public int Established { get; set; }

        [DisplayName("Address")]
        [MaxLength(200)]
        public string? AddressLine1 { get; set; }

        [MaxLength(200)]
        public string? AddressLine2 { get; set; }

        [MaxLength(100)]
        public string? State { get; set; }

        [MaxLength(100)]
        public string? Country { get; set; }

        [DisplayName("Pin Code")]
        [MaxLength(10)]
        public string? PinCode { get; set; }
        [MaxLength(100)]
        [DisplayName("Phone/Mobile")]
        public string Mobile { get; set; } = null!;
        [MaxLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; } = null!;
        [DisplayName("Website")]
        [MaxLength(100)]
        public string Website { get; set; } = null!;
    }
}
