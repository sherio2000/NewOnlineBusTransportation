#pragma checksum "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd59e2ca914cb5593461232fd6d9ebbc2e8118ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_BookSeat), @"mvc.1.0.view", @"/Views/Customer/BookSeat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd59e2ca914cb5593461232fd6d9ebbc2e8118ca", @"/Views/Customer/BookSeat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8980418bbf9e98426c43cb47a62acd37e014d264", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_BookSeat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeatBooking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmbooking"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    .seatSelection {
        text-align: center;
        padding: 5px;
        margin: 15px;
    }

    .seatsReceipt {
        text-align: center;
    }

    .seatNumber {
        display: inline;
        padding: 10px;
        background-color: #5c86eb;
        color: #FFF;
        border-radius: 5px;
        cursor: default;
        height: 25px;
        width: 25px;
        line-height: 60px;
        text-align: center;
    }

    .seatRow {
        padding: 10px;
    }

    .seatSelected {
        background-color: lightgreen;
        color: black;
    }

    .seatUnavailable {
        background-color: red;
    }

    .seatRowNumber {
        clear: none;
        display: inline;
    }

    .hidden {
        display: none;
    }

    .seatsAmount {
        max-width: 2em;
    }
</style>

<h3>Book your seat</h3>
<br />
<h4 style=""color:green;""><label style=""font-weight:bold;"">Bus Name:</label> ");
#nullable restore
#line 60 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                       Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || <label style=\"font-weight:bold;\">Bus Number:</label> ");
#nullable restore
#line 60 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                 Write(TempData["BusNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || <label style=\"font-weight:bold;\">Departure:</label> ");
#nullable restore
#line 60 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                                                                               Write(TempData["Departure"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || <label style=\"font-weight:bold;\">Destination:</label> ");
#nullable restore
#line 60 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                                                                                                                                                               Write(TempData["Destination"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || <label style=\"font-weight:bold;\">Departure Time:</label> ");
#nullable restore
#line 60 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                    Write(TempData["DepartureTime"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd59e2ca914cb5593461232fd6d9ebbc2e8118ca8175", async() => {
                WriteLiteral("\r\n    <input name=\"businfoid\" id=\"businfoid\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=", 1557, "", 1586, 1);
#nullable restore
#line 63 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 1564, TempData["BusInfoID"], 1564, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <div class=""seatSelection col-lg-12"">
        <p class=""seatSection"">

                <p style=""color:red;"">Red highlighted seats are already booked/Not available due to COVID-19</p><br />
            You can book your seats accordingly and proceed to check out.
        </p>

        <div class=""seatsChart col-lg-6"">
            <div class=""seatRow"">
                <div class=""seatRowNumber"">
                    Row 1
                </div>
");
#nullable restore
#line 76 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                 foreach (var item in Model.Row1)
                {
                    if (item.SeatNumber == 4)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 2222, "", 2238, 1);
#nullable restore
#line 80 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 2226, item.SeatID, 2226, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:30px;\"");
                BeginWriteAttribute("title", " title=\"", 2264, "\"", 2272, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 2352, "\"", 2388, 2);
                WriteAttributeValue(" ", 2360, "seatNumber", 2361, 11, true);
#nullable restore
#line 80 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 2371, item.SeatStatus, 2372, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 80 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                                               Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 81 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"

                    }
                    else
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 2518, "", 2534, 1);
#nullable restore
#line 86 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 2522, item.SeatID, 2522, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2534, "\"", 2542, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 2622, "\"", 2658, 2);
                WriteAttributeValue(" ", 2630, "seatNumber", 2631, 11, true);
#nullable restore
#line 86 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 2641, item.SeatStatus, 2642, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 86 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                     Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 87 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("               \r\n            </div>\r\n            <div class=\"seatRow\">\r\n                <div class=\"seatRowNumber\">\r\n                    Row 2\r\n                </div>\r\n");
#nullable restore
#line 95 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                 foreach (var item in Model.Row2)
                {
                    if (item.SeatNumber == 9)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 3062, "", 3078, 1);
#nullable restore
#line 99 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 3066, item.SeatID, 3066, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:30px;\"");
                BeginWriteAttribute("title", " title=\"", 3104, "\"", 3112, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 3192, "\"", 3228, 2);
                WriteAttributeValue(" ", 3200, "seatNumber", 3201, 11, true);
#nullable restore
#line 99 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 3211, item.SeatStatus, 3212, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 99 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                                               Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 100 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"

                    }
                    else
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 3358, "", 3374, 1);
#nullable restore
#line 105 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 3362, item.SeatID, 3362, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3374, "\"", 3382, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 3462, "\"", 3498, 2);
                WriteAttributeValue(" ", 3470, "seatNumber", 3471, 11, true);
