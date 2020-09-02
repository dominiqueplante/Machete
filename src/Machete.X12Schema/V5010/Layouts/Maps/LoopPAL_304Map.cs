namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopPAL_304Map :
        X12LayoutMap<LoopPAL_304, X12Entity>
    {
        public LoopPAL_304Map()
        {
            Id = "Loop_PAL_304";
            Name = "Loop PAL";
            
            Segment(x => x.PalletTypeAndLoadCharacteristics, 0);
            Segment(x => x.QuantityInformation, 1);
        }
    }
}