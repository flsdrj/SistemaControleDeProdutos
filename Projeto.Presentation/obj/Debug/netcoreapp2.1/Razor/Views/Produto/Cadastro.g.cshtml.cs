#pragma checksum "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc3c823cee9b93cb81198363a37f9320577e0ca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Cadastro), @"mvc.1.0.view", @"/Views/Produto/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Cadastro.cshtml", typeof(AspNetCore.Views_Produto_Cadastro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3c823cee9b93cb81198363a37f9320577e0ca8", @"/Views/Produto/Cadastro.cshtml")]
    public class Views_Produto_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto.Presentation.Models.CadastroProdutoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap-theme.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(115, 267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88a5ca1e36d442fe82777ec9b8df8f70", async() => {
                BeginContext(121, 96, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Cadastro</title>\r\n\r\n    ");
                EndContext();
                BeginContext(217, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edc3e050de0c4380a1313a869e49eba7", async() => {
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
                EndContext();
                BeginContext(288, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(294, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1370c32fbae4e338a60635880575930", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(371, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(382, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(384, 2116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9e61ab427e4b8384d3bb0a105919b1", async() => {
                BeginContext(390, 142, true);
                WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n\r\n        <h2>Cadastro de Produtos</h2>\r\n        <a href=\"/Home/Index\">Página inicial</a>\r\n        <hr />\r\n\r\n");
                EndContext();
#line 26 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
                BeginContext(578, 146, true);
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-4\">\r\n\r\n                    <label>Nome do Produto:</label>\r\n                    ");
                EndContext();
                BeginContext(725, 123, false);
#line 32 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
               Write(Html.TextBoxFor(model => model.Nome,
                        new { @class = "form-control", placeholder = "Digite aqui" }));

#line default
#line hidden
                EndContext();
                BeginContext(848, 74, true);
                WriteLiteral("\r\n                    <span class=\"text-danger\">\r\n                        ");
                EndContext();
                BeginContext(923, 46, false);
#line 35 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(969, 124, true);
                WriteLiteral("\r\n                    </span>\r\n                    <br />\r\n\r\n                    <label>Preço:</label>\r\n                    ");
                EndContext();
                BeginContext(1094, 124, false);
#line 40 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
               Write(Html.TextBoxFor(model => model.Preco,
                        new { @class = "form-control", placeholder = "Digite aqui" }));

#line default
#line hidden
                EndContext();
                BeginContext(1218, 74, true);
                WriteLiteral("\r\n                    <span class=\"text-danger\">\r\n                        ");
                EndContext();
                BeginContext(1293, 47, false);
#line 43 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Preco));

#line default
#line hidden
                EndContext();
                BeginContext(1340, 129, true);
                WriteLiteral("\r\n                    </span>\r\n                    <br />\r\n\r\n                    <label>Quantidade:</label>\r\n                    ");
                EndContext();
                BeginContext(1470, 129, false);
#line 48 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
               Write(Html.TextBoxFor(model => model.Quantidade,
                        new { @class = "form-control", placeholder = "Digite aqui" }));

#line default
#line hidden
                EndContext();
                BeginContext(1599, 74, true);
                WriteLiteral("\r\n                    <span class=\"text-danger\">\r\n                        ");
                EndContext();
                BeginContext(1674, 52, false);
#line 51 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Quantidade));

#line default
#line hidden
                EndContext();
                BeginContext(1726, 126, true);
                WriteLiteral("\r\n                    </span>\r\n                    <br />\r\n\r\n                    <label>Estoque:</label>\r\n                    ");
                EndContext();
                BeginContext(1853, 145, false);
#line 56 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
               Write(Html.DropDownListFor(model => model.IdEstoque, Model.ListagemDeEstoque,
                    "Escolha uma opção", new { @class = "form-control"}));

#line default
#line hidden
                EndContext();
                BeginContext(1998, 72, true);
                WriteLiteral("\r\n                    \r\n                    <span>\r\n                    ");
                EndContext();
                BeginContext(2071, 51, false);
#line 60 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
               Write(Html.ValidationMessageFor(model => model.IdEstoque));

#line default
#line hidden
                EndContext();
                BeginContext(2122, 266, true);
                WriteLiteral(@"    
                    </span>
                    <br />                    

                    <input type=""submit"" value=""Cadastrar Produto"" class=""btn btn-success"" />
                    <br />
                    <br />

                    <strong>");
                EndContext();
                BeginContext(2389, 20, false);
#line 68 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
                       Write(TempData["Mensagem"]);

#line default
#line hidden
                EndContext();
                BeginContext(2409, 57, true);
                WriteLiteral("</strong>\r\n\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 72 "C:\REPOSITORIO\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
        }

#line default
#line hidden
                BeginContext(2477, 16, true);
                WriteLiteral("\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2500, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto.Presentation.Models.CadastroProdutoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
