#pragma checksum "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\Directions\Directions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efc4d1dd08e96bf990577fa3e4a4bff4cf30ca6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directions_Directions), @"mvc.1.0.view", @"/Views/Directions/Directions.cshtml")]
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
#line 1 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efc4d1dd08e96bf990577fa3e4a4bff4cf30ca6d", @"/Views/Directions/Directions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Directions_Directions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication2.Models.Directions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("new"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\Directions\Directions.cshtml"
  
    ViewBag.Title = "Все факультеты";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc4d1dd08e96bf990577fa3e4a4bff4cf30ca6d4182", async() => {
                WriteLiteral("Добаление предмета");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    table {
        width: 300px; /* Ширина таблицы */
        margin: auto; /* Выравниваем таблицу по центру окна  */
        background: #786868
    }

    td {
        text-align: center; /* Выравниваем текст по центру ячейки */
    }

    .new {
        background: #786868;
        box-shadow: 0 0 5px rgb(0,0,0);
        cursor: pointer;
        border-radius: 5px;
        color: rgb(255,255,255);
        border: rgb(0,0,0);
        border-color: #008a77;
        text-align: center;
        display: block;
        width: 300px;
        margin: 20px auto;
    }

    .new2 {
        color: #593a3a;
    }
</style>
<table class=""table"" border=""1"">
    <tr><td>Название</td><td>Количество часов</td></tr>
");
#nullable restore
#line 37 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\Directions\Directions.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 40 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\Directions\Directions.cshtml"
           Write(item.group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\Directions\Directions.cshtml"
           Write(item.nubmer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 1053, "\"", 1107, 2);
            WriteAttributeValue("", 1060, "/Directions/DeleteDirections/", 1060, 29, true);
#nullable restore
#line 42 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\Directions\Directions.cshtml"
WriteAttributeValue("", 1089, item.DirectionsId, 1089, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 1144, "\"", 1198, 2);
            WriteAttributeValue("", 1151, "/Directions/UpdateDirections/", 1151, 29, true);
#nullable restore
#line 43 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\Directions\Directions.cshtml"
WriteAttributeValue("", 1180, item.DirectionsId, 1180, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a></th>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\Станкин\Станкин\WebApplication2_4\WebApplication2_3\WebApplication2\WebApplication2\WebApplication2\Views\Directions\Directions.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication2.Models.Directions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
