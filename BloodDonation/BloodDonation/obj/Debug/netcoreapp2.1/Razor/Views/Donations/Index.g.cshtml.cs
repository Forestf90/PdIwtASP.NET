#pragma checksum "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6145b5747f86328590c1c021b542025d08ea524a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donations_Index), @"mvc.1.0.view", @"/Views/Donations/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Donations/Index.cshtml", typeof(AspNetCore.Views_Donations_Index))]
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
#line 1 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\_ViewImports.cshtml"
using BloodDonation;

#line default
#line hidden
#line 2 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\_ViewImports.cshtml"
using BloodDonation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6145b5747f86328590c1c021b542025d08ea524a", @"/Views/Donations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d02fe340e584005e243888edbd99a0fa874c62ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Donations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BloodDonation.PagedLists.DonationPagedList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-itemsOnPage", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-itemsOnPage", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-itemsOnPage", "15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-itemsOnPage", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 37, true);
            WriteLiteral("\r\n<h2>Lista donacji</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd3a20fd159642859d758f02497fa3c1", async() => {
                BeginContext(154, 13, true);
                WriteLiteral("Dodaj donacje");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(171, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(182, 69, false);
#line 13 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
Write(await Component.InvokeAsync("Donation", new { donationList = Model }));

#line default
#line hidden
            EndContext();
            BeginContext(251, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 15 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
  
    var prevDisabled = Model.CurrentPage < 2 ? "disabled" : "";
    var nextDisabled = Model.CurrentPage == Model.TotalPages ? "disabled" : "";

    int startI = Model.CurrentPage - 5;
    //int itemsOnPage = 10;

#line default
#line hidden
            BeginContext(480, 140, true);
            WriteLiteral("\r\n\r\n\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n        <li class=\"page-item\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 620, "\"", 704, 1);
#line 28 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
WriteAttributeValue("", 627, Url.Action("Index", new { page = Model.CurrentPage - 1 ,Model.ItemsOnPage }), 627, 77, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n               class=\"", 705, "\"", 758, 3);
            WriteAttributeValue("", 729, "btn", 729, 3, true);
            WriteAttributeValue(" ", 732, "btn-default", 733, 12, true);
#line 29 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
WriteAttributeValue(" ", 744, prevDisabled, 745, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(759, 62, true);
            WriteLiteral(">\r\n                Previous\r\n            </a>\r\n        </li>\r\n");
            EndContext();
#line 33 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
         if (startI < 2)
        {
            startI = 1;
        }
        else
        {

#line default
#line hidden
            BeginContext(919, 54, true);
            WriteLiteral("            <li class=\"page-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 973, "\"", 1037, 1);
#line 40 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
WriteAttributeValue("", 980, Url.Action("Index", new { page = 1 ,Model.ItemsOnPage }), 980, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1038, 59, true);
            WriteLiteral(" class=\"page-link\" tabindex=\"-1\">1</a>\r\n            </li>\r\n");
            EndContext();
#line 42 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
             if (Model.CurrentPage > 7)
            {


#line default
#line hidden
            BeginContext(1155, 145, true);
            WriteLiteral("                <li class=\"page-item disabled\">\r\n                    <a class=\"page-link\" href=\"#\" tabindex=\"-1\">...</a>\r\n                </li>\r\n");
            EndContext();
#line 48 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"

            }

#line default
#line hidden
#line 49 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
             

        }

#line default
#line hidden
            BeginContext(1330, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 52 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
         for (int i = startI; i <= Model.TotalPages; i++)
        {
            if (Model.CurrentPage == i)
            {

#line default
#line hidden
            BeginContext(1456, 65, true);
            WriteLiteral("                <li class=\"page-item active\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1521, "\"", 1584, 1);
#line 56 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
WriteAttributeValue("", 1528, Url.Action("Index", new { page = i ,Model.ItemsOnPage}), 1528, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1585, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1587, 1, false);
#line 56 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
                                                                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 57 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
            }
            else if (i == startI + 11)
            {
                

#line default
#line hidden
#line 60 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
                 if (Model.TotalPages - Model.CurrentPage > 6)
                {


#line default
#line hidden
            BeginContext(1754, 157, true);
            WriteLiteral("                    <li class=\"page-item disabled\">\r\n                        <a class=\"page-link\" href=\"#\" tabindex=\"-1\">...</a>\r\n                    </li>\r\n");
            EndContext();
#line 66 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"

                }

#line default
#line hidden
#line 67 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
                 
                if (startI + 10 < Model.TotalPages)
                {

#line default
#line hidden
            BeginContext(2004, 71, true);
            WriteLiteral("                    <li class=\"page-item \">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2075, "\"", 2155, 1);
#line 71 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
WriteAttributeValue("", 2082, Url.Action("Index", new { page = Model.TotalPages  ,Model.ItemsOnPage }), 2082, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2156, 33, true);
            WriteLiteral(" class=\"page-link\" tabindex=\"-1\">");
            EndContext();
            BeginContext(2190, 16, false);
#line 71 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
                                                                                                                                       Write(Model.TotalPages);

#line default
#line hidden
            EndContext();
            BeginContext(2206, 33, true);
            WriteLiteral("</a>\r\n                    </li>\r\n");
            EndContext();
#line 73 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
                }

                break;
            }
            else
            {

#line default
#line hidden
            BeginContext(2332, 58, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2390, "\"", 2454, 1);
#line 79 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
WriteAttributeValue("", 2397, Url.Action("Index", new { page = i ,Model.ItemsOnPage }), 2397, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2455, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2457, 1, false);
#line 79 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2458, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 80 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2495, 46, true);
            WriteLiteral("        <li class=\"page-item\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2541, "\"", 2625, 1);
#line 83 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
WriteAttributeValue("", 2548, Url.Action("Index", new { page = Model.CurrentPage + 1 ,Model.ItemsOnPage }), 2548, 77, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n               class=\"", 2626, "\"", 2679, 3);
            WriteAttributeValue("", 2650, "btn", 2650, 3, true);
            WriteAttributeValue(" ", 2653, "btn-default", 2654, 12, true);
#line 84 "C:\Users\Forestf\Desktop\ASPdotNET\BloodDonation\BloodDonation\Views\Donations\Index.cshtml"
WriteAttributeValue(" ", 2665, nextDisabled, 2666, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2680, 376, true);
            WriteLiteral(@">
                Next
            </a>
        </li>
    </ul>
</nav>

<!-- Single button -->
<div class=""btn-group"">
    <button type=""button"" class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        Donations on page <span class=""caret""></span>
    </button>
    <ul class=""dropdown-menu"">
        <li>");
            EndContext();
            BeginContext(3056, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e28495acfed4b29b74e5caf60270f86", async() => {
                BeginContext(3104, 1, true);
                WriteLiteral("5");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemsOnPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemsOnPage"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3109, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(3128, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5473ef83c6e4daf8645a09bcad5ea92", async() => {
                BeginContext(3177, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemsOnPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemsOnPage"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3183, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(3202, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01acc70eaeba475b828c0068867bf487", async() => {
                BeginContext(3251, 2, true);
                WriteLiteral("15");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemsOnPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemsOnPage"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3257, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(3276, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8e5394afcf428bbd642312fbbc4af9", async() => {
                BeginContext(3325, 2, true);
                WriteLiteral("20");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemsOnPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemsOnPage"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3331, 26, true);
            WriteLiteral("</li>\r\n    </ul>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BloodDonation.PagedLists.DonationPagedList> Html { get; private set; }
    }
}
#pragma warning restore 1591
