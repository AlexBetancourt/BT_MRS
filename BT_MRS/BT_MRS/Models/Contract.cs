using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BT_MRS.Models
{
    class Contract
    {
        [PrimaryKey]
        int Id { get; set; }
        string Name { get; set; }
        string Employer { get; set; }
        string EmployerAffiliation { get; set; }
        int Lenght { get; set; }
        int BasePayment { get; set; }
        int Bonus { get; set; }
        int CompanyID { get; set; }
        bool Completed { get; set; }

    }
}
