namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop0320_204Map :
        X12LayoutMap<Loop0320_204, X12Entity>
    {
        public Loop0320_204Map()
        {
            Id = "Loop_0320_204";
            Name = "Loop 0320";
            
            Segment(x => x.DescriptionMarksAndNumbers, 0);
            Segment(x => x.ShipmentWeightPackagingAndQuantityData, 1);
            Layout(x => x.Loop0325_1, 2);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 3);
            Segment(x => x.Measurements, 4);
            Segment(x => x.AdministrativeCommunicationsContact, 5);
            Segment(x => x.Measurement, 6);
            Layout(x => x.Loop0325_2, 7);
        }
    }
}