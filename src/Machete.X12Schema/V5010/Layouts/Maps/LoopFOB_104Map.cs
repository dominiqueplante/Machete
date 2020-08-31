namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopFOB_104Map :
        X12LayoutMap<LoopFOB_104, X12Entity>
    {
        public LoopFOB_104Map()
        {
            Id = "Loop_FOB_104";
            Name = "Loop FOB";

            Segment(x => x.FreeOnBoardRelatedInstructions, 0);
            Segment(x => x.TariffDetails, 1);
            Segment(x => x.ExtendedReferenceInformation, 2);
            Segment(x => x.CarrierDetailsSpecialHandlingOrHazardousMaterial, 3);
            Segment(x => x.HazardousMaterial, 4);
            Segment(x => x.AdditionalHazardousMaterialDescription, 5);
            Segment(x => x.SpecialHandlingInstructions, 6);
            Segment(x => x.DateOrTimeReference, 7);
            Segment(x => x.Insurance, 8);
            Segment(x => x.CurrencyIdentifier, 9);
            Segment(x => x.ExportLicense, 10);
            Segment(x => x.ImportLicense, 11);
            Segment(x => x.NotesOrSpecialInstruction, 12);
            Layout(x => x.LoopN1, 13);
            Layout(x => x.LoopL5, 14);
            Segment(x => x.AncillaryCharges, 18);
        }
    }
}