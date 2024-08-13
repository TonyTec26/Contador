namespace MauiApp1
{
    public partial class MainPage : ContentPage {
        int contador = 0;

        public MainPage() {
            InitializeComponent();
        }

        private void botaonegativo(object sender, EventArgs e) {
            contador--;
            ContadorLabel.Text = contador.ToString();

        }

        private void botaopositivo(object sender, EventArgs e) {
            contador++;
            ContadorLabel.Text = contador.ToString();
        }
    }

}
