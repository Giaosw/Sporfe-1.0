#pragma checksum "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\IndexInside\IndexIs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970aaf7b6fc8fd352b39916d2fd8ab0fbc5e3dc9"
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
#line 1 "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\_ViewImports.cshtml"
using Sporfe_1._0;

#line default
#line hidden
#line 2 "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\_ViewImports.cshtml"
using Sporfe_1._0.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970aaf7b6fc8fd352b39916d2fd8ab0fbc5e3dc9", @"/Views/IndexInside/IndexIs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae6dedfa41d1ce687ed7bae239553cab4b34a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_IndexInside_IndexIs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Profesor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "IndexInside", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Proinfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\IndexInside\IndexIs.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1b1becd18ed4ded9569ec081021b8ba", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2de32adf69ed475bb2ec1b8d6eb3ac2d", async() => {
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
            BeginContext(5766, 394, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-10"">
                <div class=""album py-5 bg-light"">
        <div class=""container"">
          <h1>Bienvenido</h1>
          <h2>Estos son los profesores mas puntuados de este mes</h2>
          <div class=""row"">
");
            EndContext();
#line 103 "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\IndexInside\IndexIs.cshtml"
             foreach(var Profesor in Model) {


#line default
#line hidden
            BeginContext(6209, 179, true);
            WriteLiteral("                          <div class=\"col-md-4\">\r\n              <div class=\"card mb-4 shadow-sm\">\r\n                  \r\n                  \r\n                  \r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6388, "\"", 6408, 1);
#line 110 "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\IndexInside\IndexIs.cshtml"
WriteAttributeValue("", 6394, Profesor.Foto, 6394, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6409, 63, true);
            WriteLiteral(" class=\"card-img-top\"height=\"200\" width=\"40\">\r\n                ");
            EndContext();
            BeginContext(6472, 544, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2564af88e9c64487b6cd7ac79ea8d30e", async() => {
                BeginContext(6593, 67, true);
                WriteLiteral("\r\n                <div class=\"card-body\">\r\n                    <h5>");
                EndContext();
                BeginContext(6661, 15, false);
#line 113 "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\IndexInside\IndexIs.cshtml"
                   Write(Profesor.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(6676, 336, true);
                WriteLiteral(@"</h5>  
                  <p class=""card-text"">Calificación General</p>
                  <div class=""progress"">
                    <div class=""progress-bar "" role=""progressbar"" style=""width: 75%;"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100"">75%</div>
                  </div>
                </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 111 "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\IndexInside\IndexIs.cshtml"
                     WriteLiteral(Profesor.IdProfesor);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7016, 44, true);
            WriteLiteral("\r\n              </div>\r\n            </div>\r\n");
            EndContext();
#line 122 "C:\Users\pr.profesor\Documents\Sprofe-1.0\Views\IndexInside\IndexIs.cshtml"

}

#line default
#line hidden
            BeginContext(7065, 242, true);
            WriteLiteral("          </div>\r\n        </div>\r\n      </div>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n\r\n<script type=\"text/javascript\">\r\n  if(history.forward(1)){\r\n    location.replace( history.forward(1) );\r\n  }\r\n</script>\r\n\r\n    </main>");
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
