using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AH.Spider
{
    /// <summary>
    /// 抓取数据
    /// </summary>
    public interface IScratcher
    {
        Task<string> ScratchBrand();

        Task<string> ScratchSeries();

        Task<string> ScratchModel();
    }

    public class Brand
    {
        
    }

    public class Series
    {

    }

    public class Model
    {

    }
}
