#pragma checksum "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc127b9a30efe8ee7b23b521e46aee561d1d4a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
#line 1 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\_ViewImports.cshtml"
using AlaInstagram;

#line default
#line hidden
#line 2 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\_ViewImports.cshtml"
using AlaInstagram.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc127b9a30efe8ee7b23b521e46aee561d1d4a57", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f880a79843d0ba6c2f4de32725be6c10c8bbf16d", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AlaInstagram.ViewModels.DisplayViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(134, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e246b7094a4acdb3549d4ebbb5535c", async() => {
                BeginContext(157, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(171, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 13 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
   
    var postIndex = 0;

#line default
#line hidden
#line 16 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
     foreach (var post in Model)
    {

        postIndex++;


#line default
#line hidden
            BeginContext(306, 67, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"center-block\">\r\n");
            EndContext();
#line 23 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
             foreach (var tag in post.Tags)
            {

#line default
#line hidden
            BeginContext(433, 46, true);
            WriteLiteral("                <span class=\"btn btn-primary\">");
            EndContext();
            BeginContext(480, 3, false);
#line 25 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                                         Write(tag);

#line default
#line hidden
            EndContext();
            BeginContext(483, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 26 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(507, 36, true);
            WriteLiteral("            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(545, 73, true);
            WriteLiteral("    <div class=\"row\" >\r\n        <div class=\"container\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 618, "\"", 644, 2);
            WriteAttributeValue("", 623, "myCarousel_", 623, 11, true);
#line 32 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
WriteAttributeValue("", 634, postIndex, 634, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(645, 84, true);
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\">\r\n                <!-- Indicators -->\r\n");
            EndContext();
#line 34 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                 if (post.PhotosPath.Count() > 1)
                {

#line default
#line hidden
            BeginContext(799, 107, true);
            WriteLiteral("                    <ol class=\"carousel-indicators\">\r\n                        <li data-target=\"#myCarousel_");
            EndContext();
            BeginContext(907, 9, false);
#line 37 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                                                Write(postIndex);

#line default
#line hidden
            EndContext();
            BeginContext(916, 42, true);
            WriteLiteral("\" data-slide-to=\"0\" class=\"active\"></li>\r\n");
            EndContext();
#line 38 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                         for (int i = 1; i < post.PhotosPath.Count(); i++)
                        {

#line default
#line hidden
            BeginContext(1061, 57, true);
            WriteLiteral("                            <li data-target=\"#myCarousel_");
            EndContext();
            BeginContext(1119, 9, false);
#line 40 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                                                    Write(postIndex);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 17, true);
            WriteLiteral("\" data-slide-to=\"");
            EndContext();
            BeginContext(1146, 1, false);
#line 40 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                                                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 9, true);
            WriteLiteral("\"></li>\r\n");
            EndContext();
#line 41 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1183, 29, true);
            WriteLiteral("\r\n                    </ol>\r\n");
            EndContext();
#line 44 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1231, 95, true);
            WriteLiteral("\r\n\r\n                <!-- Wrapper for slides -->\r\n                <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 49 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                      
                        string className = "";
                    

#line default
#line hidden
            BeginContext(1421, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 52 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                     foreach (var path in post.PhotosPath)
                    {
                        if (post.PhotosPath.First() == path)
                        {
                            className = "item active";
                        }
                        else
                        {
                            className = "item";
                        }

#line default
#line hidden
            BeginContext(1809, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1837, "\"", 1855, 1);
#line 62 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
WriteAttributeValue("", 1845, className, 1845, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1856, 35, true);
            WriteLiteral(">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1891, "\"", 1902, 1);
#line 63 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
WriteAttributeValue("", 1897, path, 1897, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1903, 138, true);
            WriteLiteral(" style=\"margin:auto; max-height:400px;\">\r\n                            <div class=\"carousel-caption\">\r\n                                <h3>");
            EndContext();
            BeginContext(2042, 10, false);
#line 65 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                               Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2052, 44, true);
            WriteLiteral("</h3>\r\n                                <p>\r\n");
            EndContext();
#line 67 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                                 foreach (var tag in post.Tags)
                                {
                                    

#line default
#line hidden
            BeginContext(2233, 3, false);
#line 69 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                               Write(tag);

#line default
#line hidden
            EndContext();
#line 69 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                                        
                                    if (post.Tags.LastOrDefault() != tag)
                                    {
                                        string temp = "•";
                                        

#line default
#line hidden
            BeginContext(2453, 4, false);
#line 73 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                                   Write(temp);

#line default
#line hidden
            EndContext();
#line 73 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                                             

                                    }
                                }

#line default
#line hidden
            BeginContext(2535, 106, true);
            WriteLiteral("                                </p>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 80 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(2666, 28, true);
            WriteLiteral("\r\n                </div>\r\n\r\n");
            EndContext();
#line 85 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                 if (post.PhotosPath.Count() > 1)
                {

#line default
#line hidden
            BeginContext(2764, 52, true);
            WriteLiteral("                    <a class=\"left carousel-control\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2816, "\"", 2845, 2);
            WriteAttributeValue("", 2823, "#myCarousel_", 2823, 12, true);
#line 87 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
WriteAttributeValue("", 2835, postIndex, 2835, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2846, 243, true);
            WriteLiteral(" data-slide=\"prev\">\r\n                        <span class=\"glyphicon glyphicon-chevron-left\"></span>\r\n                        <span class=\"sr-only\">Previous</span>\r\n                    </a>\r\n                    <a class=\"right carousel-control\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3089, "\"", 3118, 2);
            WriteAttributeValue("", 3096, "#myCarousel_", 3096, 12, true);
#line 91 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
WriteAttributeValue("", 3108, postIndex, 3108, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3119, 187, true);
            WriteLiteral(" data-slide=\"next\">\r\n                        <span class=\"glyphicon glyphicon-chevron-right\"></span>\r\n                        <span class=\"sr-only\">Next</span>\r\n                    </a>\r\n");
            EndContext();
#line 95 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3325, 102, true);
            WriteLiteral("                <!-- Left and right controls -->\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
#line 102 "C:\Users\Forestf\Desktop\ASPdotNET\AlaInstagram\AlaInstagram\Views\Post\Index.cshtml"


    }

#line default
#line hidden
            BeginContext(3438, 27, true);
            WriteLiteral("\r\n\r\n<div class=\"row\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AlaInstagram.ViewModels.DisplayViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
