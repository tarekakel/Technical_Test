#pragma checksum "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe262d64a2b8c21fc9db099a4e4da077ade68f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\_ViewImports.cshtml"
using Technical_Test_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\_ViewImports.cshtml"
using Technical_Test_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe262d64a2b8c21fc9db099a4e4da077ade68f3", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a319a9ec5ea4351cbd5d5c8d6979686e1daa571", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Technical_Test_Project.Data.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
  
    ViewBag.Title = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div><b>Product</b><br /></div>\r\n<table class=\"table    table-hover\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.CurrentQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
       Write(Html.DisplayNameFor(x => x.PictureUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            Add To Cart\r\n        </th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
           Write(product.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
           Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
           Write(product.CurrentQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
           Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=", 1009, "", 1046, 1);
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
WriteAttributeValue("", 1014, Url.Content(product.PictureUrl), 1014, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 1046, "", 1064, 1);
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
WriteAttributeValue("", 1051, product.Name, 1051, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"75\" width=\"75\" /></td>\r\n            <td class=\"text-center\">\r\n\r\n                ");
#nullable restore
#line 43 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Add To Cart", "Index", "Cart", new { productId = product.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\ASUS\source\repos\Technical_Test_Project\Technical_Test_Project\Views\Product\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Technical_Test_Project.Data.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591