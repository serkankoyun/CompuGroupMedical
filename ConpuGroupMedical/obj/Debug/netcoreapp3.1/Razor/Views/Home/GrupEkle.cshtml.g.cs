#pragma checksum "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\GrupEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b91893d54f3a8aca7aa71e915e4a913ffab24c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GrupEkle), @"mvc.1.0.view", @"/Views/Home/GrupEkle.cshtml")]
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
#line 1 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\_ViewImports.cshtml"
using ConpuGroupMedical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\_ViewImports.cshtml"
using ConpuGroupMedical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b91893d54f3a8aca7aa71e915e4a913ffab24c9", @"/Views/Home/GrupEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"560c0f9543a7e9acdc8bd0f094d1cb0a3c09f1e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GrupEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConpuGroupMedical.Models.Grup_Tanimi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Grup_Islemleri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
#nullable restore
#line 3 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\GrupEkle.cshtml"
  
    ViewData["Title"] = "Grup_Ekle";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b91893d54f3a8aca7aa71e915e4a913ffab24c94115", async() => {
                WriteLiteral("\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b91893d54f3a8aca7aa71e915e4a913ffab24c95093", async() => {
                WriteLiteral("\r\n        <h1>Grup Ekleme Sayfası</h1>\r\n        <br>\r\n");
#nullable restore
#line 13 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\GrupEkle.cshtml"
          using (Html.BeginForm("GrupEkle","Home", FormMethod.Post))
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <br>\r\n                <br>\r\n            <tr>\r\n                <td>Grup Kodu</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 21 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\GrupEkle.cshtml"
               Write(Html.TextBoxFor(m => m.Grup_Kodu));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>  \r\n");
                WriteLiteral("            <br>\r\n            <br>\r\n");
                WriteLiteral("            <tr>\r\n                <td>Grup Adı </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\GrupEkle.cshtml"
               Write(Html.TextBoxFor(m => m.Grup_Adi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("           <br>\r\n           <br>\r\n");
                WriteLiteral("            <button type=\"submit\" id=\"save\" class=\"btn btn-primary\"  >Yeni Grup Bilgilerini Kaydet</button>\r\n");
                WriteLiteral("            <br>\r\n            <br>\r\n");
#nullable restore
#line 43 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\GrupEkle.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div> \r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b91893d54f3a8aca7aa71e915e4a913ffab24c97360", async() => {
                    WriteLiteral("Grup Listesine Geri Dön");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n            </div> \r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConpuGroupMedical.Models.Grup_Tanimi> Html { get; private set; }
    }
}
#pragma warning restore 1591
