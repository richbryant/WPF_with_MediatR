using Prism.Mvvm;

namespace WpfMediatr.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Mediatr with WPF";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
