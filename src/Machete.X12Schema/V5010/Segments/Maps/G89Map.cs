namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G89Map :
        X12SegmentMap<G89, X12Entity>
    {
        public G89Map()
        {
            Id = "G89";
            Name = "Line Item Detail - Adjustment";
            
            Value(x => x.DirectStoreDeliverySequenceNumber, 1, x => x.MinLength(1).MaxLength(4).IsRequired());
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.UnitOrBasisOfMeasurementCode, 3, x => x.FixedLength(2));
            Value(x => x.UPCOrEANConsumerPackageCode, 4, x => x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier1, 5, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 6, x => x.MinLength(1).MaxLength(48));
            Value(x => x.UPCCaseCode, 7, x => x.FixedLength(12));
            Value(x => x.ItemListCost, 8, x => x.MinLength(1).MaxLength(9));
            Value(x => x.Pack, 9, x => x.MinLength(1).MaxLength(6));
            Value(x => x.InnerPack, 10, x => x.MinLength(1).MaxLength(6));
        }
    }
}