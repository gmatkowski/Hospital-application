using Hospital.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Models
{
    public class UserTable
    {
        [DisplayName("Id")]
        public int id { get; set; }

        [DisplayName("Imię")]
        public string first_name { get; set; }

        [DisplayName("Nazwisko")]
        public string last_name { get; set; }

        [DisplayName("Rola")]
        public string role { get; set; }

        [DisplayName("Specjalizacja")]
        public string specialization { get; set; }

        [Browsable(false)]
        public string pesel { get; set; }

        [Browsable(false)]
        public string pwz { get; set; }

        [Browsable(false)]
        public string fullname { 
            get
            {
                return String.Format("{0} {1}", this.first_name, this.last_name);
            }
        }

        [Browsable(false)]
        public User original_user { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.id, this.first_name, this.last_name);
        }
    }
}
