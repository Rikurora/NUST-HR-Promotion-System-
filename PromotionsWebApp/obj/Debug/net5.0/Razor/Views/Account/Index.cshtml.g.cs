#pragma checksum "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ccd11ab72a06c7f168f728641eeb0c44bbeb602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\_ViewImports.cshtml"
using PromotionsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ccd11ab72a06c7f168f728641eeb0c44bbeb602", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe3f0cc88de9c1478aa5821a772eca9dbc2a0a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tooltipped"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-position", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tooltip", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn waves-effect waves-light btn-large green lighten-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating blue tooltipped"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-position", new global::Microsoft.AspNetCore.Html.HtmlString("left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tooltip", new global::Microsoft.AspNetCore.Html.HtmlString("Create User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Users";
    string Search = "";
    if (ViewData["CurrentFilter"] != null)
        Search = ViewData["CurrentFilter"].ToString();
    string LinkUrl = "Index";
    string LinkArea = "Account";
    var prevDisabled = "True";
    var nextDisabled = "True";
    var prevPageNr = 1;
    var nextPageNr = 1;
    if (Model.Users.Count > 0)
    {
        prevDisabled = !Model.Users.HasPreviousPage ? "disabled" : "";
        nextDisabled = !Model.Users.HasNextPage ? "disabled" : "";
        prevPageNr = Model.Users.PageIndex - 1;
        nextPageNr = Model.Users.PageIndex + 1;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h4 class=\"center-align\">Users</h4>\r\n    <div class=\"divider\"></div>\r\n");
#nullable restore
#line 29 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
     if (Model.Users.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col s12\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
       Write(await Component.InvokeAsync("Search", new { model = new SearchViewComponent.SearchViewModel(Search, LinkUrl, LinkArea) }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <ul class=\"collection\">\r\n");
#nullable restore
#line 34 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                 foreach (UserVM user in Model.Users)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"collection-item avatar\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1287, "\"", 1360, 2);
            WriteAttributeValue("", 1293, "data:image;base64,", 1293, 18, true);
#nullable restore
#line 37 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
WriteAttributeValue("", 1311, System.Convert.ToBase64String(user.ProfileImage), 1311, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"80\" height=\"80\" class=\"circle\">\r\n                        <span class=\"Title\">\r\n                            ");
#nullable restore
#line 39 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                       Write(user.ToUserString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                        <p>\r\n                            Deparment: ");
#nullable restore
#line 42 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                                  Write(user.Department.GetEnumDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                            Role: ");
#nullable restore
#line 43 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                             Write(user.Role.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <span class=\"secondary-content\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ccd11ab72a06c7f168f728641eeb0c44bbeb60211201", async() => {
                WriteLiteral("<i class=\"material-icons\">edit</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                                                          WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a id=\"submitConfirmBtn\" href=\"#confirmationModal\"");
            BeginWriteAttribute("onclick", "\r\n                               onclick=\"", 2047, "\"", 2134, 4);
            WriteAttributeValue("", 2089, "initConfirmModal(\'Delete\',", 2089, 26, true);
            WriteAttributeValue(" ", 2115, "\'User\',\'", 2116, 9, true);
#nullable restore
#line 48 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
WriteAttributeValue("", 2124, user.Id, 2124, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2132, "\')", 2132, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"
                               class=""tooltipped"" data-position=""top"" data-tooltip=""Delete User"">
                                <i class=""material-icons"">delete</i>
                            </a>
                        </span>
                    </li>
");
#nullable restore
#line 54 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col s12 m12 l12"">
            <div class=""card-panel blue darken-2 center-align"">
                <span class=""white-text"">
                    No Users are currently existing in the system.
                </span>
            </div>
        </div>
");
#nullable restore
#line 67 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"center-align\">\r\n        ");
#nullable restore
#line 69 "C:\Users\Janey Gaimgos\source\repos\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
   Write(await Component.InvokeAsync("Pager", new
        {
            model = new PagerViewComponent.PagerViewModel
                        (prevPageNr, nextPageNr, Search, LinkUrl, LinkArea, nextDisabled, prevDisabled)
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"input-field col s12 center-align \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ccd11ab72a06c7f168f728641eeb0c44bbeb60216324", async() => {
                WriteLiteral("\r\n                <span class=\"material-icons md-dark md-24 matIcon\">\r\n                    keyboard_return\r\n                </span>\r\n                <span class=\"black-text\">Back</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"fixed-action-btn\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ccd11ab72a06c7f168f728641eeb0c44bbeb60218060", async() => {
                WriteLiteral("\r\n            <i class=\"large material-icons\">add</i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersVM> Html { get; private set; }
    }
}
#pragma warning restore 1591