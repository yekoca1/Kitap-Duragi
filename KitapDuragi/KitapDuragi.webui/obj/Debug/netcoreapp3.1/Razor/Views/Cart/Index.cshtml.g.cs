#pragma checksum "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "990418faa24961a997d4b568f8062738489385958c04d4f2857e8695cc3d61ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\_ViewImports.cshtml"
using KitapDuragi.entity

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\_ViewImports.cshtml"
using KitapDuragi.webui.Models

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\_ViewImports.cshtml"
using KitapDuragi.webui.Extensions

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\_ViewImports.cshtml"
using KitapDuragi.webui.Identity

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"990418faa24961a997d4b568f8062738489385958c04d4f2857e8695cc3d61ef", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0a7e55f1d2a12e03855b1e3d809af37ceedb3b8c9e93a874863776ae765e4c6b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"h3\">Shopping Cart</h1>\r\n<hr>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
 if(Model.CartItems.Count==0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"alert alert-warning\">\r\n                Sepetinizde ürün yok.\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
}
else{

#line default
#line hidden
#nullable disable

            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""text-left"">
                <h4>Cart Items</h4>
            </div>
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th></th>
                        <th>Product Name</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Total</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 34 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                     foreach (var item in Model.CartItems)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "990418faa24961a997d4b568f8062738489385958c04d4f2857e8695cc3d61ef7441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1048, "~/img/", 1048, 6, true);
            AddHtmlAttributeValue("", 1054, 
#nullable restore
#line 38 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                                                 item.ImageUrl

#line default
#line hidden
#nullable disable
            , 1054, 14, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
            Write(
#nullable restore
#line 40 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                                 item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td>");
            Write(
#nullable restore
#line 41 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                                 item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td>");
            Write(
#nullable restore
#line 42 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                                 item.Quantity

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td>");
            Write(
#nullable restore
#line 43 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                                  item.Quantity*item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990418faa24961a997d4b568f8062738489385958c04d4f2857e8695cc3d61ef10555", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 1556, "\"", 1579, 1);
                WriteAttributeValue("", 1564, 
#nullable restore
#line 47 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                                                                                  item.ProductId

#line default
#line hidden
#nullable disable
                , 1564, 15, false);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">\r\n                                        <i class=\"fa fa-times fa-fw\"></i>\r\n                                    </button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-md-4"">
            <div class=""text-left"">
                <h4>Cart Summary</h4>
            </div>
            <table class=""table"">
                <tbody>
                    <tr>
                        <th>Cart Total</th>
                        <td>");
            Write(
#nullable restore
#line 66 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                             Model.TotalPrice().ToString("c")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th>Shipping</th>
                        <th>Free</th>
                    </tr>
                    <tr>
                        <th>Order Total</th>
                        <th>");
            Write(
#nullable restore
#line 74 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
                             Model.TotalPrice().ToString("c")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</th>
                    </tr>
                </tbody>
            </table>
            <div class=""text-center"">
                <a href=""/"" class=""btn btn-primary"">
                    <i class=""fa fa-arrow-circle-left fa-fw""></i> Alışverişe Devam Et
                </a>
                <a href=""/checkout"" class=""btn btn-primary"">
                    <i class=""fa fa-arrow-circle-right fa-fw""></i> Checkout
                </a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 88 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
