namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class H5Map :
        X12SegmentMap<H5, X12Entity>
    {
        public H5Map()
        {
            Id = "H5";
            Name = "Car Service Order";
            
            Value(x => x.CarServiceOrderCode, 1, x => x.MinLength(3).MaxLength(2).IsRequired());
            Value(x => x.CityName, 2, x => x.MinLength(2).MaxLength(30));
            Value(x => x.StateOrProvinceCode, 3, x => x.FixedLength(2));
        }
    }
}