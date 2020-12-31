using Hospital.Models;
using System;
using System.ComponentModel;

namespace HospitalApp.Models
{
    class ShiftTable
    {
        [DisplayName("Id")]
        public int id { get; set; }

        [DisplayName("Data")]
        public DateTime date { get; set; }

        [Browsable(false)]
        public int user_id { get; set; }

        [Browsable(false)]
        public Shift original_shift { get; set; }
    }
}
