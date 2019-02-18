using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BT_MRS.Views
{
    public class MechLab : ContentPage
    {
        private ListView _listView;
        private Entry _idEntry;
        private Entry _nameEntry;
        private Entry _homePlanet;
        private Entry _foundationYear;
        private Entry _currentAffiliation;

        public MechLab()
        {

            this.Title = "Main Menu";
            var scroll = new ScrollView();
            Content = scroll;
            StackLayout stackLayout = new StackLayout();



        }
    }
}