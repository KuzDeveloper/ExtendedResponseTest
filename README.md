# ExtendedResponseTest
.Net Core 2.0 Web Api project to test how to extend basic json and xml calls with custom accept header values

There are 2 controllers in the project:

1. PreferredController - this oneontains the code I would like to use (without FormatFilter, simply relying on the Accept header value).
2. FormatFilterController - this one contains the format filter code. Less preferred as I do not want to add extra url parameters to the web api calls.

-----------------

In Fiddler I am using the PreferredController as follows:

HTTP/1.1 - GET

http://www.extendedresponsetest.com/preferred/getsomething

User-Agent: Fiddler
Host: www.extendedresponsetest.com
Content-Length: 0
content-type: application/xml
accept: application/xml

It only works with application/json and application/json-hateoas. For xml the response code is 504, for xml-hateoas it is 406.

-----------------

In Fiddler I am using the FormatFilterController as follows:

HTTP/1.1 - GET

http://www.extendedresponsetest.com/formatfilter/getsomething/xml

User-Agent: Fiddler
Host: www.extendedresponsetest.com
Content-Length: 0
content-type: application/xml

It works with all 4 values, but only returns json even for xml.
