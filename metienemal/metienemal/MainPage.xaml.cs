namespace metienemal
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNewButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("New Button", "This button was added by a collaborator!", "OK");
        }

    }

}
