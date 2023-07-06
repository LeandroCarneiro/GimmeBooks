namespace RestFullHelper
{
    public class ObjRequest
    {
        public string Method { get; set; }
        public object Parameters { get; set; }
        public ERequestType Type { get; set; }
    }
}
