#pragma checksum "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe7b1251b1cb6f1d5db4361f3dea58bc1a4546d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_AddExperience), @"mvc.1.0.view", @"/Views/Experience/AddExperience.cshtml")]
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
#line 1 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe7b1251b1cb6f1d5db4361f3dea58bc1a4546d", @"/Views/Experience/AddExperience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_AddExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Experience>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
  
    ViewData["Title"] = "AddExperience";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Deneyim Ekleme Sayfas??</h3>\r\n</div>\r\n");
#nullable restore
#line 10 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
 using (Html.BeginForm("AddExperience", "Experience", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.Label("Deneyim Ba??l??????"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.TextBoxFor(x => x.Name,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.ValidationMessageFor(x=>x.Name,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.Label("Deneyim A????klama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.TextAreaFor(x => x.Description,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.ValidationMessageFor(x=>x.Description,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.Label("Deneyim Resim URL'si"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.Label("Deneyim Tarih"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.TextBoxFor(x => x.Date,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"
Write(Html.ValidationMessageFor(x=>x.Date,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Ekle</button>\r\n");
#nullable restore
#line 30 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\AddExperience.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Experience> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
