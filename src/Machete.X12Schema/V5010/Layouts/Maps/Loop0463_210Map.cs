namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0463_210Map :
        X12LayoutMap<Loop0463_210, X12Entity>
    {
        public Loop0463_210Map()
        {
            Id = "Loop_0463_210";
            Name = "Loop 0463";
            
            Segment(x => x.CartonPackageDetail, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.SpecialServices, 2);
            Segment(x => x.ChargeDetail, 3);
            Segment(x => x.ProofOfDelivery, 4);
            Segment(x => x.DateOrTime, 5);
        }
    }
}