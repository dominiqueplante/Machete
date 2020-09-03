namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopREF_417Map :
        X12LayoutMap<LoopREF_417, X12Entity>
    {
        public LoopREF_417Map()
        {
            Id = "Loop_REF_417";
            Name = "Loop REF";
            
            Segment(x => x.ReferenceInformation, 0);
            Segment(x => x.QuantityAndDescription, 1);
            Layout(x => x.LoopL0, 2);
        }
    }
}