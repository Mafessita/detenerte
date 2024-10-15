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
    }

}
