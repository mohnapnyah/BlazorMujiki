using System.Collections.Generic;
namespace BlazorMujiki.Data
{
     public class SingletonService
    {
        List<Unit> users = new List<Unit>();

        public List<Unit> GetUser()
        {
            return users;
        }
        public void SetUser(List<Unit> newUser)
        {
            users = newUser;
        }
    }
}
