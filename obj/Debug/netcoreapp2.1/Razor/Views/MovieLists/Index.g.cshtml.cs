#pragma checksum "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d3e587cf4543c86d38e89156e0dbe32bbeaedab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieLists_Index), @"mvc.1.0.view", @"/Views/MovieLists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MovieLists/Index.cshtml", typeof(AspNetCore.Views_MovieLists_Index))]
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
#line 1 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3e587cf4543c86d38e89156e0dbe32bbeaedab", @"/Views/MovieLists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa69464cafd4d76600b45784b8a784724c641a3", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieLists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC.Models.MovieList>>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(143, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4966db3278a4ba7a81acb93a0cd5997", async() => {
                BeginContext(166, 10, true);
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
            BeginContext(180, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(273, 40, false);
#line 15 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(313, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(369, 45, false);
#line 18 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(414, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(549, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(610, 39, false);
#line 28 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(649, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(717, 44, false);
#line 31 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(761, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(829, 78, false);
#line 34 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
               Write(Html.ActionLink("View", "View", "MovieLists", new { list_id = item.ID }, null));

#line default
#line hidden
            EndContext();
            BeginContext(907, 25, true);
            WriteLiteral(" | \r\n                    ");
            EndContext();
            BeginContext(933, 81, false);
#line 35 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "MovieLists", new { list_id = item.ID}, null));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1069, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC.Models.MovieList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
