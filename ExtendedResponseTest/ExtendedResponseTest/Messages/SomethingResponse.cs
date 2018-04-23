namespace ExtendedResponseTest.Messages
{
    using System.Runtime.Serialization;

    [DataContract]
    public class SomethingResponse
    {
        [DataMember]
        public string Origin { get; private set; }
        [DataMember]
        public int JustSomething { get; private set; }

        public SomethingResponse(string origin, int justSomething)
        {
            this.Origin = origin;
            this.JustSomething = justSomething;
        }
    }
}
