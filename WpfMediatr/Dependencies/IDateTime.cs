using System;
using System.Threading.Tasks;

namespace WpfMediatr.Dependencies
{
    public interface IDateTime
    {
        Task<DateTime> Get();
    }
}