#nullable restore
#line 105 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 3481, item.SeatStatus, 3482, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 105 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                     Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 106 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("              \r\n            </div>\r\n\r\n\r\n            <div class=\"seatRow\">\r\n                <div class=\"seatRowNumber\">\r\n                    Row 3\r\n                </div>\r\n");
#nullable restore
#line 116 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                 foreach (var item in Model.Row3)
                {
                    if (item.SeatNumber == 14)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 3906, "", 3922, 1);
#nullable restore
#line 120 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 3910, item.SeatID, 3910, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:30px;\"");
                BeginWriteAttribute("title", " title=\"", 3948, "\"", 3956, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 4036, "\"", 4072, 2);
                WriteAttributeValue(" ", 4044, "seatNumber", 4045, 11, true);
#nullable restore
#line 120 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 4055, item.SeatStatus, 4056, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 120 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                                               Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 121 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"

                    }
                    else
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 4202, "", 4218, 1);
#nullable restore
#line 126 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 4206, item.SeatID, 4206, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4218, "\"", 4226, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 4306, "\"", 4342, 2);
                WriteAttributeValue(" ", 4314, "seatNumber", 4315, 11, true);
#nullable restore
#line 126 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 4325, item.SeatStatus, 4326, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 126 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                     Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 127 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("              \r\n            </div>\r\n\r\n            <div class=\"seatRow\">\r\n                <div class=\"seatRowNumber\">\r\n                    Row 4\r\n                </div>\r\n");
#nullable restore
#line 136 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                 foreach (var item in Model.Row4)
                {
                    if (item.SeatNumber == 19)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 4748, "", 4764, 1);
#nullable restore
#line 140 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 4752, item.SeatID, 4752, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:30px;\"");
                BeginWriteAttribute("title", " title=\"", 4790, "\"", 4798, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 4878, "\"", 4914, 2);
                WriteAttributeValue(" ", 4886, "seatNumber", 4887, 11, true);
#nullable restore
#line 140 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 4897, item.SeatStatus, 4898, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 140 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                                               Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 141 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"

                    }
                    else
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 5044, "", 5060, 1);
#nullable restore
#line 146 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 5048, item.SeatID, 5048, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 5060, "\"", 5068, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 5148, "\"", 5184, 2);
                WriteAttributeValue(" ", 5156, "seatNumber", 5157, 11, true);
#nullable restore
#line 146 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 5167, item.SeatStatus, 5168, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 146 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                     Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 147 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("              \r\n            </div>\r\n\r\n\r\n            <div class=\"seatRow\">\r\n                <div class=\"seatRowNumber\">\r\n                    Row 5\r\n                </div>\r\n");
#nullable restore
#line 157 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                 foreach (var item in Model.Row5)
                {
                    if (item.SeatNumber == 24)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 5592, "", 5608, 1);
#nullable restore
#line 161 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 5596, item.SeatID, 5596, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:30px;\"");
                BeginWriteAttribute("title", " title=\"", 5634, "\"", 5642, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 5722, "\"", 5758, 2);
                WriteAttributeValue(" ", 5730, "seatNumber", 5731, 11, true);
#nullable restore
#line 161 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 5741, item.SeatStatus, 5742, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 161 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                                               Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 162 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"

                    }
                    else
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 5888, "", 5904, 1);
#nullable restore
#line 167 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue("", 5892, item.SeatID, 5892, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 5904, "\"", 5912, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"checkbox\" value=\"10\" aria-checked=\"false\" focusable=\"true\" tabindex=\"-1\"");
                BeginWriteAttribute("class", " class=\"", 5992, "\"", 6028, 2);
                WriteAttributeValue(" ", 6000, "seatNumber", 6001, 11, true);
