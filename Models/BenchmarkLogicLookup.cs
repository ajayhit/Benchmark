using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkLogicLookup
    {
        BenchmarkLogic obj = new BenchmarkLogic();

        [Benchmark]
        public void restrequest()
        {
            obj.restrequest(); 
        }
        [Benchmark]
        public void webrequest()
        {
            obj.webrequest();
        }

    }
}
