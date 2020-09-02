namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class N12Map :
        X12SegmentMap<N12, X12Entity>
    {
        public N12Map()
        {
            Id = "N12";
            Name = "Equipment Environment";
            
            Value(x => x.FuelType, 1, x => x.FixedLength(1).IsRequired());
            Entity(x => x.CompositeUnitOfMeasure, 2, x => x.IsRequired());
        }
    }
}