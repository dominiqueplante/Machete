namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopN9_832Map :
        X12LayoutMap<LoopN9_832, X12Entity>
    {
        public LoopN9_832Map()
        {
            Id = "LoopN9_832";
            Name = "Loop N9";
            
            Segment(x => x.ExtendedReferenceInformation, 0);
            Segment(x => x.DateOrTimeReference, 1);
            Segment(x => x.Text, 2);
            Segment(x => x.Paperwork, 3);
            Segment(x => x.ElectronicFormatIdentification, 4);
        }
    }
}