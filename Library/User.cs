using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        private static int _usersCounter = 0;
        private string Name { get; set; }
        private int Id { get; }

        public User(string name)
        {
            Name = name;
            Id = _usersCounter++;
        }

        public virtual string DisplayInfo()
        {
            return $"User Name: {Name}, User ID: {Id}";
        }
    }
}
