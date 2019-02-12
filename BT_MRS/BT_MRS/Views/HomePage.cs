using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BT_MRS.Views
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
            this.Title = "Main Menu";
            StackLayout stackLayout = new StackLayout();

            Image img = new Image();
            img.Source = "Company.jpg";
            img.HeightRequest =120;
            img.WidthRequest = 600;
            stackLayout.Children.Add(img);


            Label lbl = new Label();
            lbl.Text = "Companies";
            lbl.FontSize = 40;
            lbl.HorizontalTextAlignment = TextAlignment.Center;
            lbl.TextColor = Color.White;
            stackLayout.Children.Add(lbl);

            Button button = new Button();
            button.Text = "Add Company";
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button);

            //button = new Button();
            //button.Text = "Get Companies";
            //button.Clicked += btn_Get_Companies_Clicked;
            //stackLayout.Children.Add(button);


            button = new Button();
            button.Text = "Manage Companies";
            button.Clicked += btn_Edit_Companies_Clicked;
            stackLayout.Children.Add(button);
            stackLayout.BackgroundColor = Color.Gray;
            //button = new Button();
            //button.Text = "Delete Companies";
            //button.Clicked += btn_Delete_Companies_Clicked;
            //stackLayout.Children.Add(button);

            BoxView box = new BoxView();
            box.Color = Color.Black;
            box.WidthRequest = 100;
            box.HeightRequest = 2;
            stackLayout.Children.Add(box);

            img = new Image();
            img.Source = "Lance.jpg";
            img.HeightRequest = 120;
            img.WidthRequest = 600;
            stackLayout.Children.Add(img);


            lbl = new Label();
            lbl.Text = "Lances";
            lbl.FontSize = 40;
            lbl.HorizontalTextAlignment = TextAlignment.Center;
            lbl.TextColor = Color.White;
            stackLayout.Children.Add(lbl);

            button = new Button();
            button.Text = "Add Lance";
            button.Clicked += btn_Add_Lance_Clicked;
            stackLayout.Children.Add(button);
            stackLayout.BackgroundColor = Color.Gray;

            button = new Button();
            button.Text = "Manage Lance";
            button.Clicked += btn_Edit_Lance_Clicked;
            stackLayout.Children.Add(button);
            stackLayout.BackgroundColor = Color.Gray;

            Content = stackLayout;

        }

        private async void btn_Edit_Lance_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LancesPage());
        }

        private async void btn_Add_Lance_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LancesPage());
        }

        //private async void btn_Delete_Companies_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Views.DeleteCompanyPage());
        //}

        private async void btn_Edit_Companies_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.EditCompanyPage());
        }

        //private async void btn_Get_Companies_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Views.GetAllCompaniesPage());
        //}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.AddCompanyPage());
        }
    }
}