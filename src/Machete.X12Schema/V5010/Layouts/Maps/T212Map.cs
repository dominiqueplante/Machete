namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T212Map :
        X12LayoutMap<T212, X12Entity>
    {
        public T212Map()
        {
            Id = "T212";
            Name = "212 Motor Carrier Delivery Trailer Manifest";

            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1);
            Segment(x => x.BeginningMotorCarrierDeliveryTrailerManifest, 2);
            Segment(x => x.SetPurpose, 3);
            Segment(x => x.BusinessInstructionsAndReferenceNumber, 4);
            Layout(x => x.Loop0100, 5);
            Layout(x => x.Loop0150, 6);
            Layout(x => x.Loop0200, 7);
            Segment(x => x.TransactionSetTrailer, 8);
            Segment(x => x.FunctionalGroupTrailer, 9);
        }
    }
}