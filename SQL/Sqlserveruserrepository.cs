using H.W_9.Member;
using System.ComponentModel.DataAnnotations;

namespace H.W_9.SQL
{
    public class Sqlserveruserrepository : userRepository
    {
        private readonly WebApplicationBuilder webApplicationBuilder;
        public Sqlserveruserrepository(WebApplicationBuilder webApplicationBuilder)
        {
            this.webApplicationBuilder = webApplicationBuilder;
        }

        [Required]
         public IEnumerable<User> Users { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<User> GetUsers() => WebApplicationBuilder.Users;
    }
}
