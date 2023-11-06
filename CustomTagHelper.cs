using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;

public class ItemLinkTagHelper : TagHelper
{
    public string ControllerName { get; set; }
    public string ActionName { get; set; }
    public int ItemId { get; set; }
    public string DisplayText { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        // Generate the link URL.
        string url = UrlHelper.GenerateUrl(ControllerName, ActionName, new { id = ItemId });

        // Set the TagHelperOutput properties.
        output.TagName = "a";
        output.Attributes.SetAttribute("href", url);
        output.Content.SetContent(DisplayText);
    }
}
