#pragma checksum "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39b5f82953280366bbddf7f17f5a384885bd300f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buses_ShowRoutes), @"mvc.1.0.view", @"/Views/Buses/ShowRoutes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39b5f82953280366bbddf7f17f5a384885bd300f", @"/Views/Buses/ShowRoutes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8980418bbf9e98426c43cb47a62acd37e014d264", @"/Views/_ViewImports.cshtml")]
    public class Views_Buses_ShowRoutes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineBusTransportation.Models.BusInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RouteDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Routes Information(Bus Name: ");
#nullable restore
#line 8 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
                            Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & Bus Number: ");
#nullable restore
#line 8 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
                                                            Write(TempData["BusNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h3>\r\n\r\n<p>\r\n    <button type=\"button\" style=\"float:right;\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 324, "\"", 413, 5);
            WriteAttributeValue("", 334, "location.href", 334, 13, true);
            WriteAttributeValue(" ", 347, "=", 348, 2, true);
            WriteAttributeValue(" ", 349, "\'", 350, 2, true);
#nullable restore
#line 11 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
WriteAttributeValue("", 351, Url.Action("AddRoute", "Buses", new { id = TempData["ID"]}), 351, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 411, "\';", 411, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Add New Route</button>\r\n    &nbsp;\r\n    &nbsp;\r\n\r\n    <button type=\"button\" style=\"margin-right:1%;float:right;\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 551, "\"", 608, 5);
            WriteAttributeValue("", 561, "location.href", 561, 13, true);
            WriteAttributeValue(" ", 574, "=", 575, 2, true);
            WriteAttributeValue(" ", 576, "\'", 577, 2, true);
#nullable restore
#line 15 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
WriteAttributeValue("", 578, Url.Action("Index", "Buses"), 578, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 607, "\'", 607, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Show Buses</button>\r\n\r\n");
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayNameFor(model => model.datetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayNameFor(model => model.availableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayNameFor(model => model.BookedSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>Update Information</th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayFor(modelItem => item.datetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayFor(modelItem => item.availableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
           Write(Html.DisplayFor(modelItem => item.BookedSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39b5f82953280366bbddf7f17f5a384885bd300f10412", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
                                            WriteLiteral(item.ID);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39b5f82953280366bbddf7f17f5a384885bd300f12609", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
                                              WriteLiteral(item.ID);

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
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Buses\ShowRoutes.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineBusTransportation.Models.BusInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591