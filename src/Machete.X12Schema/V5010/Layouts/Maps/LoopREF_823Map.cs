namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopREF_823Map :
        X12LayoutMap<LoopREF_823, X12Entity>
    {
        public LoopREF_823Map()
        {
            Id = "Loop_REF_823";
            Name = "Loop REF";
            
            Segment(x => x.ReferenceInformation, 0);
            Segment(x => x.DateOrTimeReference, 1);
        }
    }
}