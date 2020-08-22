namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class N7AMap :
        X12SegmentMap<N7A, X12Entity>
    {
        public N7AMap()
        {
            Id = "N7A";
            Name = "Accessorial Equipment Details";
            
            Value(x => x.LoadOrDeviceCode, 1, x => x.FixedLength(1));
            Value(x => x.Length, 2, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Diameter1, 3, x => x.MinLength(1).MaxLength(2));
            Value(x => x.HoseTypeCode, 4, x => x.FixedLength(3));
            Value(x => x.Diameter2, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.Diameter3, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.InletOrOutletMaterialTypeCode, 7, x => x.FixedLength(2));
            Value(x => x.InletOrOutletFittingTypeCode, 8, x => x.FixedLength(2));
            Value(x => x.MiscellaneousEquipmentCode, 9, x => x.FixedLength(2));
        }
    }
}