using TestAIMauiApp.ViewModels;

namespace TestAIMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;

        }
    }

}
