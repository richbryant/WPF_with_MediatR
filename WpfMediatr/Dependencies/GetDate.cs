using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMediatr.Dependencies
{
    public class Date : IDateTime
    {
        public async Task<DateTime> Get()
        {
            return await Task.FromResult(DateTime.Today);
        }
    }
}
