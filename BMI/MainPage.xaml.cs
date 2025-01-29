namespace BMI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void ZmianaWartosciWagi(object sender, ValueChangedEventArgs e)
        {
            WagaLabel.Text = $"{e.NewValue:F0} kg";
        }

        private void ZmianaWartosciWzrostu(object sender, ValueChangedEventArgs e)
        {
            WzrostLabel.Text = $"{e.NewValue:F0} cm";
        }
        private void ObliczBmi(object sender, EventArgs e)
        {
            try
            {
                double waga = WagaSlider.Value; 
                double wzrost = WzrostSlider.Value / 100;
                double bmi;

                if (wzrost > 0)
                {
                    bmi = (waga / (wzrost * wzrost));
                    double v = (Math.Round(bmi, 2));
                    switch (v)
                    {
                        case <=18.5:
                            WynikLabel.Text = $"Niedowaga. BMI = {v}";
                            BackgroundColor = Colors.LightBlue;
                            break;
                        case >= 18.5 and < 24.9:
                            WynikLabel.Text = $"Prawidłowa masa ciała. BMI = {v}";
                            BackgroundColor = Colors.LightGreen;
                            break;
                        case >= 25 and < 29.9:
                            WynikLabel.Text = $"Nadwaga. BMI = {v}";
                            BackgroundColor = Colors.Orange;
                            break;
                        case >= 30 and <39.9:
                            WynikLabel.Text = $"Otyłość 1 Stopnia. BMI = {v}";
                            BackgroundColor = Colors.Red;
                            break;
                        case >= 40:
                            WynikLabel.Text = $"Otyłość 2 Stopnia. BMI = {v}";
                            BackgroundColor = Colors.DarkRed;
                            break;
                    }

                }
                else
                {
                    WynikLabel.Text = "Proszę wprowadzić poprawne dane.";
                    BackgroundColor = Colors.White;
                }
            }
            catch
            {
                WynikLabel.Text = "Proszę wprowadzić poprawne dane.";
                BackgroundColor = Colors.White;
            }



        }
    }

}
