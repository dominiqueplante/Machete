namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BGNMap :
        X12SegmentMap<BGN, X12Entity>
    {
        public BGNMap()
        {
            Id = "BGN";
            Name = "Unitized Shipment Information";
            
            Value(x => x.TransactionSetPurposeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentification1, 2, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
            });
            Value(x => x.Time, 4, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
            });
            Value(x => x.TimeCode, 5, x => x.FixedLength(2));
            Value(x => x.ReferenceIdentification2, 6, x => x.MinLength(1).MaxLength(50));
            Value(x => x.TransactionTypeCode, 7, x => x.FixedLength(2));
            Value(x => x.ActionCode, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.SecurityLevelCode, 9, x => x.FixedLength(2));
        }
    }
}