#nullable restore
#line 167 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
WriteAttributeValue(" ", 6011, item.SeatStatus, 6012, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 167 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                                                                                                                                                                     Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 168 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Customer\BookSeat.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"               
            </div>
        </div>

        <div class=""seatsReceipt col-lg-2"">
            <p><strong>Selected Seats: <span class=""seatsAmount"" />0 </span></strong> <button id=""btnClear"" class=""btn"">Clear</button></p>
            <ul id=""seatsList"" name=""seatsList"" class=""nav nav-stacked"">
            </ul>
        </div>
    </div>
   
    <div class=""checkout col-lg-offset-6"">
        <span>Subtotal: CA$</span><span class=""txtSubTotal""  >0.00</span><br />
        <button id=""btnCheckout"" type=""submit"" disabled name=""btnCheckout"" class=""btn btn-primary"">
            Check out & Confirm Booking
        </button>

    </div>
    <div id=""fields"">
        <input type=""hidden"" id=""price"" name=""price"" />
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    // Clicking any seat
    $("".seatNumber"").click(
        function () {
            
           
            if (!$(this).hasClass(""seatUnavailable"")) {
                // If selected, unselect it
                if ($(this).hasClass(""seatSelected"")) {
                    var thisId = $(this).attr('id');
                    var price = $('#seatsList .' + thisId).val();
                    $(this).removeClass(""seatSelected"");
                    $('#seatsList .' + thisId).remove();
                    // Calling functions to update checkout total and seat counter.
                    removeFromCheckout(price);
                    refreshCounter();
                    var elem = document.getElementById(""txt"" + thisId);

                    elem.parentNode.removeChild(elem);


                }
                else {
                    // else, select it
                    // getting values from Seat
                    var thisId = $(this).attr('id');
                  ");
            WriteLiteral(@"  var id = thisId.split(""_"");
                    var price = $(this).attr('value');
                    var seatDetails = ""Row: "" + id[0] + "" Seat:"" + id[1] + "" Price:CA$:"" + price;

                    var freeSeats = parseInt($('.freeSeats').first().text());
                    var selectedSeats = parseInt($("".seatSelected"").length);

                    // If you have free seats available the price of this one will be 0.
                    if (selectedSeats < freeSeats) {
                        price = 0;
                    }

                    // Adding this seat to the list
                    var seatDetails = ""Row: "" + id[0] + "" Seat:"" + id[1] + "" Price:CA$:"" + price;
                    $(""#seatsList"").append('<li value=' + price + ' class=' + thisId + '>' + seatDetails + ""  "" + ""<button id='remove:"" + thisId + ""'+ class='btn btn-default btn-sm removeSeat' value='"" + price + ""'><strong>X</strong></button></li>"");
                    var input = document.createElement(""input"");

");
            WriteLiteral(@"                    input.setAttribute(""type"", ""hidden"");

                    input.setAttribute(""name"", thisId);
                    input.setAttribute(""id"", ""txt"" + thisId);


                    input.setAttribute(""value"", id[1]);

                    //append to form element that you want .
                    document.getElementById(""fields"").appendChild(input);


                    $(this).addClass(""seatSelected"");

                    addToCheckout(price);
                    refreshCounter();
                }
            }
        }
    );
    // Clicking any of the dynamically-generated X buttons on the list
    $(document).on('click', "".removeSeat"", function () {
        // Getting the Id of the Seat
        var id = $(this).attr('id').split("":"");
        var price = $(this).attr('value')
        $('#seatsList .' + id[1]).remove();
        $(""#"" + id[1] + "".seatNumber"").removeClass(""seatSelected"");
        removeFromCheckout(price);
        refreshCounter();
    }
  ");
            WriteLiteral(@"  );
    // Show tooltip on hover.
    $("".seatNumber"").hover(
        function () {
            if (!$(this).hasClass(""seatUnavailable"")) {
                var id = $(this).attr('id');
                var id = id.split(""_"");
                var price = $(this).attr('value');
                var tooltip = ""Row: "" + id[0] + "" Seat:"" + id[1] + "" Price:CA$:"" + price;

                $(this).prop('title', tooltip);
            } else {
                $(this).prop('title', ""Seat unavailable"");
            }
        }
    );
    // Function to refresh seats counter
    function refreshCounter() {
        $("".seatsAmount"").text($("".seatSelected"").length);
    }
    // Add seat to checkout
    function addToCheckout(thisSeat) {
        var seatPrice = parseInt(thisSeat);
        var num = parseInt($('.txtSubTotal').text());
        num += seatPrice;
        num = num.toString();
        $('.txtSubTotal').text(num);
        document.getElementById(""price"").value = num;
        var priceVa");
            WriteLiteral(@"lue = document.getElementsByClassName('txtSubTotal')[0].innerHTML;
        if (priceValue != 0.00 && priceValue != 0) {
            document.getElementById(""btnCheckout"").disabled = false;
        }
        else {
            document.getElementById(""btnCheckout"").disabled = true;

        }
    }
    // Remove seat from checkout
    function removeFromCheckout(thisSeat) {
        var seatPrice = parseInt(thisSeat);
        var num = parseInt($('.txtSubTotal').text());
        num -= seatPrice;
        num = num.toString();
        $('.txtSubTotal').text(num);
        document.getElementById(""price"").value = num;
        var priceValue = document.getElementsByClassName('txtSubTotal')[0].innerHTML;
        if (priceValue != 0.00 && priceValue != 0) {
            document.getElementById(""btnCheckout"").disabled = false;
        }
        else {
            document.getElementById(""btnCheckout"").disabled = true;

        }

    }

    // Clear seats.
    $(""#btnClear"").click(
       ");
            WriteLiteral(@" function () {
            $('.txtSubTotal').text(0);
            $("".seatsAmount"").text(0);
            $('.seatSelected').removeClass('seatSelected');
            $('#seatsList li').remove();
            document.getElementById(""price"").value = 0;
            var priceValue = document.getElementsByClassName('txtSubTotal')[0].innerHTML;
            if (priceValue != 0.00 && priceValue != 0) {
                document.getElementById(""btnCheckout"").disabled = false;
            }
            else {
                document.getElementById(""btnCheckout"").disabled = true;

            }

        }
    );
    
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeatBooking> Html { get; private set; }
    }
}
#pragma warning restore 1591
