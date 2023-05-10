using System;
using System.Collections.Generic;

namespace ASECOND.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Add(User user);
        User getThis(string id);
        User updateUser(string id, User updatedUser);
        User deleteUser(string id);
    }
}