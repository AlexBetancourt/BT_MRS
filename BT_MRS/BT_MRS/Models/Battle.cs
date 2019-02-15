using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace BT_MRS.Models
{
    public class Battle
    {
        [PrimaryKey]
        int Id { get; set; }
        string Name { get; set; }
        DateTime BattleDate { get; set; }
        string Location { get; set; }

    }
}
