#pragma checksum "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "992a5277f25b260ca0478c75926fcdcf6bdfc732"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_SearchBuses), @"mvc.1.0.view", @"/Views/Customer/SearchBuses.cshtml")]
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
#line 1 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\_ViewImports.cshtml"
using OnlineBusTransportation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\_ViewImports.cshtml"
using OnlineBusTransportation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"992a5277f25b260ca0478c75926fcdcf6bdfc732", @"/Views/Customer/SearchBuses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8980418bbf9e98426c43cb47a62acd37e014d264", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_SearchBuses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineBusTransportation.Models.BusInfoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookSeat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Search Buses Result</h3>\r\n\r\n<table class=\"table\">\r\n\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayNameFor(model => model.BusNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayNameFor(model => model.BusCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Available Seats
            </th>

            <th>
                Booked Seats
            </th>
            <th>
                Departure datetime
            </th>
            <th>
                Book Ticket
            </th>
            <th>
                Booking
            </th>


        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 51 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayFor(modelItem => item.BusNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayFor(modelItem => item.BusCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayFor(modelItem => item.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayFor(modelItem => item.AvailableSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayFor(modelItem => item.BookedSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
           Write(Html.DisplayFor(modelItem => item.datetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "992a5277f25b260ca0478c75926fcdcf6bdfc7329853", async() => {
                WriteLiteral("Book Seat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-busid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
                                                                        WriteLiteral(item.BusID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["busid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-busid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["busid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
                                                                                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["businfoid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-businfoid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["businfoid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "992a5277f25b260ca0478c75926fcdcf6bdfc73213163", async() => {
                WriteLiteral("View Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-businfoid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
                                                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["businfoid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-businfoid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["businfoid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 90 "C:\Users\Zainab\source\repos\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\SearchBuses.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineBusTransportation.Models.BusInfoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
