#pragma checksum "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "695398fd5d14e1eb545278af1f5a188565025409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cortometrajes), @"mvc.1.0.view", @"/Views/Home/Cortometrajes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695398fd5d14e1eb545278af1f5a188565025409", @"/Views/Home/Cortometrajes.cshtml")]
    public class Views_Home_Cortometrajes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DISENEY_PIXAR.Models.CortometrajeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgPelicula"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"principalPeliculas\">\r\n\r\n    <div id=\"pelis\">\r\n\r\n");
#nullable restore
#line 9 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
         foreach (var cate in Model.Categorias)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 12 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
           Write(cate.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 14 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
             foreach (var cort in cate.Cortometraje)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "695398fd5d14e1eb545278af1f5a1885650254094035", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "695398fd5d14e1eb545278af1f5a1885650254094314", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 462, "~/images/portadas/", 462, 18, true);
#nullable restore
#line 18 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
AddHtmlAttributeValue("", 480, cort.Id, 480, 10, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 490, "_pc.jpg", 490, 7, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
AddHtmlAttributeValue("", 504, cort.Nombre, 504, 12, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 380, "~/", 380, 2, true);
#nullable restore
#line 17 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
AddHtmlAttributeValue("", 382, cort.Nombre.Replace(" ","-"), 382, 29, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 411, "/Cortometraje", 411, 13, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"nombrePelicula\">\r\n                        <p>");
#nullable restore
#line 21 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
                      Write(cort.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 24 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\tony1\Downloads\DISENEY PIXAR\DISENEY PIXAR\Views\Home\Cortometrajes.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DISENEY_PIXAR.Models.CortometrajeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
