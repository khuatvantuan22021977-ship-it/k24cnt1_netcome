namespace kvhhLesson04Lab.Models
{
    public class kvhhAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone  {  get; set; }
        public string Anime { get; set; }

        public string Address { get; set; }

        public string Bio { get; set; }
        public int Gender { get; set; }
        public  DateTime Birthday { get; set; }
    }
}
