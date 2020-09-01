namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class R2AMap :
        X12SegmentMap<R2A, X12Entity>
    {
        public R2AMap()
        {
            Id = "R2A";
            Name = "Route Information with Preference";
            
            Value(x => x.RoutingSequenceCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.Preference, 2, x => x.FixedLength(1).IsRequired());
            Value(x => x.TransportationMethodCode, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.StandardCarrierAlphaCode, 4, x => x.MinLength(2).MaxLength(4));
            Value(x => x.LocationQualifier, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier, 6, x => x.MinLength(1).MaxLength(30));
            Value(x => x.TypeOfServiceCode, 7, x => x.FixedLength(2));
            Value(x => x.RouteCode, 8, x => x.MinLength(1).MaxLength(13));
            Value(x => x.RouteDescription, 9, x => x.MinLength(1).MaxLength(35));
            Value(x => x.EntityIdentifierCode, 10, x => x.MinLength(2).MaxLength(3));
        }
    }
}