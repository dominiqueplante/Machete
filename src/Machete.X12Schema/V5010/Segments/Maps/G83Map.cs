namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class G83Map :
        X12SegmentMap<G83, X12Entity>
    {
        public G83Map()
        {
            Id = "G83";
            Name = "Line Item Detail/Direct Store Delivery";
            
            Value(x => x.DirectStoreDeliverySequenceNumber, 1, x => x.MinLength(1).MaxLength(4).IsRequired());
            Value(x => x.Quantity, 2, x => x.MinLength(1).MaxLength(15).IsRequired());
            Value(x => x.UnitOrBasisOfMeasurementCode, 3, x => x.FixedLength(2).IsRequired());
            Value(x => x.UPCOrEANConsumerPackageCode, 4, x => x.FixedLength(12));
            Value(x => x.ProductOrServiceIdQualifier1, 5, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId1, 6, x => x.MinLength(1).MaxLength(48));
            Value(x => x.UPCCaseCode, 7, x => x.FixedLength(12));
            Value(x => x.ItemListCost, 8, x => x.MinLength(1).MaxLength(9));
            Value(x => x.Pack, 9, x => x.MinLength(1).MaxLength(6));
            Value(x => x.CashRegisterItemDescription, 105, x => x.MinLength(1).MaxLength(20));
            Value(x => x.ProductOrServiceIdQualifier2, 11, x => x.FixedLength(2));
            Value(x => x.ProductOrServiceId2, 12, x => x.MinLength(1).MaxLength(48));
            Value(x => x.InnerPack, 13, x => x.MinLength(1).MaxLength(6));
        }
    }
}