namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class N7BMap :
        X12SegmentMap<N7B, X12Entity>
    {
        public N7BMap()
        {
            Id = "N7B";
            Name = "";
            
            Value(x => x.NumberOfTankCompartments, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.LoadingOrDischargeLocationCode, 2, x => x.FixedLength(1));
            Value(x => x.VesselMaterialCode, 3, x => x.FixedLength(3));
            Value(x => x.GasketTypeCode, 4, x => x.FixedLength(3));
            Value(x => x.TrailerLiningTypeCode, 5, x => x.FixedLength(3));
            Value(x => x.ReferenceIdentification, 6, x => x.MinLength(1).MaxLength(50));
        }
    }
}