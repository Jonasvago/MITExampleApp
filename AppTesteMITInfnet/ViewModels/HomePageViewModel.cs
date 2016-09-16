using Prism.Mvvm;
using PropertyChanged;
using System;
using Xamarin.Forms;

namespace AppTesteMITInfnet
{
    [ImplementPropertyChanged]
    public class HomePageViewModel : BindableBase
    {
        public string Title { get; set; }
        public DateTime Date { get; } = DateTime.Now;

        public Command OlaCommand
        {
            get
            {
                return new Command<string>((string obj) => Navigate(obj));
            }
        }

        async void Navigate(string value) 
        {
            var x = value;
        }

        public HomePageViewModel(string A, string B)
        {
        }
    }
}
