using DataAccess;
using DataAccess.CRUD;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoreApp
{
    public class UserManager
    {

        private readonly ITarget _usersAdapter;
        private UserCRUDFactory usersAdapter;

        public UserManager(ITarget userAdapter)
        {
            _usersAdapter = userAdapter;
        }

        public UserManager(UserCRUDFactory userAdapter) 
        { 
            this.usersAdapter = userAdapter;
        }

        public void Create(User user)
        {
            if(user.cedula == null)
            {
                throw new ArgumentException("Cedula is required");
            }
            if (user.name == null)
            {
                throw new ArgumentException("Name is required");
            }
            if (user.email == null)
            {
                throw new ArgumentException("Email is required");
            }
            if (user.password == null || !Regex.IsMatch(user.password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).*$"))
            {
                throw new ArgumentException("The password is required and must contain at least one uppercase letter, one lowercase letter, and one special character.");
            }
            var um = new UserCRUDFactory();
            um.Create(user);
        }

        public void Delete(User user)
        {
            if(user.cedula == null)
            {
                throw new ArgumentException("The id cannot be null");
            }
            var um = new UserCRUDFactory();
            um.Delete(user);
        }

        public void Update(User user)
        {
            if(user.cedula == null)
            {
                throw new Exception("The cedula cannot be null");
            }
            var um = new UserCRUDFactory();
            um.Update(user);
        }

        public object? RetrieveAll()
        {
            var vc = new UserCRUDFactory();
            return vc.RetrieveAll<User>();
        }
    }
}
