#pragma checksum "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "192c8d5ae42fbd691d8a448102db2981c1b499e5e6344e1ddd5c69fe6bc8026f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Product.Pages_Shared_Components_Product_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Product/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Product
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"192c8d5ae42fbd691d8a448102db2981c1b499e5e6344e1ddd5c69fe6bc8026f", @"/Pages/Shared/Components/Product/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"84e67cc624686472d6ee628a8fd93a67c79f2978653a37fe57c229fa14270597", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_Components_Product_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_MasaiQuery.Contracts.ProductCategory.ProductCategoryQueryModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Theme/img/seller_1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 250px;height: 60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- ? Start Products -->\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"widget widget-product card border_all bglight\">\r\n            <header class=\"card-header\">\r\n                <h3 class=\"card-title\">\r\n                    <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "192c8d5ae42fbd691d8a448102db2981c1b499e5e6344e1ddd5c69fe6bc8026f5088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                </h3>\r\n            </header>\r\n            <div class=\"product-carousel owl-carousel owl-theme\">\r\n");
#nullable restore
#line 16 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                 foreach (var category in Model)
                {
                    if (category.Products == null)
                    {
                        continue;
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                         foreach (var product in category.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "192c8d5ae42fbd691d8a448102db2981c1b499e5e6344e1ddd5c69fe6bc8026f7185", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "192c8d5ae42fbd691d8a448102db2981c1b499e5e6344e1ddd5c69fe6bc8026f7500", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1064, "~/ProductPictures/", 1064, 18, true);
#nullable restore
#line 28 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
AddHtmlAttributeValue("", 1082, product.Picture, 1082, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
AddHtmlAttributeValue("", 1165, product.PictureAlt, 1165, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
AddHtmlAttributeValue("", 1193, product.PictureTitle, 1193, 21, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1262, "product-tab-", 1262, 12, true);
#nullable restore
#line 30 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
AddHtmlAttributeValue("", 1274, product.Id, 1274, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                                         WriteLiteral(product.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <h2 class=\"product_title\" style=\"text-align: center\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "192c8d5ae42fbd691d8a448102db2981c1b499e5e6344e1ddd5c69fe6bc8026f12798", async() => {
#nullable restore
#line 33 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                                                                   Write(product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                                             WriteLiteral(product.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </h2>\r\n                                <div class=\"price\">\r\n");
#nullable restore
#line 36 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                     if (product.HasDiscount)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <del><span>");
#nullable restore
#line 38 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                              Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>تومان</span></span></del>\r\n                                        <span class=\"discount_badge\">");
#nullable restore
#line 39 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                                                Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n");
            WriteLiteral("                                        <ins><span>");
#nullable restore
#line 41 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                              Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>تومان</span></span></ins>\r\n");
#nullable restore
#line 42 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <ins><span>");
#nullable restore
#line 45 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                              Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>تومان</span></span></ins>\r\n");
#nullable restore
#line 46 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 50 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\SourceCodes\@Masai-ECommerce\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                         
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <a href=\"#\" class=\"view_more\">مشاهده بیشتر  </a>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- ? End Products -->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_MasaiQuery.Contracts.ProductCategory.ProductCategoryQueryModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
