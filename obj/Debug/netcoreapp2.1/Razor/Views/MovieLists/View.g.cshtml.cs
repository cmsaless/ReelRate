#pragma checksum "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74d336dc7178790a815e507b40bed23122fda59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieLists_View), @"mvc.1.0.view", @"/Views/MovieLists/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MovieLists/View.cshtml", typeof(AspNetCore.Views_MovieLists_View))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74d336dc7178790a815e507b40bed23122fda59", @"/Views/MovieLists/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa69464cafd4d76600b45784b8a784724c641a3", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieLists_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC.Models.MovieListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/view.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/MovieLists/View/draggable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 47, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"row\">\r\n        <h1><b>");
            EndContext();
            BeginContext(178, 20, false);
#line 10 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
          Write(Model.ModelList.Name);

#line default
#line hidden
            EndContext();
            BeginContext(198, 481, true);
            WriteLiteral(@"</b></h1>
        <div class=""col-md-4"" id=""info-div"" style=""position:-webkit-sticky; position:sticky; top:0;"">

        </div>
        <div class=""col-md-8"">
            <h4 style=""color:red"" id=""error""></h4>
            <p>
                <button class=""btn btn-success"" id=""save-button"" onclick=""update()"">Save List</button>
                <button class=""btn btn-primary"" onclick=""attemptToAdd()"">Add To List</button>
            </p>
            <ol id=""columns"">
");
            EndContext();
#line 21 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
                   ViewBag.ListID = Model.ModelList.ID; 

#line default
#line hidden
            BeginContext(738, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 22 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
                 for (int i = 0; i < Model.RankedMovies.Count; ++i)
                {
                    int rank = i + 1;
                    Movie movie = Model.RankedMovies[i].Item2;

#line default
#line hidden
            BeginContext(929, 166, true);
            WriteLiteral("                    <li class=\"column li-item\" draggable=\"true\">\r\n                        <div class=\"header\">\r\n                            <div class=\"movie-item\">\r\n");
            EndContext();
#line 29 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
                                 using (Html.BeginForm("Remove", "MovieLists", FormMethod.Post, new { encType = "multipart/form-data" }))
                                {
                                    // this all needs to be fixed. use an ajax.post().
                                    // order of operation: click remove button -> delete html elem -> reOrder numbers in list -> auto save/updateRanks -> refresh(?)
                                    // OR: click remove button -> post the remove -> controller updates all ranks -> refresh (easier but not as nice)

#line default
#line hidden
            BeginContext(1674, 67, true);
            WriteLiteral("                                    <span class=\"header-span rank\">");
            EndContext();
            BeginContext(1742, 4, false);
#line 34 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
                                                              Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(1746, 2, true);
            WriteLiteral(". ");
            EndContext();
            BeginContext(1749, 11, false);
#line 34 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
                                                                     Write(movie.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1760, 96, true);
            WriteLiteral("</span>\r\n                                    <input type=\"hidden\" name=\"list_id\" class=\"list-id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1856, "\"", 1883, 1);
#line 35 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
WriteAttributeValue("", 1864, Model.ModelList.ID, 1864, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1884, 92, true);
            WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"movie_id\" class=\"movie-id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1976, "\"", 1993, 1);
#line 36 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
WriteAttributeValue("", 1984, movie.ID, 1984, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1994, 258, true);
            WriteLiteral(@">
                                    <input type=""submit"" onclick=""reOrder()"" class=""btn btn-danger"" style=""float:right"" value=""Remove"" />
                                    <button type=""button"" class=""btn btn-info"" style=""float:right; margin-right:1em""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 2252, "\'", 2340, 12);
            WriteAttributeValue("", 2262, "showInfo(\"", 2262, 10, true);
#line 38 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
WriteAttributeValue("", 2272, movie.Poster, 2272, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2285, "\",", 2285, 2, true);
            WriteAttributeValue(" ", 2287, "\"", 2288, 2, true);
#line 38 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
WriteAttributeValue("", 2289, movie.Title, 2289, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2301, "\",", 2301, 2, true);
            WriteAttributeValue(" ", 2303, "\"", 2304, 2, true);
#line 38 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
WriteAttributeValue("", 2305, movie.Year, 2305, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2316, "\",", 2316, 2, true);
            WriteAttributeValue(" ", 2318, "\"", 2319, 2, true);
#line 38 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
WriteAttributeValue("", 2320, movie.Description, 2320, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 2338, "\")", 2338, 2, true);
            EndWriteAttribute();
            BeginContext(2341, 16, true);
            WriteLiteral(">Info</button>\r\n");
            EndContext();
#line 39 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
                                }

#line default
#line hidden
            BeginContext(2392, 95, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </li>\r\n");
            EndContext();
#line 43 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
                }

#line default
#line hidden
            BeginContext(2506, 59, true);
            WriteLiteral("            </ol>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2565, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f4e0dda49e94062b669af022c856d7e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2628, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2630, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25e6a3cfba24467aa72ddd74c4a3ea20", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2710, 1222, true);
            WriteLiteral(@"

<script>

    function update() {

        var arr = document.getElementsByClassName(""movie-item"");

        var ranks = document.getElementsByClassName('rank')
        var listIDs = document.getElementsByClassName('list-id')
        var movieIDs = document.getElementsByClassName('movie-id')

        for (i = 0; i < ranks.length; ++i) {
            var text = ranks[i].innerText;
            var idxOfDot = text.indexOf('.');
            var rank = text.substr(0, idxOfDot);

            var listID = listIDs[i].value
            var movieID = movieIDs[i].value

            console.log(rank, movieID);
            $.post(""/MovieLists/Save"", {list_id: listID, movie_id: movieID, new_rank: rank})
        }

        var btn = $(""#save-button"")
        btn.html(""Saved!"")
        btn.removeClass(""btn-success"")
        btn.addClass(""btn-default"")
        setTimeout(function () {btn.addClass('btn-success');btn.removeClass('btn-default');btn.html(""Save List"");}, 1000)
    }

    /*
     * ");
            WriteLiteral("Even if the user has JS disabled in their browser, the middle-ware will\r\n     * prevent movies from being added to a list at maximum capacity.\r\n     */\r\n    function attemptToAdd() {\r\n\r\n        if (");
            EndContext();
            BeginContext(3933, 20, false);
#line 88 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
       Write(Model.ModelList.Size);

#line default
#line hidden
            EndContext();
            BeginContext(3953, 252, true);
            WriteLiteral(" == 100) {\r\n            console.log(\"max\")\r\n            var elem = document.getElementById(\'error\');\r\n            elem.innerHTML = \"There\'s no room for more movies!\"\r\n        } else {\r\n            window.location.replace(\"/MovieLists/Search?list_id=\"+\'");
            EndContext();
            BeginContext(4206, 18, false);
#line 93 "C:\Users\chris\Coding\Personal\ASP.NET\ReelRate\MVC\Views\MovieLists\View.cshtml"
                                                              Write(Model.ModelList.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4224, 412, true);
            WriteLiteral(@"')
        }
        }

    function showInfo(poster_url, title, year, description) {
        $('#info-div').empty();
        $('#info-div').append('<img style=""margin-top:5em"" src=""' + poster_url + '"">')
        $('#info-div').append('<h2>' + title + '</h2>')
        $('#info-div').append('<h3>' + year + '</h3>')
        //$('#info-div').append('<p>' + description + '</p>')
    }

</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC.Models.MovieListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
