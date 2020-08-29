namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class OTIMap :
        X12SegmentMap<OTI, X12Entity>
    {
        public OTIMap()
        {
            Id = "OTI";
            Name = "Original Transaction Identification";
            
            Value(x => x.ApplicationAcknowledgementCode, 1, x => x.MinLength(1).MaxLength(2).IsRequired());
            Value(x => x.ReferenceIdentificationQualifier, 2, x => x.MinLength(2).MaxLength(3).IsRequired());
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(50).IsRequired());
            Value(x => x.ApplicationSendersCode, 4, x => x.MinLength(2).MaxLength(15));
            Value(x => x.ApplicationReceiversCode, 5, x => x.MinLength(2).MaxLength(15));
            Value(x => x.Date, 6, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Time, 7, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.Converter = X12ValueConverters.TimeWithSeconds;
            });
            Value(x => x.GroupControlNumber, 8, x => x.MinLength(1).MaxLength(9));
            Value(x => x.TransactionSetControlNumber, 9, x => x.MinLength(4).MaxLength(9));
            Value(x => x.TransactionSetIdentifierNumber, 10, x => x.FixedLength(3));
            Value(x => x.VersionReleaseOrIndustryIdentifierCode, 11, x => x.MinLength(1).MaxLength(12));
            Value(x => x.TransactionSetPurposeCode, 12, x => x.FixedLength(2));
            Value(x => x.TransactionTypeCode, 13, x => x.FixedLength(2));
            Value(x => x.ApplicationType, 14, x => x.FixedLength(2));
            Value(x => x.ActionCode, 15, x => x.MinLength(1).MaxLength(2));
            Value(x => x.TransactionHandlingCode, 16, x => x.MinLength(1).MaxLength(2));
            Value(x => x.StatusReasonCode, 17, x => x.FixedLength(3));
        }
    }
}