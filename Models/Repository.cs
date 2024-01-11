

namespace MeetingApp.Models
{
    public static class Repository
    {
        public static List<UserInfo> _users = new();

         static  Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Ahmet", Email = "Ahmet@gmail.com", Phone = "11111", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2,  Name = "Ali", Email = "Ali@gmail.com", Phone = "22222", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3,  Name = "Seden", Email = "Seden@gmail.com", Phone = "33333", WillAttend = true });
            _users.Add(new UserInfo() { Id = 4,  Name = "Özkan", Email = "Özkan@gmail.com", Phone = "44444", WillAttend = true });
            _users.Add(new UserInfo() { Id = 5, Name = "nujin", Email = "nujin@gmail.com", Phone = "55555", WillAttend = false });
        }
        
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count() + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        } 
    } 
}
 