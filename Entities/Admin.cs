using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Start_Up_Group.Entities
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Is_delete { get; set; }

        public static Admin Create(string name,string position, string username, string password)
        {
            var newUser = new Admin();
            newUser.Name = name;
            newUser.Position = position;
            newUser.Username = username;
            newUser.Password = password;
            newUser.Is_delete = false;

            return newUser;
        }

        public void UpdateInfo(string name,string position,string username,string password)
        {
            this.Name = name.Length > 0 ? name : this.Name;
            this.Position = position.Length > 0 ? position : this.Position;
            this.Username = username.Length > 0 ? username : this.Username;
            this.Password = password.Length > 0 ? password : this.Password;
        }

        public void DeleteInfo()
        {
            this.Is_delete = true;
        }
    }

}
