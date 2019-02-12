using BT_MRS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BT_MRS.Views
{
	public class AddLancePage : ContentPage
	{
        Company _company = new Company();
        private Label _companyName;
        private Label _companyID;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "BT_DB.db3");

        public AddLancePage (int _companyID, string _companyName)
		{
            this.Title =_companyName;
        }
        public AddLancePage()
        {

        }
    }
}