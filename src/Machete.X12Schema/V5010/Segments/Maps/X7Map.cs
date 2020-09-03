namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class X7Map :
        X12SegmentMap<X7, X12Entity>
    {
        public X7Map()
        {
            Id = "X7";
            Name = "Customs Information";
            
            Value(x => x.FreeformInformation1, 1, x => x.MinLength(1).MaxLength(30));
            Value(x => x.FreeformInformation2, 2, x => x.MinLength(1).MaxLength(30));
        }
    }
}