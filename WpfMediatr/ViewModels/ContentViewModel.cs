using Prism.Commands;
using Prism.Mvvm;
using System;
using MediatR;
using WpfMediatr.Commands;
using WpfMediatr.Dependencies;

namespace WpfMediatr.ViewModels
{
    public class ContentViewModel : BindableBase
    {
        private DateTime _date;
        private string _helloString;
        private Person _bloke = new Person();
        private readonly IMediator _mediator;

        public ContentViewModel(IMediator mediator)
        {
            _mediator = mediator;
            GetHello = new DelegateCommand(Hello);
            GetToday = new DelegateCommand(GetDate);
            GetBloke = new DelegateCommand(Bloke);
        }

        public DelegateCommand GetHello {get;set;}
        public DelegateCommand GetToday {get;set;}
        public DelegateCommand GetBloke {get;set;}

        private async void Hello()
        {
            _helloString = await await _mediator.Send(new GetHelloCommand());
            RaisePropertyChanged(nameof(HelloString));
        }

        private async void GetDate()
        {
            _date = await await _mediator.Send(new GetDateCommand());
            RaisePropertyChanged(nameof(Date));
        }

        private async void Bloke()
        {
            _bloke = await await _mediator.Send(new GetBlokeCommand());
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
