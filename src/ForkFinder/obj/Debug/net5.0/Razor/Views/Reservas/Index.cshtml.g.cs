<<<<<<< HEAD
#pragma checksum "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3475835b9629ba6ffb7857b63be942102dacfb8b"
=======
#pragma checksum "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7150514698c56e6cbce6bb8cbbd071877df3b12"
>>>>>>> develop
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservas_Index), @"mvc.1.0.view", @"/Views/Reservas/Index.cshtml")]
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
<<<<<<< HEAD
#line 1 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\_ViewImports.cshtml"
>>>>>>> develop
using ForkFinder;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\_ViewImports.cshtml"
>>>>>>> develop
using ForkFinder.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3475835b9629ba6ffb7857b63be942102dacfb8b", @"/Views/Reservas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5497efc0d149d70ae76370cd1637ad23617ca73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ForkFinder.ViewModels.MesaComReservas>>
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7150514698c56e6cbce6bb8cbbd071877df3b12", @"/Views/Reservas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5497efc0d149d70ae76370cd1637ad23617ca73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reserva>>
>>>>>>> develop
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
            WriteLiteral("\r\n<h2>Reservas</h2>\r\n\r\n");
#nullable restore
#line 5 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
 if (Model.Count > 0)
{
    foreach (var mesa in Model)
    {
=======
#nullable restore
#line 2 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
  
    ViewData["Title"] = "List of Reserva";
>>>>>>> develop

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("        <h4>Mesa de: ");
#nullable restore
#line 9 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                Write(mesa.Mesa.TamanhoMesa);
=======
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 10 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataHoraCriacao));
>>>>>>> develop

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral(" lugares</h4>\r\n");
#nullable restore
#line 11 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
         if (mesa.Reservas.Count > 0)
        {
=======
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 11 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataHoraReserva));
>>>>>>> develop

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral(@"            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Data da Reserva</th>
                        <th>Cliente</th>
                        <th>Descrição</th>
                        <th>Situação</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 24 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                     foreach (var reserva in mesa.Reservas)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 27 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                           Write(reserva.Agenda.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                           Write(reserva.Cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                           Write(reserva.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                           Write(reserva.Situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 32 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                                 if (reserva.Situacao == Situacao.Pendente)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\" class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#modalAprovarReserva_");
#nullable restore
#line 34 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                                                                                                                         Write(reserva.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Aprovar</a>\r\n                                    <a href=\"#\" class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#modalRecusarReserva_");
#nullable restore
#line 35 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                                                                                                                        Write(reserva.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Recusar</a>\r\n");
#nullable restore
#line 36 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n                        <!-- Modal de Aprovação -->\r\n                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1639, "\"", 1675, 2);
            WriteAttributeValue("", 1644, "modalAprovarReserva_", 1644, 20, true);
#nullable restore
#line 40 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
WriteAttributeValue("", 1664, reserva.Id, 1664, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1704, "\"", 1758, 2);
            WriteAttributeValue("", 1722, "modalAprovarReservaLabel_", 1722, 25, true);
#nullable restore
#line 40 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
WriteAttributeValue("", 1747, reserva.Id, 1747, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title""");
            BeginWriteAttribute("id", " id=\"", 2041, "\"", 2082, 2);
            WriteAttributeValue("", 2046, "modalAprovarReservaLabel_", 2046, 25, true);
#nullable restore
#line 44 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
WriteAttributeValue("", 2071, reserva.Id, 2071, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Aprovar Reserva</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body"">
                                        <p>Deseja realmente aprovar a reserva?</p>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2828, "\"", 2889, 1);
#nullable restore
#line 54 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
WriteAttributeValue("", 2835, Url.Action("AprovarReserva", new { id = reserva.Id }), 2835, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">Confirmar</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Modal de Recusa -->
                        <div class=""modal fade""");
            BeginWriteAttribute("id", " id=\"", 3179, "\"", 3215, 2);
            WriteAttributeValue("", 3184, "modalRecusarReserva_", 3184, 20, true);
#nullable restore
#line 60 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
WriteAttributeValue("", 3204, reserva.Id, 3204, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3244, "\"", 3298, 2);
            WriteAttributeValue("", 3262, "modalRecusarReservaLabel_", 3262, 25, true);
#nullable restore
#line 60 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
WriteAttributeValue("", 3287, reserva.Id, 3287, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title""");
            BeginWriteAttribute("id", " id=\"", 3581, "\"", 3622, 2);
            WriteAttributeValue("", 3586, "modalRecusarReservaLabel_", 3586, 25, true);
#nullable restore
#line 64 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
WriteAttributeValue("", 3611, reserva.Id, 3611, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Recusar Reserva</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body"">
                                        <p>Deseja realmente recusar a reserva?</p>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 4368, "\"", 4429, 1);
#nullable restore
#line 74 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
WriteAttributeValue("", 4375, Url.Action("RecusarReserva", new { id = reserva.Id }), 4375, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Confirmar</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 79 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 82 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Nenhuma reserva para esta mesa.</p>\r\n");
#nullable restore
#line 86 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr class=\"my-4\">\r\n");
#nullable restore
#line 89 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nenhuma reserva encontrada.</p>\r\n");
#nullable restore
#line 94 "c:\Users\Jansem\OneDrive\Documentos\GitHub\pmv-ads-2023-1-e2-proj-int-t2-time4-forkfinder\src\ForkFinder\Views\Reservas\Index.cshtml"
}
=======
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 12 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 13 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Situacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mesa.TamanhoMesa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mesa.QuantidadeMesa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 23 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataHoraCriacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataHoraReserva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 29 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 32 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Mesa.TamanhoMesa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Mesa.QuantidadeMesa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Situacao));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i></a> |
                            <a class=""btn btn-outline-info""><i class=""bi bi-eye""></i></a> |
                            <a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i></a>
                        </td>

                    </tr>
");
#nullable restore
#line 47 "C:\Users\Jansem\Source\Repos\ICEI-PUC-Minas-PMV-ADS\ForkFinder\src\ForkFinder\Views\Reservas\Index.cshtml"
                }
>>>>>>> develop

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
=======
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
>>>>>>> develop
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
<<<<<<< HEAD
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ForkFinder.ViewModels.MesaComReservas>> Html { get; private set; } = default!;
=======
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reserva>> Html { get; private set; } = default!;
>>>>>>> develop
        #nullable disable
    }
}
#pragma warning restore 1591
