namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class B11Map :
        X12SegmentMap<B11, X12Entity>
    {
        public B11Map()
        {
            Id = "B11";
            Name = "Beginning Segment for Shipment Status Inquiry";
            
            Value(x => x.IdentificationCodeQualifier, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.IdentificationCode, 2, x => x.MinLength(2).MaxLength(80).IsRequired());
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
            });
            Value(x => x.UnitOrBasisForMeasurementCode, 4, x => x.FixedLength(2));
            Value(x => x.Quantity, 5, x => x.MinLength(1).MaxLength(15));
            Value(x => x.AmountQualifierCode, 6, x => x.MinLength(1).MaxLength(3));
            Value(x => x.MonetaryAmount, 7, x => x.MinLength(1).MaxLength(18));
            Value(x => x.ItemDescriptionType, 8, x => x.FixedLength(1));
            Value(x => x.Description, 9, x => x.MinLength(1).MaxLength(80));
            Value(x => x.ServiceLevelCode, 10, x => x.FixedLength(2));
            Value(x => x.ReportTransmissionCode, 11, x => x.MinLength(1).MaxLength(2));
        }
    }
}