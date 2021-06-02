using System;
using ServiceStack;
using DolTest.ServiceModel;
using System.Collections.Generic;

namespace DolTest.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(QueryDolFta request)
        {
            var results = new List<string> { $"Requested transmittal status: {request.TransmittalStatus}", "b" };
            var response = new QueryDolFtaResponse { 
                Offset = request.Skip.GetValueOrDefault(),
                Total = results.Count,
                Results = results,
                Meta = new Dictionary<string, string> { { "Skip",request.Skip.ToString()}, { "Take", request.Take.ToString() } }
            };

            if (request.TransmittalStatus == "ThrowError")
            {
                throw new ArgumentException("Exception for example error response");
            }

            return response;
            
        }
    }
}
