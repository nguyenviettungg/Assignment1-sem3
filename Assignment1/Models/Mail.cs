using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    class Mail
    {
        private string email;
        private string title;
        private string description;

        public Mail(string email, string title, string description)
        {
            this.email = email;
            this.title = title;
            this.description = description;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }

        public string ToString()
        {
            return Email + "--" + Title + "--" + Description + "\n";
        }
    }

}
