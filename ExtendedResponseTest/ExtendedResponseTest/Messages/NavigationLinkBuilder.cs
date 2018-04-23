namespace ExtendedResponseTest.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class NavigationLinkBuilder<T> where T : class
    {
        [DataMember]
        public T Value { get; private set; }
        private List<NavigationLink> _NavigationLinks;
        [DataMember(EmitDefaultValue = false)]
        public List<NavigationLink> NavigationLinks => _NavigationLinks;

        public NavigationLinkBuilder(T value)
        {
            Value = value;
        }

        public void AddNavigationLink(string href, string rel, string method)
        {
            AddNavigationLink(new NavigationLink(href, rel, method));
        }

        public void AddNavigationLink(NavigationLink navigationLink)
        {
            if (navigationLink != null)
            {
                if (_NavigationLinks == null)
                    _NavigationLinks = new List<NavigationLink>();

                _NavigationLinks.Add(navigationLink);
            }
        }
    }
}