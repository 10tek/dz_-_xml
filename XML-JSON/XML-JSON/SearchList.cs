using System;
using System.Collections.Generic;

namespace JSON
{
    public class SearchList
    {
        public int ResultCnt { get; set; }
        List<Result> results = new List<Result>();
    }
}
