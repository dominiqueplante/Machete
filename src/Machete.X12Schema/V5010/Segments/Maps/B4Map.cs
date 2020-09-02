namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class B4Map :
        X12SegmentMap<B4, X12Entity>
    {
        public B4Map()
        {
            Id = "B4";
            Name = "Beginning Segment for Inquiry or Reply";
            
            Value(x => x.SpecialHandlingCode, 1, x => x.MinLength(2).MaxLength(3));
            Value(x => x.InquiryRequestNumber, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.ShipmentStatusCode, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time, 5, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.StatusLocation, 6, x => x.MinLength(3).MaxLength(5));
            Value(x => x.EquipmentInitial, 7, x => x.MinLength(1).MaxLength(4));
            Value(x => x.EquipmentNumber, 8, x => x.MinLength(1).MaxLength(15));
            Value(x => x.EquipmentStatusCode, 9, x => x.MinLength(1).MaxLength(2));
            Value(x => x.EquipmentType, 10, x => x.FixedLength(4));
            Value(x => x.LocationIdentifier, 11, x => x.MinLength(1).MaxLength(30));
            Value(x => x.LocationQualifier, 12, x => x.MinLength(1).MaxLength(2));
            Value(x => x.EquipmentNumberCheckDigit, 13, x => x.FixedLength(1));
        }
    }
}