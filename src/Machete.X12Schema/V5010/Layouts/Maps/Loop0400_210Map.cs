namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0400_210Map :
        X12LayoutMap<Loop0400_210, X12Entity>
    {
        public Loop0400_210Map()
        {
            Id = "Loop_0400_210";
            Name = "Loop 0400";
            
            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 1);
            Segment(x => x.DescriptionMarksAndNumbers, 2);
            Segment(x => x.HazardousMaterial, 3);
            Segment(x => x.AdditionalHazardousMaterialDescription, 4);
            Segment(x => x.LineItemQuantityAndWeight, 5);
            Segment(x => x.RateAndCharges, 6);
            Segment(x => x.Measurement, 7);
            Segment(x => x.TariffReference, 8);
            Segment(x => x.Remarks, 9);
            Layout(x => x.Loop0430, 10);
            Layout(x => x.Loop0460, 11);
        }
    }
}