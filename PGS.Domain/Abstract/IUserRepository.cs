using PGS.Domain.Entities;
using System.Collections.Generic;

namespace PGS.Domain.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }
        void SaveUser(User user);
    }
}
