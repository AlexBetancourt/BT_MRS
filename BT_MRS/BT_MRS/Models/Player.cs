using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BT_MRS.Models
{
    public class Player
    {
        [PrimaryKey]
        int Id { get; set; }
        string Name { get; set; }
        string Callsign { get; set; }
    }
}
