using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kvhh2410900034_exam.Models
{
    [Table("kvhhStudent")]
    public class kvhhStudent
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Họ tên")]
        public string kvhhName { get; set; }

        [Display(Name = "Giới tính")]
        public bool kvhhGender { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime kvhhBirthDay { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string? kvhhEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        public string? kvhhPhone { get; set; }

        [Display(Name = "Trạng thái")]
        public bool kvhhActive { get; set; }
    }
}