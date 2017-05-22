using PGS.Domain.Abstract;
using PGS.Domain.Entities;
using System.Collections.Generic;

namespace PGS.Domain.Concrete
{
    public class EfUserRepository : IUserRepository
    {
        private EfDbContext context = new EfDbContext();

        public IEnumerable<User> Users
        {
            get
            {
                return context.Users;
            }
        }

        public void SaveUser(User user)
        {
            if (user.Id == 0)
                context.Users.Add(user);

            context.SaveChanges();
        }
    }
}
