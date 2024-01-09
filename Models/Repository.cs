

namespace MeetingApp.Models
{
    public static class Repository
    {
        public static List<UserInfo> _users = new();

         static  Repository()
        {
            _users.Add(new UserInfo() { Name = "Ahmet", Email = "Ahmet@gmail.com", Phone = "11111", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Ali", Email = "Ali@gmail.com", Phone = "22222", WillAttend = false });
            _users.Add(new UserInfo() { Name = "Seden", Email = "Seden@gmail.com", Phone = "33333", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Özkan", Email = "Özkan@gmail.com", Phone = "44444", WillAttend = true });
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
            _users.Add(user);
        }
    } 
}
