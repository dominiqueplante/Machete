namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L4Map :
        X12SegmentMap<L4, X12Entity>
    {
        public L4Map()
        {
            Id = "L4";
            Name = "Measurement";
            
            Value(x => x.Length, 1, x => x.MinLength(1).MaxLength(8).IsRequired());
            Value(x => x.Width, 2, x => x.MinLength(1).MaxLength(8).IsRequired());
            Value(x => x.Height, 3, x => x.MinLength(1).MaxLength(8).IsRequired());
            Value(x => x.MeasurementUitQualifier, 4, x => x.FixedLength(1).IsRequired());
            Value(x => x.Quantity, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.IndustryCode, 6, x => x.MinLength(1).MaxLength(30));
        }
    }
}