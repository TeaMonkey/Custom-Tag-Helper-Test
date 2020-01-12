using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Custom_Tag_Helper_Test.CustomTagHelpers
{
    public class anchorcustomTagHelper : TagHelper
    {
        public string jo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", jo);         //Will need to check and prepend / if needed
        }
    }

    public class anchorinheritTagHelper : AnchorTagHelper
    {
        public anchorinheritTagHelper(IHtmlGenerator htmlGenerator) : base(htmlGenerator) { }

        public string jo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = "a";
            output.Attributes.SetAttribute("title", jo);
        }
    }
}
