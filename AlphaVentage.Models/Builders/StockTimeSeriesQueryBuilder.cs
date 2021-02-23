using AlphaVentage.Helpers;
using AlphaVentage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVentage.Models.Builders
{

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
