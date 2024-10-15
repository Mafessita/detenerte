namespace metienemal
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOpenWebsiteButtonClicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://example.com");
            await Launcher.Default.OpenAsync(uri);
        }

    }

}
