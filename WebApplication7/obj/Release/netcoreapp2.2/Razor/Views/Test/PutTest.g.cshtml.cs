#pragma checksum "C:\Users\user\Source\Repos\WebApplication7\WebApplication7\Views\Test\PutTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f0b6b59a5e550da12ca396b946d1b6952c625d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_PutTest), @"mvc.1.0.view", @"/Views/Test/PutTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/PutTest.cshtml", typeof(AspNetCore.Views_Test_PutTest))]
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
#line 1 "C:\Users\user\Source\Repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7;

#line default
#line hidden
#line 2 "C:\Users\user\Source\Repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0b6b59a5e550da12ca396b946d1b6952c625d7", @"/Views/Test/PutTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc31cafed32aad956e8e002afa406e7283b5ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_PutTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\user\Source\Repos\WebApplication7\WebApplication7\Views\Test\PutTest.cshtml"
  
    ViewData["Title"] = "PutTest";

#line default
#line hidden
            BeginContext(45, 39, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(84, 787, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f0b6b59a5e550da12ca396b946d1b6952c625d74918", async() => {
                BeginContext(168, 105, true);
                WriteLiteral("\r\n\r\n            <p>Title</p>\r\n            <input type=\"text\" id=\"title\" name=\"title\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 273, "\"", 308, 1);
#line 10 "C:\Users\user\Source\Repos\WebApplication7\WebApplication7\Views\Test\PutTest.cshtml"
WriteAttributeValue("", 281, ViewBag.model.title.Trim(), 281, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(309, 116, true);
                WriteLiteral("><br>\r\n            <p>Content</p>\r\n            <input type=\"text\" id=\"contents\" name=\"contents\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 425, "\"", 463, 1);
#line 12 "C:\Users\user\Source\Repos\WebApplication7\WebApplication7\Views\Test\PutTest.cshtml"
WriteAttributeValue("", 433, ViewBag.model.contents.Trim(), 433, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(464, 105, true);
                WriteLiteral("><br>\r\n            <p>Date</p>\r\n            <input type=\"text\" id=\"date\" name=\"date\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 569, "\"", 618, 1);
#line 14 "C:\Users\user\Source\Repos\WebApplication7\WebApplication7\Views\Test\PutTest.cshtml"
WriteAttributeValue("", 577, System.DateTime.Now.ToString("HH:mm:ss"), 577, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(619, 202, true);
                WriteLiteral(" /><br />\r\n            <button id=\"btn-Yes\" class=\"btn btn-lg btn-primary btn-block\" type=\"submit\">수정</button>\r\n            <input type=\"text\" style=\"display:none\" id=\"no\" name=\"no\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 821, "\"", 846, 1);
#line 16 "C:\Users\user\Source\Repos\WebApplication7\WebApplication7\Views\Test\PutTest.cshtml"
WriteAttributeValue("", 829, ViewBag.model.no, 829, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(847, 17, true);
                WriteLiteral("><br>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(871, 18, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591