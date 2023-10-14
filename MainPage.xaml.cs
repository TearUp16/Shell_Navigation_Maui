namespace Promee_FrontMenu
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnClickedSignIn(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomepageKuno");
        }

    }
}