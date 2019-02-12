using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT_MRS.Models
{
    public class Pilot
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Piloting { get; set; }
        public int Gunnery { get; set; }
        public int Hits { get; set; }
        public int Age { get; set; }
        public string HomePlanet { get; set; }
        public string Affiliation { get; set; }
    }
}
