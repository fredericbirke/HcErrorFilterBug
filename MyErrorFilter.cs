using System;
using HotChocolate;
using Microsoft.Extensions.Logging;

namespace HcErrorFilterBug
{
    public class MyErrorFilter: IErrorFilter
    {
        private readonly ILogger<MyErrorFilter> _myErrorFilter;

        public MyErrorFilter(ILogger<MyErrorFilter> myErrorFilter)
        {
            _myErrorFilter = myErrorFilter;
        }

        public IError OnError(IError error)
        {
            _myErrorFilter.LogCritical("An Error occured!");
            return error;
        }
    }
}