#pragma checksum "C:\Users\vmartinez\Source\Repos\TutorialFelipeGavilan\HolaMundo\Views\Shared\Components\Paises\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53c0b6ce3ff41c41744a754d3308f77886a30f06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Paises_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Paises/Default.cshtml")]
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
#line 1 "C:\Users\vmartinez\Source\Repos\TutorialFelipeGavilan\HolaMundo\Views\_ViewImports.cshtml"
using HolaMundo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vmartinez\Source\Repos\TutorialFelipeGavilan\HolaMundo\Views\_ViewImports.cshtml"
using HolaMundo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c0b6ce3ff41c41744a754d3308f77886a30f06", @"/Views/Shared/Components/Paises/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a4d8155d713b88be50c2283503d1963b7add164", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Paises_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pais>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 4 "C:\Users\vmartinez\Source\Repos\TutorialFelipeGavilan\HolaMundo\Views\Shared\Components\Paises\Default.cshtml"
     foreach (var pais in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 6 "C:\Users\vmartinez\Source\Repos\TutorialFelipeGavilan\HolaMundo\Views\Shared\Components\Paises\Default.cshtml"
       Write(pais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 7 "C:\Users\vmartinez\Source\Repos\TutorialFelipeGavilan\HolaMundo\Views\Shared\Components\Paises\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pais>> Html { get; private set; }
    }
}
#pragma warning restore 1591
