#pragma checksum "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9f811a5b6e9c2d5e5ad6077a9a0f020d791e7d5b4272f268cdc94852fed11387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9f811a5b6e9c2d5e5ad6077a9a0f020d791e7d5b4272f268cdc94852fed11387", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0a7e55f1d2a12e03855b1e3d809af37ceedb3b8c9e93a874863776ae765e4c6b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
            Write(
#nullable restore
#line 6 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
         await Component.InvokeAsync("Categories")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">                  \r\n");
#nullable restore
#line 10 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
             foreach (var product in Model.Products)
            {    

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
            Write(
#nullable restore
#line 13 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                     await Html.PartialAsync("_product", product)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("   \r\n                </div>       \r\n");
#nullable restore
#line 15 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
            }           

#line default
#line hidden
#nullable disable

            WriteLiteral("        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 23 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable

#nullable restore
#line 25 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                             if(String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 900, "\"", 964, 2);
            WriteAttributeValue("", 908, "page-item", 908, 9, true);
            WriteAttributeValue(" ", 917, 
#nullable restore
#line 27 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                                                       Model.PageInfo.CurrentPage==i+1?"active":""

#line default
#line hidden
#nullable disable
            , 918, 46, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1024, "\"", 1052, 2);
            WriteAttributeValue("", 1031, "/products?page=", 1031, 15, true);
            WriteAttributeValue("", 1046, 
#nullable restore
#line 28 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                                                                                i+1

#line default
#line hidden
#nullable disable
            , 1046, 6, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            Write(
#nullable restore
#line 29 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                                          i+1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                    </a>\r\n                                </li>  \r\n");
#nullable restore
#line 32 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1318, "\"", 1382, 2);
            WriteAttributeValue("", 1326, "page-item", 1326, 9, true);
            WriteAttributeValue(" ", 1335, 
#nullable restore
#line 35 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                                                       Model.PageInfo.CurrentPage==i+1?"active":""

#line default
#line hidden
#nullable disable
            , 1336, 46, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1442, "\"", 1502, 4);
            WriteAttributeValue("", 1449, "/products/", 1449, 10, true);
            WriteAttributeValue("", 1459, 
#nullable restore
#line 36 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                                                                          Model.PageInfo.CurrentCategory

#line default
#line hidden
#nullable disable
            , 1459, 31, false);
            WriteAttributeValue("", 1490, "?page=", 1490, 6, true);
            WriteAttributeValue("", 1496, 
#nullable restore
#line 36 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                                                                                                                i+1

#line default
#line hidden
#nullable disable
            , 1496, 6, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            Write(
#nullable restore
#line 37 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                                          i+1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                                    </a>\r\n                                </li> \r\n");
#nullable restore
#line 40 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable

#nullable restore
#line 40 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shop\List.cshtml"
                             

                                                   
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n                      \r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591