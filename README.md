# BackOfficeExtensions
This library gives you a helper methods for Umbraco backoffice on the front end of the site.

It will show an edit link which takes you to the umbraco backoffice edit screen for the page you are currently viewing.

## NuGet

```javascript
Install-Package BackOfficeExtensions -Version 1.0.2
```

[![Nuget Downloads](https://img.shields.io/nuget/dt/BackOfficeExtensions.svg)](https://www.nuget.org/packages/BackOfficeExtensions)

## Basic Usage

Add a using statement to your master template

```javascript
@using BackOfficeExtensions
```

Then put this helper just after the opening body tag in the master template

```javascript
@Html.UmbracoEditLink(Model.Content)
```

## Optional Parameters

There are optional parameters for you to edit:
- position: Position of Edit Link
- linkColour: The colour of the link text
- editMessage: The text in the link
- margin: The number of pixels from the edges. This only applies if the outerPosition is set as fixed, which it is by default.
- zindex: The z-index
- umbracoEditContentUrl: The umbraco edit content link. If this changes, you can update it.
- fontSize: The font size of the link, in pixels.
- outerPosition: The position of the outer div. This allows you to do relative positioning.
- linkPosition: The position of the link. This allows you to do absolute position inside a relative div.
- outerClassName: This allows you to target the outer div in your own CSS.
- linkClassName: This allows you to target the link in your own CSS.


Here is an example with all settings:

```javascript
@Html.UmbracoEditLink(Model.Content, position: EditLinkPosition.TopLeft, linkColour: "#00aea2", editMessage: "Edit", margin: 10, zindex: 999, umbracoEditContentUrl: "/umbraco#/content/content/edit/", fontSize: 16, outerPosition: "fixed", linkPosition: "absolute", outerClassName: "edit-link-outer", linkClassName: "edit-link-inner")
```
