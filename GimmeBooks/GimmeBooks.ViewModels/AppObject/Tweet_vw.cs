namespace GimmeBooks.ViewModels.AppObject
{
    public class Tweet_vw : EntityBase_vw<long>
    {
        public string User { get; set; }
        public string Text { get; set; }
        public string Header => $" User: {User} \n  Tweet: {Text} \n";
    }
}
