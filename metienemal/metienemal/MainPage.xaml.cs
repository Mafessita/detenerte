namespace metienemal
{
    public partial class MainPage : ContentPage
    {
<<<<<<< HEAD

=======
<<<<<<< Updated upstream
        
=======
  
>>>>>>> Stashed changes
>>>>>>> 068d7bda86985f9925b654dbe648f0a3cbe003f4

        public MainPage()
        {
            InitializeComponent();
        }


        private void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Button Pressed", "You pressed the button!", "OK");
         }
        private void OnNewButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("New Button", "This button was added by a collaborator!", "OK");
        }
        private async void OnOpenWebsiteButtonClicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://example.com");
            await Launcher.Default.OpenAsync(uri);
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pagina1());
        }
        private void OnChangeColorButtonClicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Colors.LightBlue;
        }
    }
