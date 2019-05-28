using System;
using System.Threading.Tasks;
using MediatR;

namespace WpfMediatr.Commands
{
    public class GetDateCommand : IRequest<Task<DateTime>>
    {
        
    }
}