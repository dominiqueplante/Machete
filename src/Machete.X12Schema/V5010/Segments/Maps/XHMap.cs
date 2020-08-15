namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class XHMap :
        X12SegmentMap<XH, X12Entity>
    {
        public XHMap()
        {
            Id = "XH";
            Name = "Pro Forma - B13 Information";
            
            Value(x => x.CurrencyCode, 1, x => x.FixedLength(3).IsRequired());
            Value(x => x.RelatedCompanyIndicationCode, 2, x => x.FixedLength(1));
            Value(x => x.SpecialChargeOrAllowanceCode, 3, x => x.FixedLength(3));
            Value(x => x.Amount, 4, x => x.MinLength(1).MaxLength(15));
            Value(x => x.Block20Code, 5, x => x.FixedLength(1));
            Value(x => x.ChemicalAnalysisPercentage, 6, x => x.MinLength(2).MaxLength(9));
            Value(x => x.UnitPrice, 7, x => x.MinLength(1).MaxLength(17));
        }
    }
}