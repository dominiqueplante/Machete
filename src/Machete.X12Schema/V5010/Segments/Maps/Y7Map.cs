namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class Y7Map :
        X12SegmentMap<Y7, X12Entity>
    {
        public Y7Map()
        {
            Id = "Y7";
            Name = "Cargo Booking Priority";
            
            Value(x => x.Priority, 1, x => x.FixedLength(1));
            Value(x => x.PriorityCode, 2, x => x.FixedLength(1));
            Value(x => x.PriorityCodeQualifier, 3, x => x.FixedLength(1));
            Value(x => x.PortCallFileNumber, 4, x => x.FixedLength(4));
            Value(x => x.Date, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}