namespace metienemal
{
    public partial class MainPage : ContentPage
    {
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
            await Navigation.PushAsync(new Pagina1());
        }
        private void OnChangeColorButtonClicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Colors.LightBlue;
        }
    }
}