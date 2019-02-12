using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

using Xamarin.Forms;
using BT_MRS.Models;
using SQLite;

namespace BT_MRS.Views
{
    public class AddCompanyPage : ContentPage
    {


        private Entry _NameEntry;
        private Entry _HomePlanetEntry;
        private Entry _FoundationYearEntry;
        private Entry _CurrentAffiliationEntry;
        private Button _saveButton;

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "BT_DB.db3");

        public AddCompanyPage()
        {
            this.Title = "Add Company";
            StackLayout stackLayout = new StackLayout();

            _NameEntry = new Entry();
            _NameEntry.Keyboard = Keyboard.Text;
            _NameEntry.Placeholder = "Company Name";
            _NameEntry.TextColor = Color.White;
            stackLayout.Children.Add(_NameEntry);

            _HomePlanetEntry = new Entry();
            _HomePlanetEntry.Keyboard = Keyboard.Text;
            _HomePlanetEntry.Placeholder = "Home Planet";
            _HomePlanetEntry.TextColor = Color.White;
            stackLayout.Children.Add(_HomePlanetEntry);

            _FoundationYearEntry = new Entry();
            _FoundationYearEntry.Keyboard = Keyboard.Numeric;
            _FoundationYearEntry.Placeholder = "Year";
            _FoundationYearEntry.TextColor = Color.White;
            stackLayout.Children.Add(_FoundationYearEntry);

            _CurrentAffiliationEntry = new Entry();
            _CurrentAffiliationEntry.Keyboard = Keyboard.Text;
            _CurrentAffiliationEntry.Placeholder = "Company's Currrent Affiliation";
            _CurrentAffiliationEntry.TextColor = Color.White;
            stackLayout.Children.Add(_CurrentAffiliationEntry);

            _saveButton = new Button();
            _saveButton.Text = "Add";
            _saveButton.Clicked += _saveButton_Clicked;
           
            stackLayout.Children.Add(_saveButton);
            stackLayout.BackgroundColor = Color.Gray;
            Content = stackLayout;
        }
        private async void _saveButton_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<Company>();
            var maxPK = db.Table<Company>().OrderByDescending(c => c.Id).FirstOrDefault();

            Company company = new Company()
            {
                Id = (maxPK == null ? 1 : maxPK.Id + 1),
                Name = _NameEntry.Text,
                HomePlanet = _HomePlanetEntry.Text,
                FoundationYear = int.Parse(_FoundationYearEntry.Text),
                CurrentAffiliation = _CurrentAffiliationEntry.Text
            };

            db.Insert(company);
            await DisplayAlert(null, company.Name + " Saved", "Ok");
            await Navigation.PopAsync();

        }
    }
}