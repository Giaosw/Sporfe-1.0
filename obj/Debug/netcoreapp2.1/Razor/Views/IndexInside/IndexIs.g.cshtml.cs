#pragma checksum "C:\Users\Alex\Desktop\multiplataforma\TrabajoFinal\Sporfe-1.0\Views\IndexInside\IndexIs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a0478b6b9429bd2283e66be169616dddb2bc9d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IndexInside_IndexIs), @"mvc.1.0.view", @"/Views/IndexInside/IndexIs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IndexInside/IndexIs.cshtml", typeof(AspNetCore.Views_IndexInside_IndexIs))]
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
#line 1 "C:\Users\Alex\Desktop\multiplataforma\TrabajoFinal\Sporfe-1.0\Views\_ViewImports.cshtml"
using Sporfe_1._0;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\multiplataforma\TrabajoFinal\Sporfe-1.0\Views\_ViewImports.cshtml"
using Sporfe_1._0.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a0478b6b9429bd2283e66be169616dddb2bc9d7", @"/Views/IndexInside/IndexIs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae6dedfa41d1ce687ed7bae239553cab4b34a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_IndexInside_IndexIs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Profesor>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Alex\Desktop\multiplataforma\TrabajoFinal\Sporfe-1.0\Views\IndexInside\IndexIs.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(70, 942, true);
            WriteLiteral(@"<main role=""main"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-2"">
                <h4>Has tu busqueda aqui</h4>
                <div class=""accordion"" id=""accordionExample"">
                    <div class=""card"">
                        <div class=""card-header px-0"" id=""headingOne"">
                            <h5 class=""mb-0"">
                                <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                    Busqueda Rápida
                                </button>
                            </h5>
                        </div>
                        <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                ");
            EndContext();
            BeginContext(1012, 1277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d576a44939304c5f84634dcf1cd3f23a", async() => {
                BeginContext(1018, 1264, true);
                WriteLiteral(@"
                                    <div class=""form-group row"">
                                        <label for=""inputNombre"" class=""col-sm-12 col-form-label"">Nombre</label>
                                      <div class=""col-sm-12"">
                                        <input type=""text"" class=""form-control"" id=""inputNombre"" placeholder=""Nombre"">
                                      </div>
                                    </div>
                                    <div class=""form-group row"">
                                      <label for=""inputApell"" class=""col-sm-12 col-form-label"">Apellidos</label>
                                      <div class=""col-sm-12"">
                                        <input type=""text"" class=""form-control"" id=""inputApell"" placeholder=""Apellidos"">
                                      </div>
                                    </div>
                                    <div class=""form-group row"">
                                      <div class");
                WriteLiteral("=\"col-sm-10\">\r\n                                        <button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\r\n                                      </div>\r\n                                    </div>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2289, 825, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header px-0"" id=""headingTwo"">
                            <h5 class=""mb-0"">
                                <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                    Busqueda Personalizada
                                </button>
                            </h5>
                        </div>
                        <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                ");
            EndContext();
            BeginContext(3114, 2652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ffc2550627b4c87b56f55bd3ae865ed", async() => {
                BeginContext(3120, 2639, true);
                WriteLiteral(@"
                                    <div class=""form-group row"">
                                        <label for=""inputNombre"" class=""col-sm-12 col-form-label"">Nombre</label>
                                      <div class=""col-sm-12"">
                                        <input type=""text"" class=""form-control"" id=""inputNombre"" placeholder=""Nombre"">
                                      </div>
                                    </div>
                                    <div class=""form-group row"">
                                      <label for=""inputApell"" class=""col-sm-12 col-form-label"">Apellidos</label>
                                      <div class=""col-sm-12"">
                                        <input type=""text"" class=""form-control"" id=""inputApell"" placeholder=""Apellidos"">
                                      </div>
                                    </div>
                                    <fieldset class=""form-group"">
                                      <div clas");
                WriteLiteral(@"s=""row"">
                                        <legend class=""col-form-label col-sm-12 pt-0"">Resultados exactos</legend>
                                        <div class=""col-sm-10"">
                                          <div class=""form-check"">
                                            <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios1"" value=""option1"" checked>
                                            <label class=""form-check-label"" for=""gridRadios1"">
                                              Si
                                            </label>
                                          </div>
                                          <div class=""form-check"">
                                            <input class=""form-check-input"" type=""radio"" name=""gridRadios"" id=""gridRadios2"" value=""option2"">
                                            <label class=""form-check-label"" for=""gridRadios2"">
                                              No
          ");
                WriteLiteral(@"                                  </label>
                                          </div>
                                        </div>
                                      </div>
                                    </fieldset>
                                    <div class=""form-group row"">
                                      <div class=""col-sm-10"">
                                        <button type=""submit"" class=""btn btn-primary"">Buscar</button>
                                      </div>
                                    </div>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5766, 426, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-10"">
                <div class=""album py-5 bg-light"">
        <div class=""container"">
          <h1>Bienvenido ""Aqui va el nombre del usuario""</h1>
          <h2>Estos son los profesores mas puntuados de este mes</h2>
          <div class=""row"">
");
            EndContext();
#line 103 "C:\Users\Alex\Desktop\multiplataforma\TrabajoFinal\Sporfe-1.0\Views\IndexInside\IndexIs.cshtml"
             foreach(var Profesor in Model) {

#line default
#line hidden
            BeginContext(6239, 227, true);
            WriteLiteral("                          <div class=\"col-md-4\">\r\n              <div class=\"card mb-4 shadow-sm\">\r\n                  <!--Aqui va imagen temporalmente usare iconos-->\r\n                  \r\n                  \r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6466, "\"", 6486, 1);
#line 109 "C:\Users\Alex\Desktop\multiplataforma\TrabajoFinal\Sporfe-1.0\Views\IndexInside\IndexIs.cshtml"
WriteAttributeValue("", 6472, Profesor.Foto, 6472, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6487, 173, true);
            WriteLiteral(" class=\"card-img-top\"height=\"200\" width=\"40\">\r\n                <a href=\"#\" style=\"text-decoration: none;\">\r\n                <div class=\"card-body\">\r\n                    <h5>");
            EndContext();
            BeginContext(6661, 15, false);
#line 112 "C:\Users\Alex\Desktop\multiplataforma\TrabajoFinal\Sporfe-1.0\Views\IndexInside\IndexIs.cshtml"
                   Write(Profesor.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(6676, 384, true);
            WriteLiteral(@"</h5>  
                  <p class=""card-text"">Calificación General</p>
                  <div class=""progress"">
                    <div class=""progress-bar "" role=""progressbar"" style=""width: 75%;"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100"">75%</div>
                  </div>
                </div>
                </a>
              </div>
            </div>
");
            EndContext();
#line 121 "C:\Users\Alex\Desktop\multiplataforma\TrabajoFinal\Sporfe-1.0\Views\IndexInside\IndexIs.cshtml"

}

#line default
#line hidden
            BeginContext(7065, 129, true);
            WriteLiteral("          </div>\r\n        </div>\r\n      </div>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n\r\n      \r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Profesor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
