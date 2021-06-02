using ServiceStack;
using System.Collections.Generic;

namespace DolTest.ServiceModel
{
    [Route("/QueryDolFta/{TransmittalStatus}", Verbs ="GET")]
    public class QueryDolFta : QueryBase, IReturn<QueryDolFtaResponse>
    {
        public string TransmittalStatus { get; set; }
    }

    public class QueryDolFtaResponse : QueryResponse<string>
    {
    }
}
