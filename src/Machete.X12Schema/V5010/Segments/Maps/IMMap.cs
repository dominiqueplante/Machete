namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class IMMap :
        X12SegmentMap<IM, X12Entity>
    {
        public IMMap()
        {
            Id = "IM";
            Name = "Intermodal Movement Information";
            
            Value(x => x.WaterMovementCode, 1, x => x.FixedLength(1));
            Value(x => x.SpecialHandlingCode, 2, x => x.MinLength(2).MaxLength(3));
            Value(x => x.InlandTransportationCode, 3, x => x.FixedLength(2));
        }
    }
}