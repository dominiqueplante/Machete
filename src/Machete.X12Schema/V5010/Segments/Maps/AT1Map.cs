namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class AT1Map :
        X12SegmentMap<AT1, X12Entity>
    {
        public AT1Map()
        {
            Id = "AT1";
            Name = "Bill of Lading Line Item Number";
            
            Value(x => x.LadingLineItemNumber, 1, x => x.MinLength(1).MaxLength(3).IsRequired());
        }
    }
}