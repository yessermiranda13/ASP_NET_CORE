#pragma checksum "e:\yesse\Escritorio\NET CORE PROJECTS\proyecto_2\Views\Clientes\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61ea79fb5432d6b53d8fba53d008d969ab1677b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Comments), @"mvc.1.0.view", @"/Views/Clientes/Comments.cshtml")]
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
#line 1 "e:\yesse\Escritorio\NET CORE PROJECTS\proyecto_2\Views\_ViewImports.cshtml"
using proyecto_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\yesse\Escritorio\NET CORE PROJECTS\proyecto_2\Views\_ViewImports.cshtml"
using proyecto_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61ea79fb5432d6b53d8fba53d008d969ab1677b2", @"/Views/Clientes/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de95fe04c48b25750d23cb1acdc3af50043fdfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<proyecto_2.ViewModels.ClienteComentarioViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br>\r\n");
#nullable restore
#line 3 "e:\yesse\Escritorio\NET CORE PROJECTS\proyecto_2\Views\Clientes\Comments.cshtml"
 for (int i = 0; i < Model.Count; i++)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\yesse\Escritorio\NET CORE PROJECTS\proyecto_2\Views\Clientes\Comments.cshtml"
Write(Html.DisplayFor(model => Model[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\yesse\Escritorio\NET CORE PROJECTS\proyecto_2\Views\Clientes\Comments.cshtml"
                                       ;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<proyecto_2.ViewModels.ClienteComentarioViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
