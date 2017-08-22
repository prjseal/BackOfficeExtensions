# BackOfficeExtensions
This package gives you some helper methods for Umbraco backoffice.

Add a using statement to your master template
@using BackOfficeExtensions

Then put this helper just after the opening body tag in the master template
@Html.UmbracoEditLink(Model.Content)

You can edit the text, colour, font size, position, z-index and even the umbraco edit link if you need to.
