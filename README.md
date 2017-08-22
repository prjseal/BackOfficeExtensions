# BackOfficeExtensions
This library gives you a helper methods for Umbraco backoffice on the front end of the site.

It will show an edit link which takes you to the umbraco backoffice edit screen for the page you are currently viewing.

## NuGet

Install via NuGet: ``` Install-Package BackOfficeExtensions -Version 1.0.1 ```

## Basic Usage

Add a using statement to your master template

```javascript
@using BackOfficeExtensions
```

Then put this helper just after the opening body tag in the master template

```javascript
@Html.UmbracoEditLink(Model.Content)
```

There are optional parameters for you to edit the text, colour, font size, position, z-index and even the umbraco edit link if you need to.

```javascript
@Html.UmbracoEditLink(Model.Content, position: EditLinkPosition.TopLeft, linkColour: "#00aea2", editMessage: "Edit", margin: 10, zindex: 999, umbracoEditContentUrl: "/umbraco#/content/content/edit/")
```
