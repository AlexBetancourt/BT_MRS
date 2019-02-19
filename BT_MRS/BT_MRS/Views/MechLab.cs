using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;

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
        private string[] AllLines;

        public MechLab()
        {

            this.Title = "Main Menu";
            var scroll = new ScrollView();
            Content = scroll;
            StackLayout stackLayout = new StackLayout();

            Button button = new Button();
            button.Clicked += Button_Clicked;
            button.Text = "Read MTF";
            stackLayout.Children.Add(button);
            CompressedLayout.SetIsHeadless(stackLayout, true);
            Content = new ScrollView { Content = stackLayout };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            //AllLines = new string[50000]; //only allocate memory here

            //string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Atlas1.mtf");

            //var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MechLab)).Assembly;
            //foreach(var res in assembly.GetManifestResourceNames())
            //{
            //    System.Diagnostics.Debug.WriteLine("found resource: " + res);
            //}


            //using (StreamReader sr = File.OpenText(fileName))
            //{
            //    int x = 0;
            //    while (!sr.EndOfStream)
            //    {
            //        AllLines[x] = sr.ReadLine();
            //        x += 1;
            //    }
            //} //CLOSE THE FILE because we are now DONE with it.
            //DataTable dataTable = new DataTable("MTF");
            //Parallel.For(0, AllLines.Length, x =>
            //            {
            //                dataTable.Rows.Add(x);
            //            });
        }
    }
}