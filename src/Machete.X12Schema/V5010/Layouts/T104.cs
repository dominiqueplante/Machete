namespace Machete.X12Schema.V5010
{
    using X12;


    public interface T104 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<N1> PartyIdentification { get; }
        
        Segment<N2> AdditionalNameInformation { get; }
        
        Segment<N3> PartyLocation { get; }
        
        Segment<N4> GeographicLocation { get; }
        
        SegmentList<N9> ExtendedReferenceInformation { get; }
        
        Segment<PER> AdministrativeCommunicationsContact { get; }
        
        Segment<P1> Pickup { get; }
        
        Segment<G47> StatementIdentification { get; }
        
        Segment<F9> OriginStation { get; }
        
        LayoutList<LoopFOB_104> LoopFOB { get; }
        
        Segment<L3> TotalWeightAndCharges { get; }
        
        SegmentList<NTE> NotesOrSpecialInstruction { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}