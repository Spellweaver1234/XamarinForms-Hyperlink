using System.ComponentModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace HyperlinkXF
{
    internal class MainPageVM : INotifyPropertyChanged
    {
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });

        public MainPageVM()
        {


        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}