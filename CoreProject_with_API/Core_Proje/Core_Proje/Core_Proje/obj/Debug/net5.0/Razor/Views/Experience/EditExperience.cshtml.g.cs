#pragma checksum "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed16b99f93a895f5c570d5e9e1e36cf6a61d4ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_EditExperience), @"mvc.1.0.view", @"/Views/Experience/EditExperience.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed16b99f93a895f5c570d5e9e1e36cf6a61d4ba7", @"/Views/Experience/EditExperience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_EditExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Experience>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
  
    ViewData["Title"] = "EditExperience";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Deneyim Güncelleme Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 11 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
 using (Html.BeginForm("EditExperience", "Experience", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.HiddenFor(x=>x.ExperienceID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.Label("Deneyim Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.TextBoxFor(x => x.Name,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.ValidationMessageFor(x=>x.Name,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.Label("Deneyim Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.TextAreaFor(x => x.Description,4,2,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.ValidationMessageFor(x=>x.Description,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.Label("Deneyim Resim URL'si"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.Label("Deneyim Tarih"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.TextBoxFor(x => x.Date,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"
Write(Html.ValidationMessageFor(x=>x.Date,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button type=\"submit\" class=\"btn btn-success\">Güncelle</button>\r\n    <button type=\"reset\" class=\"btn btn-success\">Sıfırla</button>\r\n");
#nullable restore
#line 35 "D:\ASP.net_Core\Core_Proje\Core_Proje\Core_Proje\Views\Experience\EditExperience.cshtml"

}

#line default
#line hidden
#nullable disable
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
