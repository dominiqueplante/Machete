namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class Q2Map :
        X12SegmentMap<Q2, X12Entity>
    {
        public Q2Map()
        {
            Id = "Q2";
            Name = "Status Details (Ocean)";
            
            Value(x => x.VesselCode, 1, x => x.MinLength(1).MaxLength(8));
            Value(x => x.CountryCode, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.Date1, 3, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date2, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.Date3, 5, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.LadingQuantity, 6, x => x.MinLength(1).MaxLength(7));
            Value(x => x.Weight, 7, x => x.MinLength(1).MaxLength(10));
            Value(x => x.WeightQualifier, 8, x => x.MinLength(1).MaxLength(2));
            Value(x => x.FlightOrVoyageNumber, 9, x => x.MinLength(2).MaxLength(10));
            Value(x => x.ReferenceIdentificationQualifier, 10, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 11, x => x.MinLength(1).MaxLength(50));
            Value(x => x.VesselCodeQualifier, 12, x => x.FixedLength(1));
            Value(x => x.VesselName, 13, x => x.MinLength(2).MaxLength(28));
            Value(x => x.Volume, 14, x => x.MinLength(1).MaxLength(8));
            Value(x => x.VolumeUnitQualifier, 15, x => x.FixedLength(1));
            Value(x => x.WeightUnitCode, 16, x => x.FixedLength(1));
        }
    }
}