#pragma checksum "/Users/Apple/Documents/NetCore/Gambling/Views/Home/Poke.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97e5eda074dd79eb25100aa22819e314dda49127"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Poke), @"mvc.1.0.view", @"/Views/Home/Poke.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Poke.cshtml", typeof(AspNetCore.Views_Home_Poke))]
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
#line 1 "/Users/Apple/Documents/NetCore/Gambling/Views/_ViewImports.cshtml"
using Gambling;

#line default
#line hidden
#line 2 "/Users/Apple/Documents/NetCore/Gambling/Views/_ViewImports.cshtml"
using Gambling.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97e5eda074dd79eb25100aa22819e314dda49127", @"/Views/Home/Poke.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61066e79d732d70a1c0f8a9076546a13382223fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Poke : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Apple/Documents/NetCore/Gambling/Views/Home/Poke.cshtml"
  
    ViewData["Title"] = "Poke";

#line default
#line hidden
            BeginContext(63, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(68, 17, false);
#line 5 "/Users/Apple/Documents/NetCore/Gambling/Views/Home/Poke.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(85, 36, true);
            WriteLiteral("</h1>\r\n\r\n<p>Use this page Poke</p>\r\n");
            EndContext();
            BeginContext(122, 13, false);
#line 8 "/Users/Apple/Documents/NetCore/Gambling/Views/Home/Poke.cshtml"
Write(Model.person1);

#line default
#line hidden
            EndContext();
            BeginContext(135, 8, true);
            WriteLiteral("\r\n<br>\r\n");
            EndContext();
            BeginContext(144, 13, false);
#line 10 "/Users/Apple/Documents/NetCore/Gambling/Views/Home/Poke.cshtml"
Write(Model.person2);

#line default
#line hidden
            EndContext();
            BeginContext(157, 8, true);
            WriteLiteral("\r\n<br>\r\n");
            EndContext();
            BeginContext(166, 13, false);
#line 12 "/Users/Apple/Documents/NetCore/Gambling/Views/Home/Poke.cshtml"
Write(Model.person3);

#line default
#line hidden
            EndContext();
            BeginContext(179, 8, true);
            WriteLiteral("\r\n<br>\r\n");
            EndContext();
            BeginContext(188, 13, false);
#line 14 "/Users/Apple/Documents/NetCore/Gambling/Views/Home/Poke.cshtml"
Write(Model.person4);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PokeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
