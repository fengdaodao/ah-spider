using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.Spider
{
    public class HtmlResolver : IHtmlResolver
    {
        public Task<ICollection<Brand>> ResolveBrands(string html)
        {
            throw new NotImplementedException();
        }
    }
}
