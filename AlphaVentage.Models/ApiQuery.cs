using AlphaVentage.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVentage.Models
{
    public class ApiQuery : IApiQuery
    {
        public string MethodName { get; set; }
        public string Symbol { get; set; }

        public static ApiQueryBuilder ApiQueryBuilder = new ApiQueryBuilder();
        public override string ToString()
        {
            return KEYS.BASEURL + "function=" + MethodName + "&symbol=" + Symbol + "&apikey=" + KEYS.APIKEY;
        }
    }
    public class StockTimeSeriesQueryBuilder : ApiQueryBuilder, IApiQueryBuilder<StockTimeSeriesQuery>
    {
        private StockTimeSeriesQuery _apiQuery = new StockTimeSeriesQuery();

        public StockTimeSeriesQueryBuilder InMins(int val)
        {
            _apiQuery.Symbol = val + "min";
            return this;
        }
        StockTimeSeriesQuery IApiQueryBuilder<StockTimeSeriesQuery>.ApiQuery
        {
            get { return _apiQuery; }
            set { _apiQuery = value; }
        }

        StockTimeSeriesQuery IApiQueryBuilder<StockTimeSeriesQuery>.Build()
        {
            return _apiQuery.DeepClone();
        }
        public StockTimeSeriesQuery Build()
        {
            return (this as IApiQueryBuilder<StockTimeSeriesQuery>).Build();
        }

        public static implicit operator StockTimeSeriesQuery(StockTimeSeriesQueryBuilder stqb)
        {
            return stqb.Build();
        }
    }
}
