using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfBookRentalShop01.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private string _greeting;
        internal MainViewModel DataContext;

        public string Greeting
        {
            get => _greeting;
            set => SetProperty(ref _greeting, value);
        }


        public MainViewModel()
        {
            Greeting = "BookRentalShop!!";
        }

        internal void ShowDialog()
        {
           
        }
    }
}
