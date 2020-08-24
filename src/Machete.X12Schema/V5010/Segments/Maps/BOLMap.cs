namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BOLMap :
        X12SegmentMap<BOL, X12Entity>
    {
        public BOLMap()
        {
            Id = "BOL";
            Name = "Beginning Segment for the Motor Carrier Bill of Lading";
            
            Value(x => x.StandardCarrierAlphaCode, 1, x => x.MinLength(2).MaxLength(4));
            Value(x => x.ShipmentMethodOfPayment1, 2, x => x.FixedLength(2));
            Value(x => x.ShipmentIdentificationNumber, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
            });
            Value(x => x.Time, 5, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
            });
            Value(x => x.ReferenceIdentification, 6, x => x.MinLength(1).MaxLength(50));
            Value(x => x.StatusReportRequestCode, 7, x => x.FixedLength(1));
            Value(x => x.SectionSevenCode, 8, x => x.FixedLength(1));
            Value(x => x.CustomsDocumentationHandlingCode, 9, x => x.FixedLength(2));
            Value(x => x.ShipmentMethodOfPayment2, 10, x => x.FixedLength(2));
            Value(x => x.CurrencyCode, 11, x => x.FixedLength(3));
        }
    }
}