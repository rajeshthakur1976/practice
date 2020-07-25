using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corewebapp.TagHelpher
{
    public class AppreciateTagHealpher : TagHelperComponent
    {
        private
    const string appreciationText = "Great work";
        public string PersonName
        {
            get;
            set;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "Appreciation";
            var mes = appreciationText + "__" + PersonName;
            //string message = $ "{appreciationText},{PersonName}";
            var attribute = new TagHelperAttribute(name: "Label", value: mes);
            output.Attributes.Add(attribute);
            output.Content.SetContent(mes);

        }
    }
}
