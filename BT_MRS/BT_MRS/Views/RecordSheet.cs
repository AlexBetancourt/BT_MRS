using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BT_MRS.Views
{
    public class RecordSheet : ContentPage
    {
        Image _image = new Image();

        public RecordSheet()
        {
            AbsoluteLayout Layer1 = new AbsoluteLayout();
            Layer1.BackgroundColor = Color.Maroon;

            Label lbl = new Label();
            lbl.Text = "CMD-1B Commando";
            lbl.FontSize = 26;
            lbl.FontAttributes = FontAttributes.Bold;
            lbl.TextColor = Color.DarkGray;
            lbl.HorizontalTextAlignment = TextAlignment.Center;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0.5, 140, 1, 40));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.XProportional);
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer1.Children.Add(lbl);

            Entry txt = new Entry();
            txt.TextChanged += Txt_TextChanged;
            txt.Text = "Commando";
            txt.TextColor = Color.White;
            txt.BackgroundColor = Color.Maroon;
            AbsoluteLayout.SetLayoutBounds(txt, new Rectangle(0.5, 180, 1, 50));
            AbsoluteLayout.SetLayoutFlags(txt, AbsoluteLayoutFlags.XProportional);
            AbsoluteLayout.SetLayoutFlags(txt, AbsoluteLayoutFlags.WidthProportional);
            Layer1.Children.Add(txt);

            Image img = new Image();
            img = _image;
            AbsoluteLayout.SetLayoutBounds(img, new Rectangle(0.5, 0, 120, 120));
            AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.PositionProportional);
            Layer1.Children.Add(img);

            AbsoluteLayout Layer2 = new AbsoluteLayout();
            Layer2.BackgroundColor = Color.Black;
            AbsoluteLayout.SetLayoutBounds(Layer2, new Rectangle(0, 220, 1, 50));
            AbsoluteLayout.SetLayoutFlags(Layer2, AbsoluteLayoutFlags.WidthProportional);

            AbsoluteLayout Layer31 = new AbsoluteLayout();
            Layer31.BackgroundColor = Color.White;
            AbsoluteLayout.SetLayoutBounds(Layer31, new Rectangle(0.5, 0, 130, 50));
            AbsoluteLayout.SetLayoutFlags(Layer31, AbsoluteLayoutFlags.XProportional);
            AbsoluteLayout.SetLayoutFlags(Layer31, AbsoluteLayoutFlags.YProportional);

            Button btn = new Button();
            btn.BackgroundColor = Color.Green;
            btn.Pressed += Btn_Walk_Pressed;
            btn.CornerRadius = 20;
            AbsoluteLayout.SetLayoutBounds(btn, new Rectangle(5, 0.5, 40, 40));
            AbsoluteLayout.SetLayoutFlags(btn, AbsoluteLayoutFlags.YProportional);
            Layer31.Children.Add(btn);

            lbl = new Label();
            lbl.Text = "Walk 8";
            lbl.FontSize = 26;
            lbl.FontAttributes = FontAttributes.Bold;
            lbl.TextColor = Color.Black;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(50, 1, 1, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.YProportional);
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer31.Children.Add(lbl);
            Layer2.Children.Add(Layer31);

            AbsoluteLayout Layer32 = new AbsoluteLayout();
            Layer32.BackgroundColor = Color.White;
            AbsoluteLayout.SetLayoutBounds(Layer32, new Rectangle(0.5, 0, 130, 50));
            AbsoluteLayout.SetLayoutFlags(Layer32, AbsoluteLayoutFlags.PositionProportional);
            //AbsoluteLayout.SetLayoutFlags(Layer32, AbsoluteLayoutFlags.YProportional);

            btn = new Button();
            btn.BackgroundColor = Color.Red;
            btn.Pressed += Btn_Run_Pressed;
            btn.CornerRadius = 20;
            AbsoluteLayout.SetLayoutBounds(btn, new Rectangle(5, 0.5, 40, 40));
            AbsoluteLayout.SetLayoutFlags(btn, AbsoluteLayoutFlags.YProportional);
            Layer32.Children.Add(btn);

            lbl = new Label();
            lbl.Text = "Run 12";
            lbl.FontSize = 26;
            lbl.FontAttributes = FontAttributes.Bold;
            lbl.TextColor = Color.Black;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(50, 1, 1, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.YProportional);
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer32.Children.Add(lbl);
            Layer2.Children.Add(Layer32);

            AbsoluteLayout Layer33 = new AbsoluteLayout();
            Layer33.BackgroundColor = Color.White;
            AbsoluteLayout.SetLayoutBounds(Layer33, new Rectangle(1, 0, 130, 50));
            AbsoluteLayout.SetLayoutFlags(Layer33, AbsoluteLayoutFlags.PositionProportional);
            //AbsoluteLayout.SetLayoutFlags(Layer33, AbsoluteLayoutFlags.YProportional);

            btn = new Button();
            btn.BackgroundColor = Color.LightBlue;
            btn.Pressed += Btn_Jump_Pressed;
            btn.CornerRadius = 20;
            AbsoluteLayout.SetLayoutBounds(btn, new Rectangle(5, 0.5, 40, 40));
            AbsoluteLayout.SetLayoutFlags(btn, AbsoluteLayoutFlags.YProportional);
            Layer33.Children.Add(btn);

            lbl = new Label();
            lbl.Text = "Jump 8";
            lbl.FontSize = 26;
            lbl.FontAttributes = FontAttributes.Bold;
            lbl.TextColor = Color.Black;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(50, 1, 1, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.YProportional);
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer33.Children.Add(lbl);
            Layer2.Children.Add(Layer33);

            Layer1.Children.Add(Layer2);


            AbsoluteLayout Layer3 = new AbsoluteLayout();
            Layer3.BackgroundColor = Color.Transparent; ;
            AbsoluteLayout.SetLayoutBounds(Layer3, new Rectangle(0, 270, 1, 50));
            AbsoluteLayout.SetLayoutFlags(Layer3, AbsoluteLayoutFlags.WidthProportional);

            lbl = new Label();
            lbl.Text = "Tonnage:";
            lbl.TextColor = Color.White;
            lbl.FontSize = 26;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0, 25, 0.25, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer3.Children.Add(lbl);

            txt = new Entry();
            txt.Text = "50";
            txt.TextColor = Color.White;
            txt.BackgroundColor = Color.Maroon;
            txt.Keyboard = Keyboard.Numeric;
            AbsoluteLayout.SetLayoutBounds(txt, new Rectangle(130, 0, 0.75, 50));
            AbsoluteLayout.SetLayoutFlags(txt, AbsoluteLayoutFlags.WidthProportional);
            Layer3.Children.Add(txt);

            Layer1.Children.Add(Layer3);

            CompressedLayout.SetIsHeadless(Layer1, true);
            Content = new ScrollView { Content = Layer1 };
        }

        private async void Btn_Jump_Pressed(object sender, EventArgs e)
        {
            await DisplayAlert(null, "Mech Jumped: Add 3 Heat +1 for each Hex", "Ok");
        }

        private async void Btn_Run_Pressed(object sender, EventArgs e)
        {
            await DisplayAlert(null, "Mech Walked: +2 Heat", "Ok");
        }

        private async void Btn_Walk_Pressed(object sender, EventArgs e)
        {

            await DisplayAlert(null, "Mech Walked: +1 Heat", "Ok");
        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string mechname = "";
            mechname = e.NewTextValue.Replace(' ', '_');
            _image.Aspect = Aspect.AspectFit;
            _image.Source = mechname + ".jpg";
        }
    }
}