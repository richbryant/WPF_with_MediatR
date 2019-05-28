using System.Threading.Tasks;
using MediatR;
using WpfMediatr.Dependencies;

namespace WpfMediatr.Commands
{
    public class GetBlokeCommand : IRequest<Task<Person>>
    {
        
    }
}