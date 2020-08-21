namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PODMap :
        X12SegmentMap<POD, X12Entity>
    {
        public PODMap()
        {
            Id = "POD";
            Name = "Proof of Delivery";

            Value(x => x.Date, 1, x => x.FixedLength(8).IsRequired());
            Value(x => x.Time, 2, x => x.MinLength(4).MaxLength(8));
            Value(x => x.Name, 3, x=>x.MinLength(1).MaxLength(60).IsRequired());

        }
    }
}