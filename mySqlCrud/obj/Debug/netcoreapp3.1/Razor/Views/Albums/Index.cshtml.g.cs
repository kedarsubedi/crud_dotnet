#pragma checksum "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7a6ce90f2478ead090da26e6a4052a089c2ceea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Index), @"mvc.1.0.view", @"/Views/Albums/Index.cshtml")]
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
#line 1 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\_ViewImports.cshtml"
using mySqlCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\_ViewImports.cshtml"
using mySqlCrud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a6ce90f2478ead090da26e6a4052a089c2ceea", @"/Views/Albums/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb6690f508a5cb08d8e29cca2c1e4cd159a8547", @"/Views/_ViewImports.cshtml")]
    public class Views_Albums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mySqlCrud.Models.Album>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Artist Name</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Genre</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 20 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml"
                       Write(Html.DisplayTextFor(modelitem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"row\">");
#nullable restore
#line 21 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml"
                       Write(Html.DisplayTextFor(modelitem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml"
           Write(Html.DisplayTextFor(modelitem => item.ArtistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml"
           Write(Html.DisplayTextFor(modelitem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml"
           Write(Html.DisplayTextFor(modelitem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\lenovo\source\repos\mySqlCrud\mySqlCrud\Views\Albums\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mySqlCrud.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591
