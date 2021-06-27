using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.Spider
{
    public class Invoker : IInvoker
    {
        private readonly IScratcher _scratcher;
        private readonly IHtmlResolver _htmlResolver;

        public Invoker(
            IScratcher scratcher,
            IHtmlResolver htmlResolver)
        {
            _scratcher = scratcher;
            _htmlResolver = htmlResolver;
        }

        public async Task InvokeAsync()
        {
            var html = await _scratcher.ScratchBrand();
            var brands = await _htmlResolver.ResolveBrands(html);
        }
    }
}
