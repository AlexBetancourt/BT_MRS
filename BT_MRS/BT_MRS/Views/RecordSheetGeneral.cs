using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace BT_MRS.Views
{
    public class RecordSheetGeneral : ContentPage
    {
        private Label _mechModel = new Label();
        private Label _walkLabel = new Label();
        private Label _runLabel = new Label();
        private Label _jumpLabel = new Label();
        private Entry _mechName = new Entry();
        private Image _mechImage = new Image();
        private Button _walkButton = new Button();
        private Button _runButton = new Button();
        private Button _jumpButton = new Button();
        private Entry _tonnageEntry = new Entry();
        private Entry _pilotEntry = new Entry();
        private Entry _heatSinksEntry = new Entry();
        private Stepper _heatSinksStepper = new Stepper();
        private Entry _pilotingSkill = new Entry();
        private Entry _gunnerySkill = new Entry();
        private Entry _pilotName = new Entry();
        private Entry _hitsEntry = new Entry();
        private Stepper _hitsStepper = new Stepper();
        private Entry _consciousnessEntry = new Entry();

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "BT_DB.db3");

        public RecordSheetGeneral()
        {
            AbsoluteLayout Layer1 = new AbsoluteLayout();
            Layer1.BackgroundColor = Color.Maroon;

            _mechModel = new Label();
            _mechModel.Text = "CMD-1B Commando";
            _mechModel.FontSize = 26;
            _mechModel.FontAttributes = FontAttributes.Bold;
            _mechModel.TextColor = Color.DarkGray;
            _mechModel.HorizontalTextAlignment = TextAlignment.Center;
            AbsoluteLayout.SetLayoutBounds(_mechModel, new Rectangle(0.5, 140, 1, 40));
            AbsoluteLayout.SetLayoutFlags(_mechModel, AbsoluteLayoutFlags.XProportional);
            AbsoluteLayout.SetLayoutFlags(_mechModel, AbsoluteLayoutFlags.WidthProportional);
            Layer1.Children.Add(_mechModel);

            _mechName = new Entry();
            _mechName.TextChanged += Txt_TextChanged;
            _mechName.Text = "Commando";
            _mechName.TextColor = Color.White;
            _mechName.BackgroundColor = Color.Maroon;
            AbsoluteLayout.SetLayoutBounds(_mechName, new Rectangle(0.5, 180, 1, 50));
            AbsoluteLayout.SetLayoutFlags(_mechName, AbsoluteLayoutFlags.XProportional);
            AbsoluteLayout.SetLayoutFlags(_mechName, AbsoluteLayoutFlags.WidthProportional);
            Layer1.Children.Add(_mechName);

            _mechImage = new Image();
            AbsoluteLayout.SetLayoutBounds(_mechImage, new Rectangle(0.5, 0, 120, 120));
            AbsoluteLayout.SetLayoutFlags(_mechImage, AbsoluteLayoutFlags.PositionProportional);
            Layer1.Children.Add(_mechImage);

            AbsoluteLayout Layer2 = new AbsoluteLayout();
            Layer2.BackgroundColor = Color.Black;
            AbsoluteLayout.SetLayoutBounds(Layer2, new Rectangle(0, 220, 1, 50));
            AbsoluteLayout.SetLayoutFlags(Layer2, AbsoluteLayoutFlags.WidthProportional);

            AbsoluteLayout Layer31 = new AbsoluteLayout();
            Layer31.BackgroundColor = Color.White;
            AbsoluteLayout.SetLayoutBounds(Layer31, new Rectangle(0.5, 0, 130, 50));
            AbsoluteLayout.SetLayoutFlags(Layer31, AbsoluteLayoutFlags.XProportional);
            AbsoluteLayout.SetLayoutFlags(Layer31, AbsoluteLayoutFlags.YProportional);

            _walkButton = new Button();
            _walkButton.BackgroundColor = Color.Green;
            _walkButton.Pressed += Btn_Walk_Pressed;
            _walkButton.CornerRadius = 20;
            AbsoluteLayout.SetLayoutBounds(_walkButton, new Rectangle(5, 0.5, 40, 40));
            AbsoluteLayout.SetLayoutFlags(_walkButton, AbsoluteLayoutFlags.YProportional);
            Layer31.Children.Add(_walkButton);

            _walkLabel = new Label();
            _walkLabel.Text = "Walk 8";
            _walkLabel.FontSize = 26;
            _walkLabel.FontAttributes = FontAttributes.Bold;
            _walkLabel.TextColor = Color.Black;
            AbsoluteLayout.SetLayoutBounds(_walkLabel, new Rectangle(50, 1, 1, 50));
            AbsoluteLayout.SetLayoutFlags(_walkLabel, AbsoluteLayoutFlags.YProportional);
            AbsoluteLayout.SetLayoutFlags(_walkLabel, AbsoluteLayoutFlags.WidthProportional);
            Layer31.Children.Add(_walkLabel);
            Layer2.Children.Add(Layer31);

            AbsoluteLayout Layer32 = new AbsoluteLayout();
            Layer32.BackgroundColor = Color.White;
            AbsoluteLayout.SetLayoutBounds(Layer32, new Rectangle(0.5, 0, 130, 50));
            AbsoluteLayout.SetLayoutFlags(Layer32, AbsoluteLayoutFlags.PositionProportional);
            //AbsoluteLayout.SetLayoutFlags(Layer32, AbsoluteLayoutFlags.YProportional);

            _runButton = new Button();
            _runButton.BackgroundColor = Color.Red;
            _runButton.Pressed += Btn_Run_Pressed;
            _runButton.CornerRadius = 20;
            AbsoluteLayout.SetLayoutBounds(_runButton, new Rectangle(5, 0.5, 40, 40));
            AbsoluteLayout.SetLayoutFlags(_runButton, AbsoluteLayoutFlags.YProportional);
            Layer32.Children.Add(_runButton);

            _runLabel = new Label();
            _runLabel.Text = "Run 12";
            _runLabel.FontSize = 26;
            _runLabel.FontAttributes = FontAttributes.Bold;
            _runLabel.TextColor = Color.Black;
            AbsoluteLayout.SetLayoutBounds(_runLabel, new Rectangle(50, 1, 1, 50));
            AbsoluteLayout.SetLayoutFlags(_runLabel, AbsoluteLayoutFlags.YProportional);
            AbsoluteLayout.SetLayoutFlags(_runLabel, AbsoluteLayoutFlags.WidthProportional);
            Layer32.Children.Add(_runLabel);
            Layer2.Children.Add(Layer32);

            AbsoluteLayout Layer33 = new AbsoluteLayout();
            Layer33.BackgroundColor = Color.White;
            AbsoluteLayout.SetLayoutBounds(Layer33, new Rectangle(1, 0, 130, 50));
            AbsoluteLayout.SetLayoutFlags(Layer33, AbsoluteLayoutFlags.PositionProportional);
            //AbsoluteLayout.SetLayoutFlags(Layer33, AbsoluteLayoutFlags.YProportional);

            _jumpButton = new Button();
            _jumpButton.BackgroundColor = Color.LightBlue;
            _jumpButton.Pressed += Btn_Jump_Pressed;
            _jumpButton.CornerRadius = 20;
            AbsoluteLayout.SetLayoutBounds(_jumpButton, new Rectangle(5, 0.5, 40, 40));
            AbsoluteLayout.SetLayoutFlags(_jumpButton, AbsoluteLayoutFlags.YProportional);
            Layer33.Children.Add(_jumpButton);

            _jumpLabel = new Label();
            _jumpLabel.Text = "Jump 8";
            _jumpLabel.FontSize = 26;
            _jumpLabel.FontAttributes = FontAttributes.Bold;
            _jumpLabel.TextColor = Color.Black;
            AbsoluteLayout.SetLayoutBounds(_jumpLabel, new Rectangle(50, 1, 1, 50));
            AbsoluteLayout.SetLayoutFlags(_jumpLabel, AbsoluteLayoutFlags.YProportional);
            AbsoluteLayout.SetLayoutFlags(_jumpLabel, AbsoluteLayoutFlags.WidthProportional);
            Layer33.Children.Add(_jumpLabel);
            Layer2.Children.Add(Layer33);

            Layer1.Children.Add(Layer2);


            AbsoluteLayout Layer3 = new AbsoluteLayout();
            Layer3.BackgroundColor = Color.Transparent; ;
            AbsoluteLayout.SetLayoutBounds(Layer3, new Rectangle(0, 270, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
           // AbsoluteLayout.SetLayoutFlags(Layer3, AbsoluteLayoutFlags.WidthProportional);

            Label lbl = new Label();
            lbl.Text = "Tonnage:";
            lbl.TextColor = Color.White;
            lbl.FontSize = 15;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0, 25, 0.25, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer3.Children.Add(lbl);

            _tonnageEntry = new Entry();
            _tonnageEntry.Text = "50";
            _tonnageEntry.TextColor = Color.White;
            _tonnageEntry.BackgroundColor = Color.Maroon;
            _tonnageEntry.Keyboard = Keyboard.Numeric;
            AbsoluteLayout.SetLayoutBounds(_tonnageEntry, new Rectangle(130, 0, 0.75, 50));
            AbsoluteLayout.SetLayoutFlags(_tonnageEntry, AbsoluteLayoutFlags.WidthProportional);
            Layer3.Children.Add(_tonnageEntry);

            Layer1.Children.Add(Layer3);

            AbsoluteLayout Layer4 = new AbsoluteLayout();
            Layer4.BackgroundColor = Color.Transparent;
            AbsoluteLayout.SetLayoutBounds(Layer4, new Rectangle(0, 330, 1, 50));
            AbsoluteLayout.SetLayoutFlags(Layer4, AbsoluteLayoutFlags.WidthProportional);

            lbl = new Label();
            lbl.Text = "Heat Sinks ";
            lbl.TextColor = Color.White;
            lbl.FontSize = 15;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0, 25, 1, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer4.Children.Add(lbl);

            _heatSinksEntry = new Entry();
            _heatSinksEntry.TextColor = Color.White;
            _heatSinksEntry.BackgroundColor = Color.Maroon;
            _heatSinksEntry.Keyboard = Keyboard.Numeric;
            AbsoluteLayout.SetLayoutBounds(_heatSinksEntry, new Rectangle(75, 0, 0.25, 50));
            AbsoluteLayout.SetLayoutFlags(_heatSinksEntry, AbsoluteLayoutFlags.WidthProportional);
            Layer4.Children.Add(_heatSinksEntry);

            _heatSinksStepper = new Stepper();
            _heatSinksStepper.Minimum = 0;
            _heatSinksStepper.Maximum = 13;
            _heatSinksStepper.Increment = 1;
            _heatSinksStepper.ValueChanged += _heatSinksStepper_ValueChanged;
            AbsoluteLayout.SetLayoutBounds(_heatSinksStepper, new Rectangle(200, 0, 0.75, 50));
            AbsoluteLayout.SetLayoutFlags(_heatSinksStepper, AbsoluteLayoutFlags.WidthProportional);
            Layer4.Children.Add(_heatSinksStepper);
            Layer1.Children.Add(Layer4);

            AbsoluteLayout Layer5 = new AbsoluteLayout();
            Layer5.BackgroundColor = Color.Transparent; ;
            AbsoluteLayout.SetLayoutBounds(Layer5, new Rectangle(0, 380, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            //AbsoluteLayout.SetLayoutFlags(Layer5, AbsoluteLayoutFlags.WidthProportional);

            lbl = new Label();
            lbl.Text = "Pilot:";
            lbl.TextColor = Color.White;
            lbl.FontSize = 15;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0, 25, 0.25, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer5.Children.Add(lbl);

            _pilotEntry = new Entry();
            _pilotEntry.Text = "50";
            _pilotEntry.TextColor = Color.White;
            _pilotEntry.BackgroundColor = Color.Maroon;
            _pilotEntry.Keyboard = Keyboard.Numeric;
            AbsoluteLayout.SetLayoutBounds(_pilotEntry, new Rectangle(130, 0, 0.75, 50));
            AbsoluteLayout.SetLayoutFlags(_pilotEntry, AbsoluteLayoutFlags.WidthProportional);
            Layer5.Children.Add(_pilotEntry);

            Layer1.Children.Add(Layer5);
            

            AbsoluteLayout Layer7 = new AbsoluteLayout();
            Layer7.BackgroundColor = Color.Transparent; ;
            AbsoluteLayout.SetLayoutBounds(Layer7, new Rectangle(0, 430, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            //AbsoluteLayout.SetLayoutFlags(Layer7, AbsoluteLayoutFlags.WidthProportional);

            lbl = new Label();
            lbl.Text = "Piloting Skill:";
            lbl.TextColor = Color.White;
            lbl.FontSize = 15;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0, 25, 0.25, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer7.Children.Add(lbl);

            _pilotingSkill = new Entry();
            _pilotingSkill.Text = "4";
            _pilotingSkill.TextColor = Color.White;
            _pilotingSkill.BackgroundColor = Color.Maroon;
            _pilotingSkill.Keyboard = Keyboard.Numeric;
            AbsoluteLayout.SetLayoutBounds(_pilotingSkill, new Rectangle(130, 0, 0.75, 50));
            AbsoluteLayout.SetLayoutFlags(_pilotingSkill, AbsoluteLayoutFlags.WidthProportional);
            Layer7.Children.Add(_pilotingSkill);

            Layer1.Children.Add(Layer7);

            AbsoluteLayout Layer8 = new AbsoluteLayout();
            Layer8.BackgroundColor = Color.Transparent; ;
            AbsoluteLayout.SetLayoutBounds(Layer8, new Rectangle(0, 480, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            //AbsoluteLayout.SetLayoutFlags(Layer8, AbsoluteLayoutFlags.WidthProportional);

            lbl = new Label();
            lbl.Text = "Gunnery Skill:";
            lbl.TextColor = Color.White;
            lbl.FontSize = 15;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0, 25, 0.25, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer8.Children.Add(lbl);

            _gunnerySkill = new Entry();
            _gunnerySkill.Text = "4";
            _gunnerySkill.TextColor = Color.White;
            _gunnerySkill.BackgroundColor = Color.Maroon;
            _gunnerySkill.Keyboard = Keyboard.Numeric;
            AbsoluteLayout.SetLayoutBounds(_gunnerySkill, new Rectangle(130, 0, 0.75, 50));
            AbsoluteLayout.SetLayoutFlags(_gunnerySkill, AbsoluteLayoutFlags.WidthProportional);
            Layer8.Children.Add(_gunnerySkill);

            Layer1.Children.Add(Layer8);



            AbsoluteLayout Layer9 = new AbsoluteLayout();
            Layer9.BackgroundColor = Color.Transparent;
            AbsoluteLayout.SetLayoutBounds(Layer9, new Rectangle(0, 530, 1, 50));
            AbsoluteLayout.SetLayoutFlags(Layer9, AbsoluteLayoutFlags.WidthProportional);

            lbl = new Label();
            lbl.Text = "Hits: ";
            lbl.TextColor = Color.White;
            lbl.FontSize = 15;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0, 25, 1, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer9.Children.Add(lbl);

            _hitsEntry = new Entry();
            _hitsEntry.TextColor = Color.White;
            _hitsEntry.BackgroundColor = Color.Maroon;
            _hitsEntry.Keyboard = Keyboard.Numeric;
            AbsoluteLayout.SetLayoutBounds(_hitsEntry, new Rectangle(75, 0, 0.25, 50));
            AbsoluteLayout.SetLayoutFlags(_hitsEntry, AbsoluteLayoutFlags.WidthProportional);
            Layer9.Children.Add(_hitsEntry);

            _hitsStepper = new Stepper();
            _hitsStepper.Minimum = 0;
            _hitsStepper.Maximum = 6;
            _hitsStepper.Increment = 1;
            _hitsStepper.ValueChanged += _hitsStepper_ValueChanged;
            AbsoluteLayout.SetLayoutBounds(_hitsStepper, new Rectangle(200, 0, 0.75, 50));
            AbsoluteLayout.SetLayoutFlags(_hitsStepper, AbsoluteLayoutFlags.WidthProportional);
            Layer9.Children.Add(_hitsStepper);
            Layer1.Children.Add(Layer9);



            AbsoluteLayout Layer10 = new AbsoluteLayout();
            Layer10.BackgroundColor = Color.Transparent; ;
            AbsoluteLayout.SetLayoutBounds(Layer10, new Rectangle(0, 580, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));


//            AbsoluteLayout.SetLayoutFlags(Layer10, AbsoluteLayoutFlags.WidthProportional);

            lbl = new Label();
            lbl.Text = "Consciousness:";
            lbl.TextColor = Color.White;
            lbl.FontSize = 15;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0, 25, 0.25, 50));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.WidthProportional);
            Layer10.Children.Add(lbl);

            _consciousnessEntry = new Entry();
            _consciousnessEntry.Text = "0";
            _consciousnessEntry.TextColor = Color.White;
            _consciousnessEntry.BackgroundColor = Color.Maroon;
            _consciousnessEntry.Keyboard = Keyboard.Numeric;
            AbsoluteLayout.SetLayoutBounds(_consciousnessEntry, new Rectangle(130, 0, 0.75, 50));
            AbsoluteLayout.SetLayoutFlags(_consciousnessEntry, AbsoluteLayoutFlags.WidthProportional);
            Layer10.Children.Add(_consciousnessEntry);

            Layer1.Children.Add(Layer10);



            //TODO: Agregar seccion para Weapons
            //  Lista para mostrar las armas equipadas
            //  Agregar logica para disparar armas con sonido
            //  Agregar logica para almacenar el Heat generado

            //TODO: Agregar seccion para Heat
            //  Agregar contador para Heat
            //  Agregar logica para calcular Heat restante al restar los HeatSinks
            //  Agregar progress bar para mostrar Heat Actual

            //TODO: Agregar seccion para mostrar modificadores
            //  Agregar Lista para mostrar los modificadores activos despues de calculo de Heat
            //  Agregar logica para obtener modificadores causados por daño recibido









            CompressedLayout.SetIsHeadless(Layer1, true);
            Content = new ScrollView { Content = Layer1 };
        }
        protected override void OnDisappearing()
        {
            //TODO: Agregar codigo para actualizar base de datos con datos en pantalla
            //DisplayAlert("desapareciendo", "desapareciendo pantalla " + _mechModel.Text, "ok");
            base.OnDisappearing();
        }
        private void _hitsStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _hitsEntry.Text = _hitsStepper.Value.ToString();
            switch (int.Parse(_hitsEntry.Text))
            {
                case 1:
                    _consciousnessEntry.Text = "3";
                    break;
                case 2:
                    _consciousnessEntry.Text = "5";
                    break;
                case 3:
                    _consciousnessEntry.Text = "7";
                    break;
                case 4:
                    _consciousnessEntry.Text = "10";
                    break;
                case 5:
                    _consciousnessEntry.Text = "11";
                    break;
                case 6:
                    _consciousnessEntry.Text = "Dead";
                    break;
                default:
                    _consciousnessEntry.Text = "0";
                    break;
            }

        }

        private void _heatSinksStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _heatSinksEntry.Text = e.NewValue.ToString();
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
            _mechImage.Aspect = Aspect.AspectFit;
            _mechImage.Source = mechname + ".jpg";
        }
    }
}