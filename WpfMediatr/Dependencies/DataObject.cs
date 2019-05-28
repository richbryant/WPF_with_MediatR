using System.Threading.Tasks;

namespace WpfMediatr.Dependencies
{
    public class DataObject: IDataObject
    {
        public async Task<Person> Get()
        {
            var p = new Person
            {
                FirstName = "John",
                LastName  = "Smith"
            };

            return await Task.FromResult(p);
        }
        
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}