#pragma checksum "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84db121494193de11e10f53c8309ff98d82a94cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_detail), @"mvc.1.0.view", @"/Views/Home/detail.cshtml")]
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
#line 1 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\_ViewImports.cshtml"
using Lab11._3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\_ViewImports.cshtml"
using Lab11._3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84db121494193de11e10f53c8309ff98d82a94cc", @"/Views/Home/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1833681048c19863619a2f844d55e2b40dc7dc55", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\detail.cshtml"
  
    ViewData["Title"] = "detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"heading2\">Menu Item Detail</h1>\r\n<div>\r\n    <p class=\"details\">\r\n        Category: ");
#nullable restore
#line 9 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\detail.cshtml"
             Write(Model.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 11 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\detail.cshtml"
   Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $");
#nullable restore
#line 11 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\detail.cshtml"
                Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 13 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\detail.cshtml"
   Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        Item #");
#nullable restore
#line 15 "C:\Users\jpallone\dev\Lab11.3\Lab11.3\Views\Home\detail.cshtml"
         Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
