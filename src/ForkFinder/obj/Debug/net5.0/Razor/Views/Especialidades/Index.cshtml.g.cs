#pragma checksum "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Especialidades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4728205d9a08adf2078959fc649c1d191ade72aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Especialidades_Index), @"mvc.1.0.view", @"/Views/Especialidades/Index.cshtml")]
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
#line 1 "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\_ViewImports.cshtml"
using ForkFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\_ViewImports.cshtml"
using ForkFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4728205d9a08adf2078959fc649c1d191ade72aa", @"/Views/Especialidades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5497efc0d149d70ae76370cd1637ad23617ca73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Especialidades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Especialidade>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("categorias col"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Especialidades", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Look", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Especialidades\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""my-2 p-2"">
    <h4 class=""text-center"">
        Plataforma de reserva de mesa em restaurantes.<br />
        Busque por especialidade, disponibilidade, acessibilidade ou avaliação de outros clientes.
    </h4>
</div>

<div class=""mainEspecialidades container text-center my-2"">
    <div class=""row row-cols-4 m-auto"">
");
#nullable restore
#line 16 "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Especialidades\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4728205d9a08adf2078959fc649c1d191ade72aa5285", async() => {
                WriteLiteral("\r\n                <img class=\"img-fluid\" id=\"especialidadeimg\"");
                BeginWriteAttribute("src", " src=\"", 642, "\"", 696, 1);
#nullable restore
#line 19 "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Especialidades\Index.cshtml"
WriteAttributeValue("", 648, Html.DisplayFor(modelItem => item.ImagemUpload), 648, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div id=\"especialidade\" class=\"text-warning\">\r\n                    <p>Comida ");
#nullable restore
#line 21 "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Especialidades\Index.cshtml"
                         Write(Html.DisplayFor(modelItem => item.NomeEspecialidade));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Especialidades\Index.cshtml"
                                                                                          WriteLiteral(item.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\natan\Source\Repos\ICEI-PUC-Minas-PMV-ADS\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Especialidades\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Especialidade>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
