#pragma checksum "C:\Users\user\Desktop\CWork\IMDBanalog\IMDBanalog\Areas\Identity\Pages\_AuthLayot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47028f2f85123d7f863c99c2152e36080cc500c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayot), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayot.cshtml")]
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
#line 1 "C:\Users\user\Desktop\CWork\IMDBanalog\IMDBanalog\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\CWork\IMDBanalog\IMDBanalog\Areas\Identity\Pages\_ViewImports.cshtml"
using IMDBanalog.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\CWork\IMDBanalog\IMDBanalog\Areas\Identity\Pages\_ViewImports.cshtml"
using IMDBanalog.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\CWork\IMDBanalog\IMDBanalog\Areas\Identity\Pages\_ViewImports.cshtml"
using IMDBanalog.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a47028f2f85123d7f863c99c2152e36080cc500c", @"/Areas/Identity/Pages/_AuthLayot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b161f1e72160c473f37b92ff1d302fbf34f238b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\CWork\IMDBanalog\IMDBanalog\Areas\Identity\Pages\_AuthLayot.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    ");
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css2?family=Roboto&display=swap');

    body {
        font-family: 'Roboto', sans-serif;
    }
    .card-header ul{
        display:flex;
        flex-shrink:1;
        justify-content:space-between;
    }
    .nav-item {
        width: 50%;
        color: black;
    }

    .nav-item a {
        padding-left:37%;
        color:black;
    }


    body {
        
    }

    /*for tab control*/
    .div.login-logout-tab div.card-header {
        padding: 0px 0px 12px 0px;
    }

    .div.login-logout-tab ul.nav-tabs {
        margin: 0px 0px -12px 0px;
    }

    .div.login-logout-tab li.nav-item {
        width: 50%;
    }

    .div.login-logout-tab a.nav-link {
        font-size: 25px;
        color: #495057;
        text-align: center;
    }

    .div.card-content {
        padding: 10px 20px;
    }

    /*login form*/
    .login-form-icon {
        margin-top: 5%;
        display:flex;
        justify-content:center;
 ");
            WriteLiteral(@"       
    }

    .login-form-icon img{
        border:none;
    }




</style>


    <div class=""row "">
        <div class=""col-md-6 offset-md-3"">
            <div class="" card login-logout-tab"">
                <div class=""card-header"">
                    <ul class=""nav nav-tabs card-header-tabs"">
                        <li class=""nav-item"">
                            <a class=""nav-link "" href=""/Identity/Account/Login"">Sign In</a>
                        </li>

                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Identity/Account/Register"">Sing Up</a>
                        </li>
                    </ul>
                </div>
                <div class=""card-content"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            ");
#nullable restore
#line 90 "C:\Users\user\Desktop\CWork\IMDBanalog\IMDBanalog\Areas\Identity\Pages\_AuthLayot.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 100 "C:\Users\user\Desktop\CWork\IMDBanalog\IMDBanalog\Areas\Identity\Pages\_AuthLayot.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

<script>

    $(function () {
        var current = location.pathname;
        $('.nav-tabs li a').each(function () {
            var $this = $(this);
            if (current.indexOf($this.attr('href')) !== -1) {
                console.log($this);
                $this.addClass('active');
            }
        })
    })
</script>
");
            }
            );
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
