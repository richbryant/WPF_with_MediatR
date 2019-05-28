using System.Threading.Tasks;
using MediatR;
using WpfMediatr.Dependencies;

namespace WpfMediatr.Commands
{
    public class GetBlokeHandler : RequestHandler<GetBlokeCommand, Task<Person>>
    {
        private readonly IDataObject _data;

        public GetBlokeHandler(IDataObject data)
        {
            _data = data;
        }

        protected override async Task<Person> Handle(GetBlokeCommand request)
        {
            return await _data.Get();
        }
    }
}