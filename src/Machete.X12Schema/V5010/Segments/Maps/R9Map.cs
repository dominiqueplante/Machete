namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class R9Map :
        X12SegmentMap<R9, X12Entity>
    {
        public R9Map()
        {
            Id = "R9";
            Name = "Route Code Identification";
            
            Value(x => x.RouteCode1, 1, x => x.MinLength(1).MaxLength(13).IsRequired());
            Value(x => x.AgentOrShipperRoutingCode, 2, x => x.FixedLength(1));
            Value(x => x.IntermodalServiceCode, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.StandardCarrierAlphaCode1, 4, x => x.MinLength(2).MaxLength(4));
            Value(x => x.ActionCode, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.StandardCarrierAlphaCode2, 6, x => x.MinLength(2).MaxLength(4));
            Value(x => x.YesNoConditionOrResponseCode1, 7, x => x.FixedLength(1));
            Value(x => x.YesNoConditionOrResponseCode2, 8, x => x.FixedLength(1));
            Value(x => x.RouteCode2, 9, x => x.MinLength(1).MaxLength(13));
        }
    }
}