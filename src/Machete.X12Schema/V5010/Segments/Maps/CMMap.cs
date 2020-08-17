namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;
    using X12.Values.Converters;


    public class CMMap :
        X12SegmentMap<CM, X12Entity>
    {
        public CMMap()
        {
            Id = "CM";
            Name = "Cargo Manifest";
            
            Value(x => x.FlightOrVoyageNumber, 1, x => x.MinLength(2).MaxLength(10));
            Value(x => x.PortOrTerminalFunctionCode, 2, x => x.FixedLength(1));
            Value(x => x.PortName, 3, x => x.MinLength(2).MaxLength(24));
            Value(x => x.Date1, 4, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.BookingNumber, 5, x => x.MinLength(1).MaxLength(17));
            Value(x => x.StandardCarrierAlphaCode1, 6, x => x.MinLength(2).MaxLength(4));
            Value(x => x.StandardCarrierAlphaCode2, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.Date2, 8, x =>
            {
                x.FixedLength(8);
                x.Converter = X12ValueConverters.VariableDate;
            });
            Value(x => x.VesselName, 9, x => x.MinLength(2).MaxLength(28));
            Value(x => x.PierNumber, 10, x => x.MinLength(1).MaxLength(4));
            Value(x => x.PierName, 11, x => x.MinLength(2).MaxLength(14));
            Value(x => x.TerminalName, 12, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 13, x => x.FixedLength(2));
            Value(x => x.CountryCode, 14, x => x.MinLength(2).MaxLength(3));
            Value(x => x.ReferenceIdentification, 15, x => x.MinLength(1).MaxLength(50));
            Value(x => x.CorrectionIndicator, 16, x => x.FixedLength(2));
            Value(x => x.TransportationMethodOrTypeCode, 17, x => x.MinLength(1).MaxLength(2));
        }
    }
}