using System.Threading.Tasks;

namespace WpfMediatr.Dependencies
{
    public interface IString
    {
        Task<string> Get();
    }
}