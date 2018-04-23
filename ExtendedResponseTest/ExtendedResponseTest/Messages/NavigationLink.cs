namespace ExtendedResponseTest.Messages
{
    using System.Runtime.Serialization;

    [DataContract]
    public class NavigationLink
    {
        [DataMember]
        public string Href { get; private set; }
        [DataMember]
        public string Rel { get; private set; }
        [DataMember]
        public string Method { get; private set; }

        public NavigationLink(string href, string rel, string method)
        {
            this.Href = href;
            this.Rel = rel;
            this.Method = method;
        }
    }
}
