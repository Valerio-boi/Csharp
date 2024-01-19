namespace ApiWeb
{
    public class FakeDataBase
    {
        public List<User> Users { get; set; }
        private int generatedId = 0;

        FakeDataBase() {

            AddUser(new User
            {
                UserName = "UserName1",
                Name = "Name1",
                surname = "Surname1",
                password = "Password1",
            });

            AddUser(new User
            {
                UserName = "UserName2",
                Name = "Name2",
                surname = "Surname2",
                password = "Password2",
            });

            AddUser(new User
            {
                UserName = "UserName3",
                Name = "Name3",
                surname = "Surname3",
                password = "Password3",
            });

            AddUser(new User
            {
                UserName = "UserName4",
                Name = "Name4",
                surname = "Surname4",
                password = "Password4",
            });

        }

        public void AddUser(User user)
        {
            user.Id = generatedId++;
            Users.Add(user);
            Console.WriteLine("User aggiunto.");
        }

    }

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
    }
}
