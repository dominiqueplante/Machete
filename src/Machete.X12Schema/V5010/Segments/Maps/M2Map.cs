namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class M2Map :
        X12SegmentMap<M2, X12Entity>
    {
        public M2Map()
        {
            Id = "M2";
            Name = "Sales/Delivery Terms";
            
            Value(x => x.SalesTermsCode, 1, x => x.FixedLength(2).IsRequired());
            Value(x => x.SalesReferenceNumber, 2, x => x.MinLength(4).MaxLength(6));
            Value(x => x.SalesReferenceDate, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.TransportationTermsCode, 4, x => x.FixedLength(3));
            Value(x => x.SalesComment, 5, x => x.MinLength(2).MaxLength(30));
            Value(x => x.DeliveryDate, 6, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.LocationQualifier, 7, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LocationIdentifier, 8, x => x.MinLength(1).MaxLength(30));
        }
    }
}