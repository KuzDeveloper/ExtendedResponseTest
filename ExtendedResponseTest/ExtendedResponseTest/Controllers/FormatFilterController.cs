namespace ExtendedResponseTest.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ExtendedResponseTest.Messages;
    using Microsoft.AspNetCore.Mvc;

    public class FormatFilterController : Controller
    {
        [HttpGet]
        [Route("[controller]/GetSomething/{accept}")]
        [FormatFilter]
        public async Task<IActionResult> GetSomething(string accept)
        {
            if (!string.IsNullOrWhiteSpace(accept))
            {
                bool generateLinks = accept.EndsWith("-hateoas");

                List<NavigationLinkBuilder<SomethingResponse>> somethingResponse = new List<NavigationLinkBuilder<SomethingResponse>>();

                for (int i = 1; i < 4; i++)
                {
                    NavigationLinkBuilder<SomethingResponse> something = new NavigationLinkBuilder<SomethingResponse>(
                            new SomethingResponse("FormatFilter", i));

                    if (generateLinks)
                    {
                        something.AddNavigationLink(Url.Link("GetSomethingId", new { i }), "self", "GET");
                    }

                    somethingResponse.Add(something);
                }

                return await Task.FromResult(Ok(somethingResponse));
            }

            return await Task.FromResult(BadRequest());
        }
    }
}
