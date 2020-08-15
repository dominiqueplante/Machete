namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopS5_852Map :
        X12LayoutMap<LoopS5_852, X12Entity>
    {
        public LoopS5_852Map()
        {
            Id = "Loop_S5_852";
            Name = "Loop S5";  
            
            Segment(x => x.StopOffDetails, 0);
            Segment(x => x.DateOrTime, 1);
            Segment(x => x.ExtendedReferenceInformation, 2);
            Segment(x => x.SpecialServices, 3);
            Layout(x => x.LoopN1, 4);
        }
    }
}