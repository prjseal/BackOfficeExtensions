using System.Text;
using System.Web.Mvc;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Security;

namespace BackOfficeExtensions
{
    public static class HtmlHelpers
    {
        public enum EditLinkPosition
        {
            TopLeft = 0,
            TopRight = 1,
            BottomRight = 2,
            BottomLeft = 3
        }

        public static IHtmlString UmbracoEditLink(this HtmlHelper helper, IPublishedContent thisPage, 
            EditLinkPosition position = EditLinkPosition.TopLeft, string linkColour = "#00aea2", string editMessage = "Edit", 
            int margin = 10, int zindex = 999, string umbracoEditContentUrl = "/umbraco#/content/content/edit/")
        {
            StringBuilder editLinkCode = new StringBuilder();
            var userTicket = new HttpContextWrapper(HttpContext.Current).GetUmbracoAuthTicket();

            if (userTicket != null)
            {
                string outerStyles = "display:block;";

                switch (position)
                {
                    case EditLinkPosition.TopLeft:
                        outerStyles += $"top:{margin}px;";
                        outerStyles += $"left:{margin}px;";
                        break;
                    case EditLinkPosition.TopRight:
                        outerStyles += $"top:{margin}px;";
                        outerStyles += $"right:{margin}px;";
                        break;
                    case EditLinkPosition.BottomRight:
                        outerStyles += $"bottom:{margin}px;";
                        outerStyles += $"right:{margin}px;";
                        break;
                    case EditLinkPosition.BottomLeft:
                        outerStyles += $"bottom:{margin}px;";
                        outerStyles += $"left:{margin}px;";
                        break;
                }

                outerStyles += $"z-index:{zindex};";
                outerStyles += "position:fixed;";

                editLinkCode.Append($"<div");
                if (!string.IsNullOrEmpty(outerStyles))
                {
                    editLinkCode.Append($" style=\"{outerStyles}\"");
                }
                editLinkCode.Append($">");

                string linkStyles = $"color:{linkColour};";

                editLinkCode.Append($"<a ");
                if (!string.IsNullOrEmpty(linkStyles))
                {
                    editLinkCode.Append($"style={linkStyles}");
                }

                editLinkCode.Append($"<a ");
                editLinkCode.Append($" target=\"_blank\"");
                editLinkCode.Append($" href =\"{umbracoEditContentUrl}{thisPage.Id}\"");
                editLinkCode.Append($">{editMessage}</a>");
                editLinkCode.Append($"</div>");
            }

            return MvcHtmlString.Create(editLinkCode.ToString());
        }
    }
}