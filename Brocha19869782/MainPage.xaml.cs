namespace Brocha19869782
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Validar que se ingresen valores numéricos válidos
            if (double.TryParse(MetrosEntry.Text, out double metros) &&
                double.TryParse(PrecioEntry.Text, out double precioPorMetro))
            {
                if (metros > 0 && precioPorMetro > 0)
                {
                    // Cálculo del total
                    double total = metros * precioPorMetro;

                    // Mostrar resultado formateado como moneda
                    ResultadoLabel.Text = $"Total a cobrar: ${total:F2}";
                }
                else
                {
                    DisplayAlert("Error", "Por favor ingrese valores mayores a cero.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese valores numéricos válidos en ambos campos.", "OK");
            }
        }
    }
}
