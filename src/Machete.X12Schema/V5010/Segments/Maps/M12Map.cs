namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M12Map :
        X12SegmentMap<M12, X12Entity>
    {
        public M12Map()
        {
            Id = "M12";
            Name = "In-bond Identifying Information";
            
            Value(x => x.CustomsEntryTypeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.CustomsEntryNumber, 2, x => x.MinLength(1).MaxLength(15));
            Value(x => x.LocationIdentifier1, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.LocationIdentifier2, 4, x => x.MinLength(1).MaxLength(30));
            Value(x => x.CustomsShipmentValue, 5, x => x.MinLength(2).MaxLength(8));
            Value(x => x.InbondControlNumber, 6, x => x.MinLength(1).MaxLength(25));
            Value(x => x.StandardCarrierAlphaCode, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.ReferenceIdentifierQualifier, 8, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 9, x => x.MinLength(1).MaxLength(50));
            Value(x => x.TransportationMethodOrTypeCode, 10, x => x.MinLength(1).MaxLength(2));
            Value(x => x.VesselName, 11, x => x.MinLength(2).MaxLength(28));
        }
    }
}