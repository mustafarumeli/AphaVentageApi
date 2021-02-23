using AlphaVentage.Helpers;
using AlphaVentage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVentage.Models.Builders
{
    public class ApiQueryBuilder : IApiQueryBuilder<ApiQuery>
    {
        private ApiQuery _apiQuery = new ApiQuery();

        ApiQuery IApiQueryBuilder<ApiQuery>.ApiQuery
        {
            get { return _apiQuery; }
            set { _apiQuery = value; }
        }
        public ApiQueryBuilder WithMethodName(string methodName)
        {
            _apiQuery.MethodName = methodName;
            return this;
        }
        public ApiQueryBuilder GetResultsFor(string symbol)
        {
            _apiQuery.Symbol = symbol;
            return this;
        }
        public ApiQuery Build()
        {
            return (this as IApiQueryBuilder<ApiQuery>).Build();
        }

        ApiQuery IApiQueryBuilder<ApiQuery>.Build()
        {

            return _apiQuery.DeepClone();
        }

        public static implicit operator ApiQuery(ApiQueryBuilder aqb)
        {
            return aqb.Build();
        }
    }
}
