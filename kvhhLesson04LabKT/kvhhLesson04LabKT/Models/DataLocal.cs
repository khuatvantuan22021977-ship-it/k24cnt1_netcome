namespace kvhhLesson04LabKT.Models
{
 
        /// <summary>
        /// DataLocal: chứa dữ liệu và các phương thức thực hiện các chức năng CRUD
        /// </summary>
        public class DataLocal
        {
            public static List<People> _peoples = new List<People>()
    {
        new People()
        {
            Id = 0,
            Name = "cute",
            Email = "devmaster.edu.vn@gmail.com",
            Phone = "2410900034",
            Address = "25 Vũ Ngọc Phan",
            Avatar = "/images/avatar/1.jpg",
            Birthday = Convert.ToDateTime("2012/09/22"),
            Bio = "Viện Công Nghệ Devmaster",
            Gender = 0
        },
        new People()
        {
            Id = 1,
            Name = "siêu cute",
            Email = "khuatvanhoanghiepj@gmail.com",
            Phone = "2410900034",
            Address = "25 Vũ Ngọc Phan",
            Avatar = "/images/avatar/2.jpg",
            Birthday = Convert.ToDateTime("1979/05/25"),
            Bio = "Devmaster Academy",
            Gender = 1
        },
        new People()
        {
            Id = 2,
            Name = "ngầu",
            Email = "khuatvanhoanghiep@gmail.com",
            Phone = "2410900034",
            Address = "Gia Lâm, Hà Nội",
            Avatar = "/images/avatar/3.jpg",
            Birthday = Convert.ToDateTime("1999/02/12"),
            Bio = "Viện Devmaster",
            Gender = 1
        },
        new People()
        {
            Id = 3,
            Name = "Tiểu Long Nữ",
            Email = "longnutieu@gmail.com",
            Phone = "0904001002",
            Address = "Ba Đình, Hà Nội",
            Avatar = "/images/avatar/4.jpg",
            Birthday = Convert.ToDateTime("2000/02/02"),
            Bio = "Nhân vật trong phim kiếm hiệp",
            Gender = 2
        },
        new People()
        {
            Id = 4,
            Name = "Pikachu cute",
            Email = "chupika@gmail.com",
            Phone = "0902114115",
            Address = "Quang Trung, Hà Đông",
            Avatar = "/images/avatar/5.jpg",
            Birthday = Convert.ToDateTime("1997/12/12"),
            Bio = "Nhân vật trong phim hoạt hình",
            Gender = 2
        },
        new People()
        {
            Id = 5,
            Name = "Pikachu",
            Email = "chupika@gmail.com",
            Phone = "0902114115",
            Address = "Quang Trung, Hà Đông",
            Avatar = "/images/avatar/6.jpg",
            Birthday = Convert.ToDateTime("1997/12/12"),
            Bio = "Nhân vật trong phim hoạt hình",
            Gender = 2
        },
    };

            /// <summary>
            /// GetPeoples: Lấy danh sách dữ liệu peoples
            /// </summary>
            /// <returns></returns>
            public static List<People> GetPeoples()
            {
                return _peoples;
            }

            /// <summary>
            /// GetPeopleById : Lấy đối tượng peoples theo id
            /// </summary>
            /// <param name="Id"></param>
            /// <returns>peoples</returns>
            public static People? GetPeopleById(int Id)
            {
                var people = _peoples.FirstOrDefault(x => x.Id == Id);
                return people;
            }
        }
    }
