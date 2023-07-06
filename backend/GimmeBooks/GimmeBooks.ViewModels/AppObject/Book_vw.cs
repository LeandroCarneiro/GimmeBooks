namespace GimmeBooks.ViewModels.AppObject
{
    public class Book_vw : EntityBase_vw<long>
    {
        public new string Id { get; set; }
        public string Etag { get; set; }
        public string SelfLink { get; set; }
        public VolumeInfo_vw VolumeInfo { get; set; }
    }
}
