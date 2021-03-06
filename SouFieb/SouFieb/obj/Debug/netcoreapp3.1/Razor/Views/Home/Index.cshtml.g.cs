#pragma checksum "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "997ae13731b6682f1a8706465159fef775ff4cc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\_ViewImports.cshtml"
using SouFieb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\_ViewImports.cshtml"
using SouFieb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"997ae13731b6682f1a8706465159fef775ff4cc0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37369efe5f3bda5c7bbdfad5a6235a3168d81249", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pessoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""page-header"">Listagem de Pessoas</h3>

<a class=""btn btn-info"" href=""/Evento/Index"" style=""float: right; margin-bottom: 12px; color: #FFF; "">Eventos</a>

<a class=""btn btn-info"" href=""/Pessoa/Nova"" style=""float: right; margin-bottom: 12px; color: #FFF; margin-right: 10px;"">Cadastrar nova pessoa</a>

");
#nullable restore
#line 12 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Mensagem))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n        <strong>Sucesso!</strong>  ");
#nullable restore
#line 15 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
                              Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">E-mail</th>
            <th scope=""col"">Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
         if (Model != null && Model.Any())
        {
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 38 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 39 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1359, "\"", 1389, 2);
            WriteAttributeValue("", 1366, "/Pessoa/Editar/", 1366, 15, true);
#nullable restore
#line 42 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
WriteAttributeValue("", 1381, item.Id, 1381, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: #FFF;\">Editar</a>\r\n                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1473, "\"", 1514, 2);
            WriteAttributeValue("", 1480, "/Pessoa/ConfirmarExclusao/", 1480, 26, true);
#nullable restore
#line 43 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
WriteAttributeValue("", 1506, item.Id, 1506, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: #FFF;\">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"odd\">\r\n                <td valign=\"top\" colspan=\"6\">\r\n                    Nenhum registro encontrado\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
