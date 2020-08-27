namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopLQ_832Map :
        X12LayoutMap<LoopLQ_832, X12Entity>
    {
        public LoopLQ_832Map()
        {
            Id = "Loop_LQ_832";
            Name = "Loop LQ";
            
            Segment(x => x.IndustryCodeIdentification, 0);
            Segment(x => x.ReferenceIdentification, 1);
            Segment(x => x.ElectronicFormatIdentification, 2);
            Segment(x => x.DateOrTimeReference, 3);
            Layout(x => x.LoopLQ, 4);
        }
    }
}