using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT_MRS.Models
{
    public class Mech
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Variant { get; set; }

        public int Walking { get; set; }
        public int Running { get; set; }
        public int Jumping { get; set; }

        public int Tonnage { get; set; }
        public int HeatSinks { get; set; }

        //ARMOR HIT POINTS
        public int HeadHP { get; set; }
        public int CenterTHP { get; set; }
        public int LeftTHP { get; set; }
        public int RightTHP { get; set; }
        public int LeftAHP { get; set; }
        public int RightAHP { get; set; }
        public int LeftLHP { get; set; }
        public int RightLHP { get; set; }

        //REAR ARMOR HIT POINTS
        public int CenterTRHP { get; set; }
        public int LeftTRHP { get; set; }
        public int RightTRHP { get; set; }

        //INTERNAL HIT POINT
        public int HeadIHP { get; set; }
        public int CenterTIHP { get; set; }
        public int LeftTIHP { get; set; }
        public int RightTIHP { get; set; }
        public int LeftAIHP { get; set; }
        public int RightAIHP { get; set; }
        public int LeftLIHP { get; set; }
        public int RightRIHP { get; set; }

    }
}
