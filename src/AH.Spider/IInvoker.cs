using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AH.Spider
{
    public interface IInvoker
    {
        Task InvokeAsync();
    }
}
