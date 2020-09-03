namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T8Map :
        X12SegmentMap<T8, X12Entity>
    {
        public T8Map()
        {
            Id = "T8";
            Name = "Free-form Transit Data";
            
            Value(x => x.AssignedNumber, 1, x => x.MinLength(1).MaxLength(6).IsRequired());
            Value(x => x.TransitFreeformData, 2, x => x.MinLength(1).MaxLength(80).IsRequired());
        }
    }
}