using System;
using System.Collections.Generic;

namespace ASECOND.Models
{
    class UserRepository : IUserRepository
    {
        public List<User> users = new List<User>();
        private int _nextId = 1;

        public UserRepository()
        {
            Add(new User { firstName = "cristian", lastName = "Vargas",});
            Add(new User { firstName = "Yeika", lastName = "Robles",});
            Add(new User { firstName = "random1", lastName = "random1",});
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }
        public User Add(User item)
        {
            if ( item == null)
            {
                throw new NotImplementedException();
            }
            item.Id = _nextId++;
            users.Add(item);
            return item;
        }

        public User deleteUser(string id)
        {
            Models.User user = getThis(id);
            users.Remove(user);
            return user;
        }

        public User getThis(string id)
        {
            User user = users.Find(x => x.Id == int.Parse(id));
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }

            return user;
        }

        public User updateUser(string id, User updatedUser)
        {
            Models.User user = getThis(id);
            user.firstName = updatedUser.firstName;
            user.lastName = updatedUser.lastName;

            return user;

        }
    }
}