#pragma checksum "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f914599127f00dd4d7b8cb7a85e456fcdbbb865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
using OnlineBusTransportation.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f914599127f00dd4d7b8cb7a85e456fcdbbb865", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8980418bbf9e98426c43cb47a62acd37e014d264", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Departure", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Departure"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "destination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("destination"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchBuses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/5.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/map1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_LayoutWebsite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <h3>Welcome ");
#nullable restore
#line 16 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
               Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h3>\r\n        <br />\r\n        <br />\r\n");
#nullable restore
#line 19 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-5 bann-info1 wow fadeInLeft animated"" data-wow-delay="".5s"">
            <i class=""fa fa-columns""></i>
            <h3>WORLD'S MOST TRAVEL BRAND</h3>
        </div>
        <div class=""col-md-7 bann-info wow fadeInRight animated"" data-wow-delay="".5s"">

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f914599127f00dd4d7b8cb7a85e456fcdbbb8659858", async() => {
                WriteLiteral(@"

                <h2>Online Tickets with Zero Booking Fees</h2>
                <div class=""ban-top"">
                    <div class=""bnr-left"">
                        <label class=""inputLabel"">Departure</label>
                       
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f914599127f00dd4d7b8cb7a85e456fcdbbb86510388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 35 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Departure;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    </div>\r\n                    <div class=\"bnr-left\">\r\n\r\n                        <label class=\"inputLabel\">Destination</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f914599127f00dd4d7b8cb7a85e456fcdbbb86512414", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 41 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Destination;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    </div>
                    <div class=""clearfix""></div>
                </div>
                <div class=""ban-bottom"">
                    <div class=""bnr-right"">
                        <label class=""inputLabel"">Date of Journey</label>
                        <input class=""form-control"" id=""datepicker"" name=""datepicker"" type=""datetime-local""  />

                        
");
                WriteLiteral(@"                    </div>
                    <div class=""clearfix""></div>
                    <!---start-date-piker---->
                    <link rel=""stylesheet"" href=""css/jquery-ui.css"" />
                    <script src=""js/jquery-ui.js""></script>
                    <script>
                        $(function () {
                            $(""#datepicker,#datepicker1"").datepicker({ dateFormat: 'dd/mm/yy' }).val();
                        });</script>
                    <!---/End-date-piker---->
                </div>
                <div class=""sear"">
                    <button class=""seabtn"" type=""submit"">Search Buses</button>
                </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n");
#nullable restore
#line 71 "C:\Users\lenovo\Desktop\new\OnlineBusTransportation\OnlineBusTransportation\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""clearfix""></div>
</div>
<!---728x90--->
<!--- /banner ---->
<!--- rupes ---->
<div class=""container"">
    <div class=""rupes"">
        <div class=""col-md-4 rupes-left wow fadeInDown animated animated"" data-wow-delay="".5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: fadeInDown;"">
            <div class=""rup-left"">
                <a href=""offers.html""><i class=""fa fa-usd""></i></a>
            </div>
            <div class=""rup-rgt"">
                <h3>UP TO USD. 50 OFF</h3>
                <h4><a href=""offers.html"">TRAVEL SMART</a></h4>
                <p>CODE:YBMAR12<br>Book Using Pay Money</p>
            </div>
            <div class=""clearfix""></div>
        </div>
        <div class=""col-md-4 rupes-left wow fadeInDown animated animated"" data-wow-delay="".5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: fadeInDown;"">
            <div class=""rup-left"">
                <a href=""offers.html""><i class=""fa fa-h-square""></i></a>
   ");
            WriteLiteral(@"         </div>
            <div class=""rup-rgt"">
                <h3>UP TO 70% OFF</h3>
                <h4><a href=""offers.html"">ON HOTELS ACROSS WORLD</a></h4>
                <p>Offer CODE:YBMAR12</p>
            </div>
            <div class=""clearfix""></div>
        </div>
        <div class=""col-md-4 rupes-left wow fadeInDown animated animated"" data-wow-delay="".5s"" style=""visibility: visible; animation-delay: 0.5s; animation-name: fadeInDown;"">
            <div class=""rup-left"">
                <a href=""offers.html""><i class=""fa fa-mobile""></i></a>
            </div>
            <div class=""rup-rgt"">
                <h3>FLAT USD. 50 OFF</h3>
                <h4><a href=""offers.html"">BUS APP OFFER</a></h4>
                <p>book via the yellow Bus App<br>CODE:YBMAR12</p>
            </div>
            <div class=""clearfix""></div>
        </div>
        <div class=""clearfix""></div>
    </div>
</div>
<!---728x90--->
<!--- /rupes ---->
<!---holiday---->
<div class=""container"">
  ");
            WriteLiteral(@"  <div class=""holiday"">
        <div class=""col-md-3 holiday-left animated wow fadeInUp animated"" data-wow-duration=""1200ms"" data-wow-delay=""500ms"" style=""visibility: visible; animation-duration: 1200ms; animation-delay: 500ms; animation-name: fadeInUp;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f914599127f00dd4d7b8cb7a85e456fcdbbb86519704", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-md-6 holiday-mid animated wow fadeInUp animated"" data-wow-duration=""1200ms"" data-wow-delay=""500ms"" style=""visibility: visible; animation-duration: 1200ms; animation-delay: 500ms; animation-name: fadeInUp;"">
            <h3>Travel Holiday Packages</h3>
            <p>Private Guide and Driver in any language and in any departure date. For more information please contact us....</p>
        </div>
        <div class=""col-md-3 holiday-left animated wow fadeInUp animated"" data-wow-duration=""1200ms"" data-wow-delay=""500ms"" style=""visibility: visible; animation-duration: 1200ms; animation-delay: 500ms; animation-name: fadeInUp;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f914599127f00dd4d7b8cb7a85e456fcdbbb86521604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""clearfix""></div>
    </div>
</div>
<!---/holiday---->
<!---track---->
<div class=""container"">
    <div class=""track"">
        <div class=""col-md-6 track-right wow fadeInLeft animated"" data-wow-delay="".5s"">
            <a href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f914599127f00dd4d7b8cb7a85e456fcdbbb86523089", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
        </div>
        <div class=""col-md-6 track-left wow fadeInRight animated"" data-wow-delay="".5s"">
            <h3>TRACK MY BUS</h3>
            <p>First of its own kind,bus tracking feature on bus</p>
            <a href=""#"" class=""learn"">Learn More</a>
        </div>
        <div class=""clearfix""></div>
    </div>
</div>
<!--- /track ---->
<!--- routes ---->
<div class=""routes"">
    <div class=""container"">
        <div class=""col-md-4 routes-left wow fadeInRight animated"" data-wow-delay="".5s"">
            <div class=""rou-left"">
                <a href=""#""><i class=""fa fa-truck""></i></a>
            </div>
            <div class=""rou-rgt wow fadeInDown animated"" data-wow-delay="".5s"">
                <h3>80000</h3>
                <p>ROUTES</p>
            </div>
            <div class=""clearfix""></div>
        </div>
        <div class=""col-md-4 routes-left"">
            <div class=""rou-left"">
                <a href=""#""><i class=""fa fa-user""></i></a>
            </div>
 ");
            WriteLiteral(@"           <div class=""rou-rgt"">
                <h3>1900</h3>
                <p>BUS OPERATORS</p>
            </div>
            <div class=""clearfix""></div>
        </div>
        <div class=""col-md-4 routes-left wow fadeInRight animated"" data-wow-delay="".5s"">
            <div class=""rou-left"">
                <a href=""#""><i class=""fa fa-ticket""></i></a>
            </div>
            <div class=""rou-rgt"">
                <h3>7,00,00,000+</h3>
                <p>TICKETS SOLD</p>
            </div>
            <div class=""clearfix""></div>
        </div>
        <div class=""clearfix""></div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
