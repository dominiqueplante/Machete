namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class EMMap :
        X12SegmentMap<EM, X12Entity>
    {
        public EMMap()
        {
            Id = "EM";
            Name = "Equipment Characteristics";
            
            Value(x => x.WeightUnitCode, 1, x => x.FixedLength(1));
            Value(x => x.Weight, 2, x => x.MinLength(1).MaxLength(10));
            Value(x => x.VolumeUnitQualifier, 3, x => x.FixedLength(1));
            Value(x => x.Volume, 4, x => x.MinLength(1).MaxLength(8));
            Value(x => x.CountryCode, 5, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ConstructionType, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Date, 7, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
        }
    }
}