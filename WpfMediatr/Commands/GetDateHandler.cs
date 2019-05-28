using System;
using System.Threading.Tasks;
using MediatR;
using WpfMediatr.Dependencies;

namespace WpfMediatr.Commands
{
    public class GetDateHandler : RequestHandler<GetDateCommand, Task<DateTime>>
    {
        private readonly IDateTime _date;

        public GetDateHandler(IDateTime date)
        {
            _date = date;
        }

        protected override async Task<DateTime> Handle(GetDateCommand request)
        {
            return await _date.Get();
        }
    }
}