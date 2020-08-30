namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLX_1_811Map :
        X12LayoutMap<LoopLX_1_811, X12Entity>
    {
        public LoopLX_1_811Map()
        {
            Id = "Loop_LX_1_811";
            Name = "Loop LX";

            Segment(x => x.TransactionSetLineNumber, 0);
            Segment(x => x.VehicleInformation, 1);
            Segment(x => x.ServiceCharacteristicInformation, 2);
            Segment(x => x.ProductItemDescription, 3);
            Segment(x => x.Measurements, 4);
            Segment(x => x.ReferenceInformation, 5);
            Segment(x => x.MonetaryAmountInformation, 6);
            Segment(x => x.DateOrTimeReference, 7);
            Segment(x => x.TaxInformation, 8);
            Layout(x => x.LoopQTY, 9);
        }
    }
}