using AlphaVentage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVentage.Models.Builders
{

    public interface IApiQueryBuilder<T> where T : IApiQuery
    {
        T ApiQuery { get; set; }

        T Build();
    }
}
