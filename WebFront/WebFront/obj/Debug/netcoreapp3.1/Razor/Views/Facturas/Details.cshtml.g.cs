#pragma checksum "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "772ca0394dbc18bb75b3e2056004df7177d47733"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facturas_Details), @"mvc.1.0.view", @"/Views/Facturas/Details.cshtml")]
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
#line 1 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\_ViewImports.cshtml"
using WebFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\_ViewImports.cshtml"
using WebFront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772ca0394dbc18bb75b3e2056004df7177d47733", @"/Views/Facturas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70702422976367dcd5e7c5ead97e338c5218c5ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Facturas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebFront.Models.Facturas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Facturas</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.idFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipodePago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipodePago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DocumentoCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.DocumentoCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IVA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.IVA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalDescuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalDescuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalImpuesto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalImpuesto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 82 "C:\WLPEREZ\Proyectos\WebFactura\WebFront\WebFront\Views\Facturas\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "772ca0394dbc18bb75b3e2056004df7177d4773311148", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebFront.Models.Facturas> Html { get; private set; }
    }
}
#pragma warning restore 1591