using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triple.Student.Api.Brokers.DateTimes
{
    public interface IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime();
    }
}
