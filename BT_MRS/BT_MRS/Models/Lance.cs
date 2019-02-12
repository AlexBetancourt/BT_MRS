using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT_MRS.Models
{
    public class Lance
    {
        public int companyID { get; set; }
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
