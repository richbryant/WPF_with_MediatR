using System.Threading.Tasks;
using MediatR;

namespace WpfMediatr.Commands
{
    public class GetHelloCommand : IRequest<Task<string>>
    {

        
    }
}