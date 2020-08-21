namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class MS3Map :
        X12SegmentMap<MS3, X12Entity>
    {
        public MS3Map()
        {
            Id = "MS3";
            Name = "Interline Information";
            
            Value(x => x.StandardCarrierAlphaCode, 1, x => x.MinLength(2).MaxLength(4).IsRequired());
            Value(x => x.RoutingSequenceCode, 2, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.CityName, 3, x => x.MinLength(2).MaxLength(30));
            Value(x => x.TransportationMethodOrTypeCode, 4, x => x.MinLength(1).MaxLength(2));
            Value(x => x.StateOrProvinceCode, 5, x => x.FixedLength(2));
        }
    }
}