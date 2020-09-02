namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class M7AMap :
        X12SegmentMap<M7A, X12Entity>
    {
        public M7AMap()
        {
            Id = "M7A";
            Name = "Seal Number Replacement";
            
            Value(x => x.SealNumber1, 1, x => x.MinLength(2).MaxLength(15).IsRequired());
            Value(x => x.SealNumber2, 2, x => x.MinLength(2).MaxLength(15).IsRequired());
            Value(x => x.Date, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.EntityIdentifierCode, 4, x => x.MinLength(2).MaxLength(3));
            Value(x => x.Name, 5, x => x.MinLength(1).MaxLength(60));
            Value(x => x.Description, 6, x => x.MinLength(1).MaxLength(80));
        }
    }
}