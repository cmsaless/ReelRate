#pragma checksum "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a27824855036b9f264a5c7413233cdb09afe18b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a27824855036b9f264a5c7413233cdb09afe18b", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa69464cafd4d76600b45784b8a784724c641a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(60, 192, true);
            WriteLiteral("\n<h1 class=\"text-danger\">Error</h1>\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\n<h3 class=\"text-danger\">You do not have authorization for this request.</h3>\n\n");
            EndContext();
#line 10 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(280, 51, true);
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(332, 15, false);
#line 13 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(347, 17, true);
            WriteLiteral("</code>\n    </p>\n");
            EndContext();
#line 15 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(366, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
