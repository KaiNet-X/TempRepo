#pragma checksum "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21f70df4e47205c6ccf6abd004b3bc4c1aed12d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OlympicGames_Views_OlympicHome_Home), @"mvc.1.0.view", @"/Areas/OlympicGames/Views/OlympicHome/Home.cshtml")]
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
#line 1 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\_ViewImports.cshtml"
using ProjectCentral.Areas.OlympicGames.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c21f70df4e47205c6ccf6abd004b3bc4c1aed12d", @"/Areas/OlympicGames/Views/OlympicHome/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74270035aeb89daad360a636ca091fe28849c75", @"/Areas/OlympicGames/Views/_ViewImports.cshtml")]
    public class Areas_OlympicGames_Views_OlympicHome_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Country>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
   
    string Active(string Current, string TrueActive)
    {
        if (Current.ToLower().Equals(TrueActive.ToLower()))
        {
            return "active";
        }
        return "";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .contain{\r\n        position: absolute;\r\n        left: 15rem;\r\n        right: auto\r\n    }\r\n</style>\r\n<div class=\"float-left position-fixed\">\r\n    <ul class=\"list-group mr-5 mt-5\">\r\n");
#nullable restore
#line 21 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
         foreach (Game game in ViewBag.Games)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 497, "\"", 563, 2);
            WriteAttributeValue("", 505, "list-group-item", 505, 15, true);
#nullable restore
#line 23 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
WriteAttributeValue(" ", 520, Active(game.GameName, ViewBag.ActiveGame), 521, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c21f70df4e47205c6ccf6abd004b3bc4c1aed12d4839", async() => {
#nullable restore
#line 24 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
                                                                                                             Write(game.GameName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-game", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
                                         WriteLiteral(game.GameName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["game"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-game", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["game"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
                                                                             WriteLiteral(ViewBag.ActiveCategory);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 26 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <ul class=\"list-group mr-5 mt-5\">\r\n");
#nullable restore
#line 29 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
         foreach (Category cat in ViewBag.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 862, "\"", 935, 2);
            WriteAttributeValue("", 870, "list-group-item", 870, 15, true);
#nullable restore
#line 31 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
WriteAttributeValue(" ", 885, Active(cat.CategoryName, ViewBag.ActiveCategory), 886, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c21f70df4e47205c6ccf6abd004b3bc4c1aed12d9111", async() => {
#nullable restore
#line 32 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
                                                                                                            Write(cat.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
                                             WriteLiteral(cat.CategoryName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
                                                                                WriteLiteral(ViewBag.ActiveGame);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["game"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-game", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["game"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 34 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n<div style=\"background-color: aquamarine\"class=\"contain mt-5\">\r\n");
#nullable restore
#line 38 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
     foreach (Country country in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img class=\"m-3 \"");
            BeginWriteAttribute("src", "src=\"", 1261, "\"", 1296, 1);
#nullable restore
#line 40 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
WriteAttributeValue("", 1266, Url.Content(country.FlagPath), 1266, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                data-toggle=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 1336, "\"", 1426, 4);
#nullable restore
#line 41 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
WriteAttributeValue("", 1344, country.CountryName, 1344, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1364, "|", 1365, 2, true);
#nullable restore
#line 41 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
WriteAttributeValue(" ", 1366, country.Game.GameName, 1367, 22, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
WriteAttributeValue(" ", 1389, country.Sport.Category.CategoryName, 1390, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 42 "C:\Users\User\source\repos\ProjectCentral\ProjectCentral\Areas\OlympicGames\Views\OlympicHome\Home.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591
