#pragma checksum "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shared\_navbar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1104cacae955aa5011ae5e6701f127ac9210bfa9fb4032fc8969cec104fc4342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1104cacae955aa5011ae5e6701f127ac9210bfa9fb4032fc8969cec104fc4342", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0a7e55f1d2a12e03855b1e3d809af37ceedb3b8c9e93a874863776ae765e4c6b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <div class=""navbar bg-danger navbar-dark navbar-expand-sm"">
        <div class=""container"">
            <a href=""/"" class=""navbar-brand"">KitapDuragi</a>
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item"">
                    <a href=""/products"" class=""nav-link"">Products</a>
                </li>

");
#nullable restore
#line 9 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shared\_navbar.cshtml"
                 if(User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                    <li class=""nav-item"">
                        <a href=""/cart"" class=""nav-link"">Cart</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/orders"" class=""nav-link"">Orders</a>
                    </li>                        
");
#nullable restore
#line 17 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shared\_navbar.cshtml"

                    if(User.IsInRole("admin"))
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                         <li class=""nav-item"">
                        <a href=""/admin/products"" class=""nav-link"">Admin Products</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/categories"" class=""nav-link"">Admin Categories</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/role/list"" class=""nav-link"">Roles</a>
                        </li>
                         <li class=""nav-item"">
                            <a href=""/admin/user/list"" class=""nav-link"">Users</a>
                        </li>
");
#nullable restore
#line 32 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shared\_navbar.cshtml"
                    }                      
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </ul>\r\n\r\n             <ul class=\"navbar-nav ml-auto\">\r\n\r\n");
#nullable restore
#line 38 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shared\_navbar.cshtml"
                 if(User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a href=\"/account/manage\" class=\"nav-link\">\r\n                            ");
            Write(
#nullable restore
#line 42 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shared\_navbar.cshtml"
                             User.Identity.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a href=\"/account/logout\" class=\"nav-link\">Logout</a>\r\n                    </li>\r\n");
#nullable restore
#line 48 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shared\_navbar.cshtml"
                }
                else
                {                    

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                    <li class=""nav-item"">
                        <a href=""/account/login"" class=""nav-link"">Login</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/account/register"" class=""nav-link"">Register</a>
                    </li>    
");
#nullable restore
#line 57 "C:\Users\yunus\Desktop\KitapDuragi\KitapDuragi.webui\Views\Shared\_navbar.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </ul>\r\n\r\n\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591