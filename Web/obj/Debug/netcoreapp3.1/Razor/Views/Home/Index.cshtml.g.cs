#pragma checksum "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743517bb3e3e1a240c874b5f815276c20bbf01d1"
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
#line 1 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743517bb3e3e1a240c874b5f815276c20bbf01d1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewModels.HomeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Analise", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buscar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Historico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var mes = DateTime.Now.ToString("MMMM");
    mes = char.ToUpper(mes.First()) + mes.Substring(1).ToLower();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
     if(TempData["Error"]!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\">\r\n        <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n          <strong>Alerta!</strong> ");
#nullable restore
#line 12 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                              Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n          </button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743517bb3e3e1a240c874b5f815276c20bbf01d16910", async() => {
                WriteLiteral(@"
        <div class=""card h-100"">
            <div class=""card-body"">
                <h4 class=""text-center"">Busca</h4><br />
                <div class=""form-group"">
                    
                    <div class=""input-group"">
                      <div class=""input-group-prepend"">
                        <span class=""input-group-text"">
                            <input");
                BeginWriteAttribute("class", " class=\"", 1077, "\"", 1085, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"" name=""chave"" id=""chave"" value=""F"">&nbsp;
                            <label class=""form-check-label"" for=""inlineRadio1"">CPF</label>
                        </span>
                        <span class=""input-group-text"">
                            <input");
                BeginWriteAttribute("class", " class=\"", 1358, "\"", 1366, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"" name=""chave"" id=""chave"" value=""J"">&nbsp;
                            <label class=""form-check-label"" for=""inlineRadio1"">CNPJ</label>
                        </span>
                      </div>
                      <input type=""text"" class=""form-control"" id=""numeroDocumento"" name=""numeroDocumento"" aria-describedby=""Número do Documento"" placeholder=""Digite o Número do Documento"">
                    </div>
                </div>
                <div class=""form-group"">
                    <button class=""btn btn-success btn-block"">Buscar</button>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""col-md-4"">
        <div class=""card h-100"">
            <div class=""card-body"">
                <h4 class=""text-center"">Informações Quantitativas</h4><br />
                <p class=""text-center"">
                    <b>Análises realizadas hoje:</b>
                    <br />
                    ");
#nullable restore
#line 52 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
               Write(Model.QuantidateAnalisesHoje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <b>Análises realizadas no mês (");
#nullable restore
#line 54 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                                               Write(mes);

#line default
#line hidden
#nullable disable
            WriteLiteral("):</b>\r\n                    <br />\r\n                    ");
#nullable restore
#line 56 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
               Write(Model.QuantidateAnalisesMes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <b>Motivo mais Utilizado hoje:</b>\r\n                    <br />\r\n                    ");
#nullable restore
#line 60 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                Write(Model.QuantidadeMotivosHoje==0?"-":Model.NomeMotivosHoje + " ("+Model.QuantidadeMotivosHoje+")");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    <b>Motivo mais Utilizado no mês (");
#nullable restore
#line 62 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                                                 Write(mes);

#line default
#line hidden
#nullable disable
            WriteLiteral("):</b>\r\n                    <br />\r\n                    ");
#nullable restore
#line 64 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                Write(Model.QuantidadeMotivosMes==0?"-":Model.NomeMotivosMes + " ("+Model.QuantidadeMotivosMes+")");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    
                    
                </p>
            </div>
        </div>
    </div>

    <div class=""col-md-4"">
        <div class=""card h-100"">
            <div class=""card-body"">
                <h4 class=""text-center"">Ranking de Classificações</h4><br />
                    <div class=""w-100"">
");
#nullable restore
#line 77 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                         if(Model.QuantidadeOuro>0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h1 class=\"classificacaoTxt\">\r\n                                ");
#nullable restore
#line 79 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                           Write(Model.ClassificacaoOuro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h1>\r\n                            <div class=\"gold-rank w-100 text-center rounded\">1º - ");
#nullable restore
#line 81 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                                                                             Write(Model.QuantidadeOuro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <br />\r\n");
#nullable restore
#line 83 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"w-50 float-left\">\r\n");
#nullable restore
#line 86 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                         if(Model.QuantidadePrata>0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 class=\"text-center\">\r\n                                ");
#nullable restore
#line 88 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                           Write(Model.ClassificacaoPrata);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h5>\r\n                            <div class=\"silver-rank w-100 text-center rounded-left\">2º - ");
#nullable restore
#line 90 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                                                                                    Write(Model.QuantidadePrata);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 91 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"w-50 float-right\">\r\n");
#nullable restore
#line 94 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                         if(Model.QuantidadeBronze>0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 class=\"text-center\">\r\n                                ");
#nullable restore
#line 96 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                           Write(Model.ClassificacaoBronze);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h5>\r\n                            <div class=\"bronze-rank w-100 text-center rounded-right\">3º - ");
#nullable restore
#line 98 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                                                                                     Write(Model.QuantidadeBronze);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 99 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
            </div>
        </div>
    </div>
</div>

<hr />

<div class=""row"">
    <div class=""col-md-12"">
        <h4>Últimas análises</h4>
        <br />
        <div class=""table-responsive"">
        <table class=""table table-bordered table-striped table-sm"">
            <tr>
                <th>Tipo de Pessoa</th>
                <th>Número</th>
                <th>Segmento</th>
                <th>Classificação</th>
                <th>Data da Análise</th>
                <th></th>
            </tr>
");
#nullable restore
#line 122 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
             foreach (var item in Model.Analises)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 125 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
               Write(item.Pessoa.TipoPessoa.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 126 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
               Write(item.Pessoa.NumeroDocumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 127 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
               Write(item.Pessoa.Segmento.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 128 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
               Write(item.Classificacao.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 129 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
               Write(item.DataCadastro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    <div class=\"btn-group\">\r\n                        <button class=\"btn btn-info btn-sm\">Ver</button>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 136 "C:\Users\alexj\OneDrive\Área de Trabalho\Projeto aplicado\Prototipação\CredAnls\Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        </div>\r\n        <div class=\"float-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743517bb3e3e1a240c874b5f815276c20bbf01d120458", async() => {
                WriteLiteral("Ver Histórico Completo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewModels.HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
