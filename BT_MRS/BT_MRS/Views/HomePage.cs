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
            Label lbl = new Label();
            lbl.Text = "Companies";
            lbl.FontSize = 20;
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

            lbl = new Label();
            lbl.Text = "Lances";
            lbl.FontSize = 20;
            lbl.HorizontalTextAlignment = TextAlignment.Center;
            lbl.TextColor = Color.White;
            stackLayout.Children.Add(lbl);

            button = new Button();
            button.Text = "Add Lance";
            button.Clicked += btn_Add_Lance_Clicked;
            stackLayout.Children.Add(button);
            stackLayout.BackgroundColor = Color.Gray;

            Content = stackLayout;

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