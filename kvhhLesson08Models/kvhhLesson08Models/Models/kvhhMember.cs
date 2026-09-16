using System.ComponentModel;

namespace kvhhLesson08Models.Models
{
    public class kvhhMember
    {
        public string kvhhMemberId { get; set; }
        public string kvhhUserName { get; set; }
        public string kvhhPassword { get; set; }

       [DisplayName("họ và tên ")]
        public string kvhhFullName { get; set; }
        public string kvhhEmail { get; set; }
    }
}
