#pragma checksum "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd052a8da8bc6e7261520395cbbdf7a8ddca19f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HastaneDuzenle), @"mvc.1.0.view", @"/Views/Home/HastaneDuzenle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd052a8da8bc6e7261520395cbbdf7a8ddca19f5", @"/Views/Home/HastaneDuzenle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"560c0f9543a7e9acdc8bd0f094d1cb0a3c09f1e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HastaneDuzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConpuGroupMedical.Models.Hastane>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("location.href=\'\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hastane_Islemleri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
#nullable restore
#line 3 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml"
  
    ViewData["Title"] = "Hastane_Duzenle";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd052a8da8bc6e7261520395cbbdf7a8ddca19f55998", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd052a8da8bc6e7261520395cbbdf7a8ddca19f56976", async() => {
                WriteLiteral("\r\n        <h1>Hastane Düzenleme Sayfası</h1>\r\n        <br>\r\n");
#nullable restore
#line 13 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml"
      using (Html.BeginForm("HastaneDuzenle","Home", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <br>\r\n                <br>\r\n            <tr>\r\n                <td>Hastane Tesis Kodu </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml"
               Write(Html.TextBoxFor(m => m.Tesis_Kodu));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>  \r\n");
                WriteLiteral("            <br>\r\n            <br>\r\n");
                WriteLiteral("            <tr>\r\n                <td>Hastane Adı </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml"
               Write(Html.TextBoxFor(m => m.Hastane_Adi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("            <br>\r\n            <br>\r\n");
                WriteLiteral("            <tr>\r\n                <td>Hastane Telefonu </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml"
               Write(Html.TextBoxFor(m => m.Hastane_Telefon));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("            <br>\r\n            <br>\r\n");
                WriteLiteral("            <tr>\r\n                <td>Hastane Adresi </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml"
               Write(Html.TextBoxFor(m => m.Hastene_Adres));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("           <br>\r\n           <br>\r\n");
                WriteLiteral("           <tr>\r\n                <td>Bağlı Olduğu Grup Id</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml"
               Write(Html.TextBoxFor(m => m.Bagli_Oldugu_Grup_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("        <br>\r\n        <br>\r\n");
                WriteLiteral("            <br>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd052a8da8bc6e7261520395cbbdf7a8ddca19f510550", async() => {
                    WriteLiteral("Hastaneyi Düzenlemeyi Tamamla");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <br>\r\n");
#nullable restore
#line 71 "C:\Users\cemre\Desktop\BİLGİLER\Dersler\Visual Studio Code Projects\cgm\ConpuGroupMedical\Views\Home\HastaneDuzenle.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div> \r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd052a8da8bc6e7261520395cbbdf7a8ddca19f512800", async() => {
                    WriteLiteral("Hastane Listesine Geri Dön");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n        </div> \r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConpuGroupMedical.Models.Hastane> Html { get; private set; }
    }
}
#pragma warning restore 1591