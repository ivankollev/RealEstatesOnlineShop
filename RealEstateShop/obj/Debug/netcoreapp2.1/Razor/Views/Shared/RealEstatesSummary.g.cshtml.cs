#pragma checksum "C:\D\Projects\Development\ASP.NET\RealEstateShop\RealEstateShop\Views\Shared\RealEstatesSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41d810a928098681d039a78571ee950539ea0bf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_RealEstatesSummary), @"mvc.1.0.view", @"/Views/Shared/RealEstatesSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/RealEstatesSummary.cshtml", typeof(AspNetCore.Views_Shared_RealEstatesSummary))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\D\Projects\Development\ASP.NET\RealEstateShop\RealEstateShop\Views\_ViewImports.cshtml"
using RealEstateShop.ViewModels;

#line default
#line hidden
#line 2 "C:\D\Projects\Development\ASP.NET\RealEstateShop\RealEstateShop\Views\_ViewImports.cshtml"
using RealEstateShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d810a928098681d039a78571ee950539ea0bf8", @"/Views/Shared/RealEstatesSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d12d8b8d85659174f3426fb899c0f970ae6475", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_RealEstatesSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RealEstate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cartButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 85, true);
            WriteLiteral("\r\n<div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n    <div class=\"thumbnail\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 104, "\"", 134, 1);
#line 5 "C:\D\Projects\Development\ASP.NET\RealEstateShop\RealEstateShop\Views\Shared\RealEstatesSummary.cshtml"
WriteAttributeValue("", 110, Model.ImageThumbnailUrl, 110, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(135, 78, true);
            WriteLiteral(" alt=\"\" />\r\n        <div class=\"caption\">\r\n            <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(214, 25, false);
#line 7 "C:\D\Projects\Development\ASP.NET\RealEstateShop\RealEstateShop\Views\Shared\RealEstatesSummary.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(239, 44, true);
            WriteLiteral("</h3>\r\n            <h3>\r\n                <a>");
            EndContext();
            BeginContext(284, 22, false);
#line 9 "C:\D\Projects\Development\ASP.NET\RealEstateShop\RealEstateShop\Views\Shared\RealEstatesSummary.cshtml"
              Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(306, 40, true);
            WriteLiteral("</a>\r\n            </h3>\r\n            <p>");
            EndContext();
            BeginContext(347, 21, false);
#line 11 "C:\D\Projects\Development\ASP.NET\RealEstateShop\RealEstateShop\Views\Shared\RealEstatesSummary.cshtml"
          Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(368, 114, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"addToCart text-right\">\r\n            <p class=\"button\">\r\n                ");
            EndContext();
            BeginContext(482, 264, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbfed5b20444d8e8c2b1c27c53a2bce", async() => {
                BeginContext(691, 51, true);
                WriteLiteral("\r\n                    Add to cart\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-realEstateId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\D\Projects\Development\ASP.NET\RealEstateShop\RealEstateShop\Views\Shared\RealEstatesSummary.cshtml"
                               WriteLiteral(Model.RealEstateId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["realEstateId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-realEstateId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["realEstateId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(746, 54, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RealEstate> Html { get; private set; }
    }
}
#pragma warning restore 1591
