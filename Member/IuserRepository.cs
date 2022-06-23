using Microsoft.AspNetCore.Mvc;

namespace H.W_9.Member
{
    public interface userRepository
    {
        IEnumerable<User> Users { get; set; }
    }
}


public class UserControlles : Controller
{
  
}