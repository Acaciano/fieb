#pragma checksum "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41fb2157c0aea36f31a973186a71a933474cafa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evento_Novo), @"mvc.1.0.view", @"/Views/Evento/Novo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41fb2157c0aea36f31a973186a71a933474cafa5", @"/Views/Evento/Novo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37369efe5f3bda5c7bbdfad5a6235a3168d81249", @"/Views/_ViewImports.cshtml")]
    public class Views_Evento_Novo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Evento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml"
  
    ViewData["Title"] = "Cadastrar Novo Evento";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"page-header\">Cadastro de uma Novo Evento</h3>\r\n\r\n<div>\r\n");
#nullable restore
#line 9 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml"
     using (Html.BeginForm("Cadastrar", "Evento", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"form-group col-md-4\">\r\n            <label for=\"nome\">Nome</label>\r\n            ");
#nullable restore
#line 15 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml"
       Write(Html.TextBoxFor(x => x.Nome, new { @class = "form-control", id = "nome", placeholder = "Digite o nome do evento" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-4\">\r\n            <label for=\"descricao\">Descrição</label>\r\n            ");
#nullable restore
#line 20 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml"
       Write(Html.TextBoxFor(x => x.Descricao, new { @class = "form-control", id = "descricao", placeholder = "Digite a descrição" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-4\">\r\n            <label for=\"descricao\">Foto</label>\r\n            ");
#nullable restore
#line 25 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml"
       Write(Html.TextBoxFor(x => x.Foto, new { @class = "form-control", id = "descricao", placeholder = "Digite o endereço da foto" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("        <hr />\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n                ");
#nullable restore
#line 34 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml"
           Write(Html.ActionLink("Voltar","Index", "Home" , new { @class = "btn btn-default" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Treinamento\Fieb\SouFieb\SouFieb\Views\Evento\Novo.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Evento> Html { get; private set; }
    }
}
#pragma warning restore 1591
