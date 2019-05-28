using System.Threading.Tasks;

namespace WpfMediatr.Dependencies
{
    public class GetString : IString
    {
        public async Task<string> Get()
        {
            return await Task.FromResult("Hello");
        }
    }
}