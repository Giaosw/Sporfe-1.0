#pragma checksum "C:\Users\10.10.11.11\Downloads\Sporfe-1.0\Views\IndexInside\Proinfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f45110253bc5cfe52606d5d7cb0731785a0f12c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IndexInside_Proinfo), @"mvc.1.0.view", @"/Views/IndexInside/Proinfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IndexInside/Proinfo.cshtml", typeof(AspNetCore.Views_IndexInside_Proinfo))]
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
#line 1 "C:\Users\10.10.11.11\Downloads\Sporfe-1.0\Views\_ViewImports.cshtml"
using Sporfe_1._0;

#line default
#line hidden
#line 2 "C:\Users\10.10.11.11\Downloads\Sporfe-1.0\Views\_ViewImports.cshtml"
using Sporfe_1._0.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f45110253bc5cfe52606d5d7cb0731785a0f12c", @"/Views/IndexInside/Proinfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae6dedfa41d1ce687ed7bae239553cab4b34a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_IndexInside_Proinfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Profesor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2821, true);
            WriteLiteral(@"    <main role=""main"">
        <div class=""container-fluid"">
            <div class=""row"">
               <div class=""col-2""></div>
                  <div class=""col-8"">
                    <div class=""row"">
                     
                      <div class=""col-4 text-center"">
                            <i class=""fas fa-user fa-7x text-center mt-3""></i>
                      </div>
                      
                          <div class=""col-8"">
                            <h3>Datos: </h3>
                            <h5>Nombre: </h5>
                            <h5>Edad:</h5>
                            <h5>Correo:</h5>
                            <h5>Años de experiencia:</h5>
                            <a href=""#"" class=""btn btn-outline-primary"">Califica a este profesor</a>
                          
                            </div>
                          </div>
                   <h3>Estadisticas:</h3>
                   <h5>Calificación general</h5>
                ");
            WriteLiteral(@"   <div class=""progress mb-2"">
                    <div class=""progress-bar "" role=""progressbar"" style=""width: 70%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                  </div>
                  <h5>Calificación general</h5>
                  <div class=""progress mb-2"">
                    <div class=""progress-bar "" role=""progressbar"" style=""width: 50%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                  </div>
                  <h5>Calificación general</h5>                           <div class=""progress mb-2"">
                    <div class=""progress-bar "" role=""progressbar"" style=""width: 50%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                  </div>
                  <h5>Calificación general</h5>
                  <div class=""progress mb-2"">
                    <div class=""progress-bar "" role=""progressbar"" style=""width: 50%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
   ");
            WriteLiteral(@"               </div>
                          
                  <div class=""border border-secondary"""">
                        los comentarios apareceran aqui
                  </div>
                  
                  <form>
                    <div class=""form-group"">
                      <label for=""comentario"">Ingresa un comentario</label>
                      <input type=""text"" class=""form-control"" id=""comentario"" placeholder=""Recuerda comentar educadamente"">
                    </div>
                    <button type=""submit"" class=""btn btn-primary"">Comentar</button>

                  </form>
               </div>
            <div class=""col-2""></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Profesor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
