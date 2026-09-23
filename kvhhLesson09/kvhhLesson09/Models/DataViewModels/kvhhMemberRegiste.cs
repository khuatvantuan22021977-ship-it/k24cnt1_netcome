using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace kvhhLesson09.Models.DataViewModels
{
    /// <summary>
    /// Data Annotation - Validation
    /// </summary>
    public class KvhhMemberRegister
    {
        public int KvhhMemberId { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Tên đăng nhập phải từ 3 đến 20 ký tự")]
        public string KvhhUserName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(50, MinimumLength = 6,
            ErrorMessage = "Mật khẩu phải từ 6 đến 50 ký tự")]
        [DataType(DataType.Password)]
        public string KvhhPassword { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string KvhhEmail { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không đúng định dạng")]
        public string KvhhPhoneNumber { get; set; }

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        public string KvhhFullName { get; set; }

        [DisplayName("Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime KvhhBirthday { get; set; }
    }
}