namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L9Map :
        X12SegmentMap<L9, X12Entity>
    {
        public L9Map()
        {
            Id = "L9";
            Name = "Charge Detail";
            
            Value(x => x.SpecialChargeOrAllowanceCode, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.MonetaryAmount, 2, x => x.MinLength(1).MaxLength(18).IsRequired());
        }
    }
}