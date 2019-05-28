using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using WpfMediatr.Dependencies;

namespace WpfMediatr.ViewModels
{
    public class ContentViewModel : BindableBase
    {
        private DateTime _date;
        private string _helloString;
        private readonly IString _hello;
        private readonly IDateTime _today;
        private readonly IDataObject _data;
        private Person _bloke = new Person();

        public ContentViewModel(IString hello, IDateTime today, IDataObject dataObject)
        {
            _hello = hello;
            _today = today;
            _data = dataObject;
            GetHello = new DelegateCommand(Hello);
            GetToday = new DelegateCommand(GetDate);
            GetBloke = new DelegateCommand(Bloke);
        }

        public DelegateCommand GetHello {get;set;}
        public DelegateCommand GetToday {get;set;}
        public DelegateCommand GetBloke {get;set;}

        private async void Hello()
        {
            _helloString = await  _hello.Get();
            RaisePropertyChanged(nameof(HelloString));
        }

        private async void GetDate()
        {
            _date = await _today.GetDate();
            RaisePropertyChanged(nameof(Date));
        }

        private async void Bloke()
        {
            _bloke = await _data.Get();
            RaisePropertyChanged(nameof(FirstName));
            RaisePropertyChanged(nameof(LastName));
        }



        public string HelloString
        {
            get => _helloString;
            set => SetProperty(ref _helloString, value);
        }

        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public string FirstName
        {
            get => _bloke.FirstName;
            set
            {
                _bloke.FirstName = value;
                RaisePropertyChanged();
            }

        }

        public string LastName
        {
            get => _bloke.LastName;
            set
            {
                _bloke.LastName = value;
                RaisePropertyChanged();
            }
        }
    }
}
