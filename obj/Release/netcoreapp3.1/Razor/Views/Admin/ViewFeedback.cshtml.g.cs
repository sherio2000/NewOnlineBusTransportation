#pragma checksum "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Admin\ViewFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "855b2b2065784255146679dfa5355ada3940cba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewFeedback), @"mvc.1.0.view", @"/Views/Admin/ViewFeedback.cshtml")]
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
#line 1 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\_ViewImports.cshtml"
using OnlineBusTransportation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\_ViewImports.cshtml"
using OnlineBusTransportation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"855b2b2065784255146679dfa5355ada3940cba5", @"/Views/Admin/ViewFeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8980418bbf9e98426c43cb47a62acd37e014d264", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UsersFeedback>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Admin\ViewFeedback.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>List of all Users Feedback</h1>




<table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Email
            </th>
            <th>
                Feedback
            </th>
          

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Admin\ViewFeedback.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Admin\ViewFeedback.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Admin\ViewFeedback.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Admin\ViewFeedback.cshtml"
               Write(Html.DisplayFor(modelItem => item.Feedback));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Admin\ViewFeedback.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UsersFeedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591
