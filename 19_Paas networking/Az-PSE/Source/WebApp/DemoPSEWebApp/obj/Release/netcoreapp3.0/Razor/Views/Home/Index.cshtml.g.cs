#pragma checksum "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63e849ae2c39e02d02aa0f8d18b9496e0a684d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63e849ae2c39e02d02aa0f8d18b9496e0a684d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/companylogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/eventlogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Demo WebApp PSE Endpoint";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Welcome to the private pse demo Website</h1>
        <p>Learn more about PSE at <a href=""https://www.cloudblogger.at/2019/12/02/azure-service-endpoint-architecture/"" target=""_blank"">my Blog.</a>.</p>        
    </div>
    <div style=""font-family:'Segoe UI';"">
        <div style=""position:fixed; left:20px; top:60px"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d63e849ae2c39e02d02aa0f8d18b9496e0a684d24893", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div style=\"position:fixed; right:20px; top:60px\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d63e849ae2c39e02d02aa0f8d18b9496e0a684d26100", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <h4>Connect to Azure KeyVault and get secred</h4>\r\n        <b>KeyVaultName:</b> ");
#nullable restore
#line 19 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                        Write(ViewBag.KeyVaultName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>KeyVaultIP:</b> ");
#nullable restore
#line 21 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                      Write(ViewBag.KeyVaultIP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>State:</b> ");
#nullable restore
#line 23 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                 Write(ViewBag.KeyVaultConnectionState);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <hr />\r\n        <h4>Connect to database</h4>\r\n        <b>State:</b> ");
#nullable restore
#line 26 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                 Write(ViewBag.SQLConnectionState);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>ServerName:</b> ");
#nullable restore
#line 28 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                      Write(ViewBag.SQLServerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>ServerIP:</b> ");
#nullable restore
#line 30 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                    Write(ViewBag.SQLServerIP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>State:</b> ");
#nullable restore
#line 32 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                 Write(ViewBag.SQLConnectionState);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <br />\r\n        <b>Total SQL entries:</b> ");
#nullable restore
#line 35 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                             Write(ViewBag.SQLEntriesreturn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>First SQL entry:</b> ");
#nullable restore
#line 37 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                           Write(ViewBag.SQLFirstEntry);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <hr />\r\n        <h4>General state</h4>\r\n        <b>Error:</b>  ");
#nullable restore
#line 40 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                  Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>Error Message:</b> ");
#nullable restore
#line 42 "C:\VSCode-Workspace\GitRepos\Priv\PSScripts\Az-PSE\Source\WebApp\DemoPSEWebApp\Views\Home\Index.cshtml"
                         Write(ViewBag.ErrorMSG);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
