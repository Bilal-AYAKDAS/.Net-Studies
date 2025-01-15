namespace Week4.Models
{
    public class User
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public User()
        {
        }
        public User(int id, string name, string surname, string email)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Email = email;
        }



    }
}
