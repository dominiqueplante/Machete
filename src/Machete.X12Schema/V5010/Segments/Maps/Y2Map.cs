namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Y2Map :
        X12SegmentMap<Y2, X12Entity>
    {
        public Y2Map()
        {
            Id = "Y2";
            Name = "Container Details";
            
            Value(x => x.NumberOfContainers, 1, x => x.MinLength(1).MaxLength(4).IsRequired());
            Value(x => x.ContainerTypeRequestCode, 2, x => x.FixedLength(1));
            Value(x => x.TypeOfServiceCode, 3, x => x.FixedLength(2));
            Value(x => x.EquipmentType, 4, x => x.FixedLength(4).IsRequired());
            Value(x => x.TransportationMethodCode, 5, x => x.MinLength(1).MaxLength(2));
            Value(x => x.IntermodalServiceCode, 6, x => x.MinLength(1).MaxLength(2));
            Value(x => x.StandardCarrierAlphaCode, 7, x => x.MinLength(2).MaxLength(4));
            Value(x => x.ContainerTermsCode, 8, x => x.FixedLength(3));
            Value(x => x.ContainerTermsCodeQualifier, 9, x => x.FixedLength(1));
            Value(x => x.TotalStopOffs, 10, x => x.MinLength(1).MaxLength(2));
        }
    }
}