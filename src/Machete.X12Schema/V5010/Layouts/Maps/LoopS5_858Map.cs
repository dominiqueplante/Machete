namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopS5_858Map :
        X12LayoutMap<LoopS5_858, X12Entity>
    {
        public LoopS5_858Map()
        {
            Id = "Loop_S5_858";
            Name = "Loop N1";
            
            Segment(x => x.StopOffDetails, 0);
            Segment(x => x.DateOrTime, 1);
            Segment(x => x.ExtendedReferenceInformation, 2);
            Segment(x => x.SpecialServices, 3);
            Layout(x => x.LoopN1, 4);
        }
    }
}