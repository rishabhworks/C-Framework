using finalExamRishabh.UI;

namespace finalExamRishabh
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnProvincePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProvincesPage());
        }
    }

}
