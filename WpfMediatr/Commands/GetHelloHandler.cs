using System.Threading.Tasks;
using MediatR;
using WpfMediatr.Dependencies;

namespace WpfMediatr.Commands
{
    public class GetHelloHandler : RequestHandler<GetHelloCommand, Task<string>>
    {
        private readonly IString _hello;

        public GetHelloHandler(IString hello)
        {
            _hello = hello;
        }

        protected override async Task<string> Handle(GetHelloCommand request)
        {
            return await _hello.Get();
        }

    }
}
