using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Final.Helpers
{
    public class CustomerSupportTagHelper : TagHelper
    {
        public string Email { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            output.Attributes.SetAttribute("href", "mailto:" + Email);

            output.Content.SetContent("Customer Support");
        }
    }
}