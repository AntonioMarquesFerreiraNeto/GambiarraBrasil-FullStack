#pragma checksum "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d056ccee36e417dfb5f9e99e785316a082ea07c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LerArtigos_Index), @"mvc.1.0.view", @"/Views/LerArtigos/Index.cshtml")]
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
#line 1 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\_ViewImports.cshtml"
using GambiarraBrasil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\_ViewImports.cshtml"
using GambiarraBrasil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d056ccee36e417dfb5f9e99e785316a082ea07c", @"/Views/LerArtigos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308d5a44b946a15358d0b07eed45d22c757a1e33", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LerArtigos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Artigo>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/_css/artigos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Artigo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LerArtigos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d056ccee36e417dfb5f9e99e785316a082ea07c4954", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
 if (TempData["Erro"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-center\">\r\n        <div class=\"alert alert-danger\" role=\"alert\">\r\n            ");
#nullable restore
#line 6 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
       Write(TempData["Erro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"btn btn-danger btn-sm close-alert error\" aria-label=\"Close\"><i class=\"fa fa-xmark\"></i></button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""sectionLobby"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 capa"">
                <h1 class=""animation"">
                    Logo abaixo você
                    pode
                    ler
                    vários artigos universitários sobre o mundo da ""TI"". É só escolher e clicar!
                </h1>
            </div>
        </div>
    </div>
</section>
<section id=""navArtigos"">
    <div class=""container linksArtigos"">
        <h2 id=""tituloLer"">Artigos.</h2>
        <div class=""flex-container arti"">
");
#nullable restore
#line 29 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
             if (Model.Any() || Model.Count != 0) {
                foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1113, "\"", 1175, 2);
            WriteAttributeValue("", 1121, "card", 1121, 4, true);
#nullable restore
#line 31 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
WriteAttributeValue(" ", 1125, (item == Model.Last())? "ultimo-item": "itens", 1126, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 33 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
                                              Write(item.ReturnCategoria());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 35 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
                           Write(item.SubTitulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d056ccee36e417dfb5f9e99e785316a082ea07c9265", async() => {
                WriteLiteral("Leia!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
                }
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"" style=""text-align: center;"">Gambiarra Brasil</h5>
                            <p class=""card-text"" style=""text-align: center;"">
                                Nenhum artigo adicionado, adicione seu artigo para que as pessoas possam ler e aprender!
                            </p>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 53 "C:\Users\anton\source\repos\GambiarraBrasil\GambiarraBrasil\Views\LerArtigos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Artigo>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
