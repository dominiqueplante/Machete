﻿namespace Machete.X12.Values.Formatters
{
    public class DateTimePeriodValueFormatter :
        IValueFormatter<DateTimePeriod>
    {
        public void Format(FormatValueContext<DateTimePeriod> context)
        {
            if (context.Value.HasValue)
                context.Append(context.Value.Slice);
        }
    }
}