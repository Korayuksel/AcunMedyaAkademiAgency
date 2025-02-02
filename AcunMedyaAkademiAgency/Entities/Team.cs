using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaAkademiAgency.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public string NameSurname { get; set; }
        public string Work { get; set; }
        public string ImageURL { get; set; }
    }
}