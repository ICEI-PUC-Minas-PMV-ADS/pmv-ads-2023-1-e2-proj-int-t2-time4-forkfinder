#pragma checksum "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "286962e7d448a92eb6aef241b2993ad9870f2c48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Especialidades_Look), @"mvc.1.0.view", @"/Views/Especialidades/Look.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286962e7d448a92eb6aef241b2993ad9870f2c48", @"/Views/Especialidades/Look.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5497efc0d149d70ae76370cd1637ad23617ca73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Especialidades_Look : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Especialidade>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Especialidades", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Restaurantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Restaurante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
  
    ViewData["Title"] = "Look";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-4 justify-content-start\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "286962e7d448a92eb6aef241b2993ad9870f2c485181", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-4 ms-auto\">\r\n            <h6>Restaurantes por Especialidade</h6>\r\n        </div>        \r\n    </div>\r\n    <hr />\r\n    <div>\r\n");
            WriteLiteral("    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row align-items-center justify-content-start\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
             foreach (var restaurantes in Model.Especialidades_Restaurantes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4 m-0\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "286962e7d448a92eb6aef241b2993ad9870f2c487341", async() => {
                WriteLiteral("\r\n                        <div class=\"row align-items-center justify-content-start py-3\">\r\n                            <div class=\"col-3\">\r\n                                <div>\r\n");
#nullable restore
#line 33 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                     if (restaurantes.Restaurante.FotoPerfil != null)
                                    {
                                        var base64String = Convert.ToBase64String(restaurantes.Restaurante.FotoPerfil);
                                        var imgSrc = string.Format("data:image/jpeg;base64,{0}", base64String);

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img class=\"rounded-circle\"");
                BeginWriteAttribute("src", " src=\"", 1570, "\"", 1583, 1);
#nullable restore
#line 37 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
WriteAttributeValue("", 1576, imgSrc, 1576, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"max-width:100px; min-height:100px;\" />\r\n");
#nullable restore
#line 38 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span>Nenhuma imagem disponível</span>\r\n");
#nullable restore
#line 42 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-9"">
                                <div class=""row align-items-center m-0"">
                                    <div class=""col text-decoration-none"">
                                        <div class=""row m-0"">
                                            <p class=""px-2 m-0"">");
#nullable restore
#line 49 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                           Write(Html.DisplayFor(modelItem => restaurantes.Restaurante.Nome));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"row m-0\">\r\n                                            <div class=\"col-7 p-1\">\r\n");
#nullable restore
#line 53 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                 if (restaurantes.Restaurante.Avaliacoes.Count > 0)
                                                {
                                                    double mediaAvaliacoes = restaurantes.Restaurante.Avaliacoes.Average(a => a.Estrela);
                                                    int quantidadeEstrelas = (int)Math.Round(mediaAvaliacoes);


#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <div class=\"row\">\r\n                                                        <p>\r\n");
#nullable restore
#line 60 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                             for (int i = 0; i < 5; i++)
                                                            {
                                                                if (i < quantidadeEstrelas)
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <i class=\"bi bi-star-fill text-warning\"></i>\r\n");
#nullable restore
#line 65 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                                }
                                                                else
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <i class=\"bi bi-star text-warning\"></i>\r\n");
#nullable restore
#line 69 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                                }
                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        </p>\r\n                                                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <p class=\"p-0 m-1 text-warning\">Sem avaliações</p>                                                    \r\n");
#nullable restore
#line 77 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </div>\r\n                                            <div class=\"col-5\">\r\n                                                <li class=\"py-2 m-0\">");
#nullable restore
#line 80 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                                Write(Html.DisplayFor(modelItem => restaurantes.Especialidade.NomeEspecialidade));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</li>
                                            </div>
                                        </div>
                                        <div class=""row m-0"">
                                            <p class=""px-2 m-0"">
                                                ");
#nullable restore
#line 85 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                           Write(Html.DisplayFor(modelItem => restaurantes.Restaurante.Endereco.Cidade));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                                            ");
#nullable restore
#line 86 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                       Write(Html.DisplayFor(modelItem => restaurantes.Restaurante.Endereco.Bairro));

#line default
#line hidden
#nullable disable
                WriteLiteral(", \r\n                                            ");
#nullable restore
#line 87 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                       Write(Html.DisplayFor(modelItem => restaurantes.Restaurante.Endereco.Numero));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
                                                                                WriteLiteral(restaurantes.RestauranteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 95 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Especialidades\Look.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Especialidade> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
