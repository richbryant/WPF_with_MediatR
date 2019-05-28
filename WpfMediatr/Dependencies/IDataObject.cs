using System.Threading.Tasks;

namespace WpfMediatr.Dependencies
{
    public interface IDataObject
    {
        Task<Person> Get();
    }
}