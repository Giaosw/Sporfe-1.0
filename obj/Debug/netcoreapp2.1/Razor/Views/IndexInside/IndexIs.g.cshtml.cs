#pragma checksum "C:\Users\alumno.CIIS\Documents\GitHub\Sporfe 1.0\Views\IndexInside\IndexIs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de02065631580a638056e03e0b2d925b722902f7"
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
#line 1 "C:\Users\alumno.CIIS\Documents\GitHub\Sporfe 1.0\Views\_ViewImports.cshtml"
using Sporfe_1._0;

#line default
#line hidden
#line 2 "C:\Users\alumno.CIIS\Documents\GitHub\Sporfe 1.0\Views\_ViewImports.cshtml"
using Sporfe_1._0.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de02065631580a638056e03e0b2d925b722902f7", @"/Views/IndexInside/IndexIs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae6dedfa41d1ce687ed7bae239553cab4b34a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_IndexInside_IndexIs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\alumno.CIIS\Documents\GitHub\Sporfe 1.0\Views\IndexInside\IndexIs.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 942, true);
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
            BeginContext(987, 1277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be527999726c4b44bd7b79c969b3e550", async() => {
                BeginContext(993, 1264, true);
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
            BeginContext(2264, 825, true);
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
            BeginContext(3089, 2652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a93c9424d22433fbeb45cdeb9e49a81", async() => {
                BeginContext(3095, 2639, true);
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
            BeginContext(5741, 4013, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-10"">
                <div class=""album py-5 bg-light"">
        <div class=""container"">

          <div class=""row"">
            <div class=""col-md-4"">
              <div class=""card mb-4 shadow-sm"">
                  <!--Aqui va imagen temporalmente usare iconos-->
                  
                  <i class=""fas fa-user fa-7x text-center mt-3""></i>
                <img class=""card-img-top"">
                <a href=""#"" style=""text-decoration: none;"">
                <div class=""card-body"">
                    <h5>Profesor 1</h5>  
                  <p class=""card-text"">Estadisticas del profesor</p>
                </div>
                </a>
              </div>
            </div>
                        <div class=""col-md-4"">
              <div class=""card mb-4 shadow-sm"">
                  <!--Aqui va imagen tempor");
            WriteLiteral(@"almente usare iconos-->
                  
                  <i class=""fas fa-user fa-7x text-center mt-3""></i>
                <img class=""card-img-top"">
                <a href=""#"" style=""text-decoration: none;"">
                <div class=""card-body"">
                    <h5>Profesor 2</h5>  
                  <p class=""card-text"">Estadisticas del profesor</p>
                </div>
                </a>
              </div>
            </div>
            <div class=""col-md-4"">
              <div class=""card mb-4 shadow-sm"">
                  <!--Aqui va imagen temporalmente usare iconos-->
                  
                  <i class=""fas fa-user fa-7x text-center mt-3""></i>
                <img class=""card-img-top"">
                <a href=""#"" style=""text-decoration: none;"">
                <div class=""card-body"">
                    <h5>Profesor 3</h5>  
                  <p class=""card-text"">Estadisticas del profesor</p>
                </div>
                </a>
              ");
            WriteLiteral(@"</div>
            </div>
                        <div class=""col-md-4"">
              <div class=""card mb-4 shadow-sm"">
                  <!--Aqui va imagen temporalmente usare iconos-->
                  
                  <i class=""fas fa-user fa-7x text-center mt-3""></i>
                <img class=""card-img-top"">
                <a href=""#"" style=""text-decoration: none;"">
                <div class=""card-body"">
                    <h5>Profesor 4</h5>  
                  <p class=""card-text"">Estadisticas del profesor</p>
                </div>
                </a>
              </div>
            </div>
                        <div class=""col-md-4"">
              <div class=""card mb-4 shadow-sm"">
                  <!--Aqui va imagen temporalmente usare iconos-->
                  
                  <i class=""fas fa-user fa-7x text-center mt-3""></i>
                <img class=""card-img-top"">
                <a href=""#"" style=""text-decoration: none;"">
                <div class=""card-b");
            WriteLiteral(@"ody"">
                    <h5>Profesor 5</h5>  
                  <p class=""card-text"">Estadisticas del profesor</p>
                </div>
                </a>
              </div>
            </div>
                        <div class=""col-md-4"">
              <div class=""card mb-4 shadow-sm"">
                  <!--Aqui va imagen temporalmente usare iconos-->
                  
                  <i class=""fas fa-user fa-7x text-center mt-3""></i>
                <img class=""card-img-top"">
                <a href=""#"" style=""text-decoration: none;"">
                <div class=""card-body"">
                    <h5>Profesor 6</h5>  
                  <p class=""card-text"">Estadisticas del profesor</p>
                </div>
                </a>
              </div>
            </div>  
          </div>
        </div>
      </div>
            </div>
        </div>
        
    </div>

      

    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591