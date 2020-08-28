namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BCTMap :
        X12SegmentMap<BCT, X12Entity>
    {
        public BCTMap()
        {
            Id = "BCT";
            Name = "Beginning Segment for Price/Sales Catalog";
            
            Value(x => x.CatalogPurposeCode, 1, x=> x.FixedLength(2).IsRequired());
            Value(x => x.CatalogNumber1, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.CatalogVersionNumber1, 3, x => x.MinLength(1).MaxLength(15));
            Value(x => x.CatalogRevisionNumber1, 4, x => x.MinLength(1).MaxLength(6));
            Value(x => x.UnitOrBasisForMeasurementCode, 5, x => x.FixedLength(2));
            Value(x => x.CatalogNumber2, 6, x=> x.MinLength(1).MaxLength(15));
            Value(x => x.CatalogVersionNumber2, 7, x => x.MinLength(1).MaxLength(15));
            Value(x => x.CatalogRevisionNumber2, 8, x => x.MinLength(1).MaxLength(6));
            Value(x => x.Description, 9, x => x.MinLength(1).MaxLength(80));
            Value(x => x.TransactionSetPurposeCode, 10, x => x.FixedLength(2));
        }
    }
}