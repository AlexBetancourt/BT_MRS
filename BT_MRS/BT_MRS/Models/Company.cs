using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT_MRS.Models
{
    public class Company
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string HomePlanet { get; set; }
        public int FoundationYear { get; set; }
        public string CurrentAffiliation { get; set; }

        public override string ToString()
        {
            return this.Name + "(" + this.CurrentAffiliation + ")";
        }
    }
}
