namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class BFRMap :
        X12SegmentMap<BFR, X12Entity>
    {
        public BFRMap()
        {
            Id = "BFR";
            Name = "Beginning Segment for Planning Schedule";
            
            Value(x => x.TransactionSetPurposeCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentification, 2, x => x.MinLength(1).MaxLength(50));
            Value(x => x.ReleaseNumber, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.ScheduleTypeQualifier, 4, x => x.FixedLength(2).IsRequired());
            Value(x => x.ScheduleQuantityQualifier, 5, x => x.FixedLength(1).IsRequired());
            Value(x => x.Date1, 6, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 7, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date3, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date4, 9, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.ContractNumber, 10, x => x.MinLength(1).MaxLength(30));
            Value(x => x.PurchaseOrderNumber, 11, x => x.MinLength(1).MaxLength(22));
            Value(x => x.PlanningScheduleTypeCode, 12, x => x.FixedLength(2));
            Value(x => x.ActionCode, 13, x => x.MinLength(1).MaxLength(2));
        }
    }
}