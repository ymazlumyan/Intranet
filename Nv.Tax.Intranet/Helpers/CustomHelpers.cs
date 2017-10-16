using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nv.Tax.Intranet.Helpers
{
    public static class CustomHelpers
    {
        public static IHtmlString MenuItem(this HtmlHelper helper, string title, object htmlAttributes)
        {
            var span = new TagBuilder("span");

            span.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            return MvcHtmlString.Create(@"<a href='#'>" + span + title + "</a>");
        }

        public static IHtmlString MenuItem(this HtmlHelper html, string title, string action, object htmlAttributes)
        {
            
            var span = new TagBuilder("span");

            span.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            return MvcHtmlString.Create(string.Format("<a href='/{0}/{1}'>" + span + title + "</a>", html.ViewContext.RouteData.GetRequiredString("controller"), action));
        }

        public static IHtmlString MenuItem(this HtmlHelper html, string title, string action, string controller, object htmlAttributes)
        {
            var span = new TagBuilder("span");

            span.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            return MvcHtmlString.Create(string.Format("<a href='/{0}/{1}'>" + span + title + "</a>", controller, action));
        }
    }
}