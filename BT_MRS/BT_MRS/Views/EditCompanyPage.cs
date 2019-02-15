using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using BT_MRS.Models;
using System.IO;
using SQLite;

namespace BT_MRS.Views
{
    public class EditCompanyPage : ContentPage
    {
        private ListView _listView;
        private Entry _idEntry;
        private Entry _nameEntry;
        private Entry _homePlanet;
        private Entry _foundationYear;
        private Entry _currentAffiliation;

        private Button _editButton;

        Company _company = new Company();

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "BT_DB.db3");

        public EditCompanyPage()
        {
            this.Title = "Manage Companies";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();

            //_listView.ItemsSource = db.Table<Company>().OrderBy(x => x.Name).ToList();


            var template = new DataTemplate(typeof(TextCell));

            template.SetBinding(TextCell.TextProperty, "Name");
            template.SetValue(TextCell.TextColorProperty, Color.Maroon);
            template.SetBinding(TextCell.DetailProperty, "CurrentAffiliation");

            _listView.ItemTemplate = template;
            _listView.ItemsSource = db.Table<Company>().OrderBy(x => x.Name).ToList();
            
            _listView.ItemSelected += _listView_ItemSelected;
            _listView.Refreshing += _listView_Refreshing;
            _listView.SeparatorColor = Color.White;
            _listView.IsPullToRefreshEnabled = true;

            stackLayout.Children.Add(_listView);

            _idEntry = new Entry();
            _idEntry.Placeholder = "ID";
            _idEntry.IsVisible = false;
            stackLayout.Children.Add(_idEntry);

            _nameEntry = new Entry();
            _nameEntry.Placeholder = "Name";
            _nameEntry.IsVisible = true;
            _nameEntry.Keyboard = Keyboard.Text;
            _nameEntry.TextColor = Color.White;
            stackLayout.Children.Add(_nameEntry);

            _foundationYear = new Entry();
            _foundationYear.Placeholder = "Foundation Year";
            _foundationYear.IsVisible = true;
            _foundationYear.Keyboard = Keyboard.Numeric;
            _foundationYear.TextColor = Color.White;
            stackLayout.Children.Add(_foundationYear);

            _homePlanet = new Entry();
            _homePlanet.Placeholder = "Home Planet";
            _homePlanet.IsVisible = true;
            _homePlanet.Keyboard = Keyboard.Text;
            _homePlanet.TextColor = Color.White;
            stackLayout.Children.Add(_homePlanet);

            _currentAffiliation = new Entry();
            _currentAffiliation.Placeholder = "Affiliation";
            _currentAffiliation.IsVisible = true;
            _currentAffiliation.Keyboard = Keyboard.Text;
            _currentAffiliation.TextColor = Color.White;
            stackLayout.Children.Add(_currentAffiliation);

            //_editButton = new Button();
            //_editButton.Text = "Add Company";
            //_editButton.Clicked += _addButton_Clicked;
            //stackLayout.Children.Add(_editButton);

            _editButton = new Button();
            _editButton.Text = "Update Company";
            _editButton.Clicked += _editButton_Clicked;

            stackLayout.Children.Add(_editButton);

            _editButton = new Button();
            _editButton.Text = "Delete Company";
            _editButton.Clicked += _button_Clicked; ;
            stackLayout.Children.Add(_editButton);
            stackLayout.BackgroundColor = Color.Gray;
            Content = stackLayout;

        }

        private void _listView_Refreshing(object sender, EventArgs e)
        {
            var template = new DataTemplate(typeof(TextCell));
            var db = new SQLiteConnection(_dbPath);
            template.SetBinding(TextCell.TextProperty, "Name");
            template.SetValue(TextCell.TextColorProperty, Color.Maroon);
            template.SetBinding(TextCell.DetailProperty, "CurrentAffiliation");
            _listView.ItemsSource = db.Table<Company>().OrderBy(x => x.Name).ToList();
            //await DisplayAlert(null, "Refrescado", "Ok");
            _listView.EndRefresh();
        }

        //private async void _addButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new AddCompanyPage());
        //}

        private async void _button_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            bool result = await DisplayAlert("Delete " + _company.Name, "Confirm Delete?", "Confirm", "Cancel");
            if (result)
            {
                db.Table<Company>().Delete(x => x.Id == _company.Id);

            }
            else
            {
                await DisplayAlert(null, "No changes to " + _company.Name, "Ok");
            }

            _listView.BeginRefresh();
//            await Navigation.PopAsync();
        }

        private void _editButton_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            Company company = new Company
            {
                Id = Convert.ToInt32(_idEntry.Text),
                Name = _nameEntry.Text,
                HomePlanet = _homePlanet.Text,
                CurrentAffiliation = _currentAffiliation.Text,
                FoundationYear = int.Parse(_foundationYear.Text)
            };
            db.Update(company);
            //await DisplayAlert(null, company.Name + " Updated", "Ok");
            //await Navigation.PopAsync();
        }

        private void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _company = (Company)e.SelectedItem;
            _idEntry.Text = _company.Id.ToString();
            _nameEntry.Text = _company.Name.ToString();
            _foundationYear.Text = _company.FoundationYear.ToString();
            _currentAffiliation.Text = _company.CurrentAffiliation.ToString();
            _homePlanet.Text = _company.HomePlanet.ToString();
        }

        protected override void OnDisappearing()
        {
            _editButton_Clicked(null,null);
            base.OnDisappearing();
        }

    }
}