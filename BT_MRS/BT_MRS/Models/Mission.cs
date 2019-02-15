using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace BT_MRS.Models
{
    public class Mission
    {
        [PrimaryKey]
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool Status { get; set; }
        string Type { get; set; }
        int Cost { get; set; }
        int Objective1 { get; set; }
        int Objective2 {get;set;}
        int Objective3 { get; set; }
        int Bonus1 { get; set; }
        int Bonus2 { get; set; }
        int Bonus3 { get; set; }
        string Obj1Desc { get; set; }
        string Obj2Desc { get; set; }
        string Obj3Desc { get; set; }
        bool Obj1Status { get; set; }
        bool Obj2Status { get; set; }
        bool Obj3Status { get; set; }
        bool Bon1Status { get; set; }
        bool Bon2Status { get; set; }
        bool Bon3Status { get; set; }

    }
}
