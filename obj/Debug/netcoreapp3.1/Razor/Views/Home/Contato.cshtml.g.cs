#pragma checksum "/home/manuel/Área de Trabalho/Temporario/1. Tecnico em informatica para a internet/2. Modulo 2/Projeto novo/SBMfotos/Views/Home/Contato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12e161d10c1164420bcd3afde953851378acd6d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contato), @"mvc.1.0.view", @"/Views/Home/Contato.cshtml")]
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
#line 1 "/home/manuel/Área de Trabalho/Temporario/1. Tecnico em informatica para a internet/2. Modulo 2/Projeto novo/SBMfotos/Views/_ViewImports.cshtml"
using SBMfotos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/manuel/Área de Trabalho/Temporario/1. Tecnico em informatica para a internet/2. Modulo 2/Projeto novo/SBMfotos/Views/_ViewImports.cshtml"
using SBMfotos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e161d10c1164420bcd3afde953851378acd6d6", @"/Views/Home/Contato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3957d2ebef57e17f15adf37f88bc634fee1d818", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Contato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validarFormulario()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/manuel/Área de Trabalho/Temporario/1. Tecnico em informatica para a internet/2. Modulo 2/Projeto novo/SBMfotos/Views/Home/Contato.cshtml"
  
    ViewData["Title"] = "Contato";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">

<section class=""mb-4"">

    <!--Section heading-->
    <h2 class=""h1-responsive font-weight-bold text-center my-4"">Contato</h2>
    <!--Section description-->
    <p class=""text-center w-responsive mx-auto mb-5"">Alguma dúvida? Entre em contato!</p>

    <div class=""row"">

        <!--Grid column-->
        <div class=""col-md-9 mb-md-0 mb-5"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e161d10c1164420bcd3afde953851378acd6d65746", async() => {
                WriteLiteral(@"

                <!--Grid row-->
                <div class=""row"">

                    <!--Grid column-->
                    <div class=""col-md-6"">
                        <div class=""md-form mb-0"">
                            <input type=""text"" id=""name"" name=""name"" class=""form-control"">
                            <label for=""name""");
                BeginWriteAttribute("class", " class=\"", 874, "\"", 882, 0);
                EndWriteAttribute();
                WriteLiteral(@">Seu name</label>
                        </div>
                    </div>
                    <!--Grid column-->

                    <!--Grid column-->
                    <div class=""col-md-6"">
                        <div class=""md-form mb-0"">
                            <input type=""text"" id=""email"" name=""email"" class=""form-control"">
                            <label for=""email""");
                BeginWriteAttribute("class", " class=\"", 1271, "\"", 1279, 0);
                EndWriteAttribute();
                WriteLiteral(@">Seu email</label>
                        </div>
                    </div>
                    <!--Grid column-->

                </div>
                <!--Grid row-->

                <!--Grid row-->
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""md-form mb-0"">
                            <input type=""text"" id=""subject"" name=""subject"" class=""form-control"">
                            <label for=""subject""");
                BeginWriteAttribute("class", " class=\"", 1759, "\"", 1767, 0);
                EndWriteAttribute();
                WriteLiteral(@">Assunto</label>
                        </div>
                    </div>
                </div>
				<div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""md-form mb-0"">
                            <input type=""text"" id=""subject"" name=""subject"" class=""form-control"">
                            <label for=""subject""");
                BeginWriteAttribute("class", " class=\"", 2128, "\"", 2136, 0);
                EndWriteAttribute();
                WriteLiteral(@">Telefone</label>
                        </div>
                    </div>
                </div>
                <!--Grid row-->

                <!--Grid row-->
                <div class=""row"">

                    <!--Grid column-->
                    <div class=""col-md-12"">

                        <div class=""md-form"">
                            <textarea type=""text"" id=""message"" name=""message"" rows=""2"" class=""form-control md-textarea""></textarea>
                            <label for=""message"">Your message</label>
                        </div>

                    </div>
                </div>
                <!--Grid row-->
                <div class=""text-center text-md-left"">
                <div >
                       <button type=""button"" class=""btn btn-primary"">Enviar</button>
                </div>
            </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            
            <div class=""status""></div>
        </div>
        

       
        <div class=""col-md-3 text-center"">
            <ul class=""list-unstyled mb-0"">
                <li><i class=""fas fa-map-marker-alt fa-2x""></i>
                    <p> Rua Anchieta, n°20, Boa viagem - Niteroi</p>
                </li>

                <li><i class=""fas fa-phone mt-4 fa-2x""></i>
                    <p>(21) 95678-4538</p>
                </li>

                <li><i class=""fas fa-envelope mt-4 fa-2x""></i>
                    <p>contato@quiosque.com</p>
                </li>
            </ul>
        </div>
        

    </div>

</section>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
