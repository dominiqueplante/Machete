namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class M7Map :
        X12SegmentMap<M7, X12Entity>
    {
        public M7Map()
        {
            Id = "M7";
            Name = "Seal Numbers";
            
            Value(x => x.SealNumber1, 1, x => x.MinLength(2).MaxLength(15).IsRequired());
            Value(x => x.SealNumber2, 2, x => x.MinLength(2).MaxLength(15));
            Value(x => x.SealNumber3, 3, x => x.MinLength(2).MaxLength(15));
            Value(x => x.SealNumber4, 4, x => x.MinLength(2).MaxLength(15));
            Value(x => x.EntityIdentifierCode, 5, x => x.MinLength(2).MaxLength(3));
        }
    }
}