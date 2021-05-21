using GymManager.Models;
using System;

namespace GymManager.Utilities
{
    public class UserBuilder 
    {
        private int RoleId;
        private string Name;
        private string Surname;
        private string Email;
        private string Password;

        public UserBuilder()
        {
        }
        public UserBuilder SetRoleId(int roleId)
        {
            this.RoleId = roleId;
            return this;
        }
        public UserBuilder SetName(string name)
        {
            this.Name = name;
            return this;
        }
        public UserBuilder SetSurname(string surname)
        {
            this.Surname = surname;
            return this;
        }
        public UserBuilder SetEmail(string email)
        {
            this.Email = email;
            return this;
        }
        public UserBuilder SetPassword(string password)
        {
            this.Password = password;
            return this;
        }

        public User Build()
        {
            var user = new User();
            user.RoleId = this.RoleId;
            user.Name = this.Name;
            user.Surname = this.Surname;
            user.Email = this.Email;
            user.Password = this.Password;
            return user;
        }
    }

}
