#pragma checksum "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c14997ee2a701b129aec618551a0b392fd610a1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurantes_Restaurante), @"mvc.1.0.view", @"/Views/Restaurantes/Restaurante.cshtml")]
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
#line 1 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\_ViewImports.cshtml"
using ForkFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\_ViewImports.cshtml"
using ForkFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c14997ee2a701b129aec618551a0b392fd610a1a", @"/Views/Restaurantes/Restaurante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5497efc0d149d70ae76370cd1637ad23617ca73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Restaurantes_Restaurante : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurante>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Mesas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-warning text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
  
    ViewData["Title"] = "Página Restaurante";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<a href=\"javascript: history.go(-1)\" class=\"btn bg-warning text-dark\">Voltar</a>\r\n<hr />\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <div class=\"col\">\r\n");
            WriteLiteral("                <div>\r\n                    <img class=\"img-fluid rounded\" width=\"100%\" id=\"ImageUrlPreview\" />\r\n                </div>\r\n            </div>\r\n            <div class=\"d-flex gap-2\">\r\n");
#nullable restore
#line 21 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                 foreach (var foto in Model.Fotos)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img onclick=\"LoadImg(src)\" id=\"ImageURL\" class=\"img-fluid rounded mt-2 mr-5\"");
            BeginWriteAttribute("src", " src=\"", 906, "\"", 964, 1);
#nullable restore
#line 24 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
WriteAttributeValue("", 912, Html.DisplayFor(modelItem => foto.FotosRestaurante), 912, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Fotos do Restaurante\" style=\"max-width:100px; min-height:100px;\">\r\n");
#nullable restore
#line 25 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-6\">\r\n\r\n            <div class=\"row\">\r\n                <h3 class=\"text-warning\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
               Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <h5>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
               Write(Html.DisplayFor(model => model.DescricaoRestaurante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h5>\r\n            </div>\r\n            <div class=\"row\">\r\n                <p class=\"text-warning\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
               Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n");
#nullable restore
#line 42 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                 if (Model.Avaliacoes.Count > 0)
                {
                    double mediaAvaliacoes = Model.Avaliacoes.Average(a => a.Estrela);
                    int quantidadeEstrelas = (int)Math.Round(mediaAvaliacoes);


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <p>\r\n");
#nullable restore
#line 49 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                             for (int i = 0; i < 5; i++)
                            {
                                if (i < quantidadeEstrelas)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"bi bi-star-fill text-warning\"></i>\r\n");
#nullable restore
#line 54 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"bi bi-star text-warning\"></i>\r\n");
#nullable restore
#line 58 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </p>\r\n                    </div>\r\n");
#nullable restore
#line 62 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Ainda não há avaliações.</p>\r\n");
#nullable restore
#line 66 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <p>
                    <span class=""material-symbols-outlined text-warning fs-1 align-content-center"">
                        accessible
                    </span>
                    <span class=""material-symbols-outlined text-warning fs-1 justify-content-center"">
                        child_care
                    </span>

                </p>
                <div class=""row text-center"">
                    <div class=""col justify-content-center"">
");
            WriteLiteral("                    </div>\r\n                    <div class=\"col justify-content-center\">\r\n");
#nullable restore
#line 82 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                         if (User.IsInRole("Cliente"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c14997ee2a701b129aec618551a0b392fd610a1a10852", async() => {
                WriteLiteral("Reservar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                                                                                  WriteLiteral(Model.RestauranteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"  
    <script>
        window.onload = function LoadImg() {
            document.getElementById(""ImageURL"").click();
        }
        var newImg = getElementById(""ImageURL"");
        function LoadImg(newImg) {
            $(""#ImageUrlPreview"").empty();
            document.getElementById('ImageUrlPreview').src = newImg;
        }
    </script>
");
#nullable restore
#line 103 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
     if (ViewData["Avaliacoes"] != null)
    {
        var avaliacoes = ViewData["Avaliacoes"] as List<Avaliacao>;
        if (avaliacoes.Count > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <h4>Avaliações dos clientes</h4>
            <hr />
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Cliente</th>
                        <th>Estrelas</th>
                        <th>Comentário</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 119 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                     foreach (var avaliacao in avaliacoes)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 122 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                           Write(avaliacao.ClienteId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 123 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                           Write(avaliacao.Estrela);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 124 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                           Write(avaliacao.Comentario);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 126 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 129 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Restaurantes\Restaurante.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurante> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
