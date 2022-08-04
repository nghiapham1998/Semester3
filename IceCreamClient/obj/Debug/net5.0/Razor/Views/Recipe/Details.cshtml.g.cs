#pragma checksum "D:\project\IceCream\IceCreamClient\Views\Recipe\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21c69db06fc08c301703613a75a9ae394cba8b92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_Details), @"mvc.1.0.view", @"/Views/Recipe/Details.cshtml")]
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
#line 1 "D:\project\IceCream\IceCreamClient\Views\_ViewImports.cshtml"
using IceCreamClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\IceCream\IceCreamClient\Views\_ViewImports.cshtml"
using IceCreamClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c69db06fc08c301703613a75a9ae394cba8b92", @"/Views/Recipe/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea3f2abc2d066c16db197338c0ab209ca0ace109", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IceCreamClient.Models.Recipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("blog-details.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\project\IceCream\IceCreamClient\Views\Recipe\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "D:\project\IceCream\IceCreamClient\Views\Recipe\Details.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<!-- blog-post -->
<section class=""blog-post centred"" style=""background-image: url(assets/images/background/blog-1.jpg);"">
    <div class=""post-inner"">
        <span class=""category"">Bakery</span>
        <h2>Keeping a healthy diet is important</h2>
        <ul class=""post-info clearfix"">
            <li>on 16 Jul, 2020</li>
            <li>/</li>
            <li><a href=""index.html"">by admin</a></li>
        </ul>
    </div>
</section>
<!-- blog-post end -->
<!-- sidebar-page-container -->
<section class=""sidebar-page-container sec-pad-2 blog-details"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <div class=""col-lg-8 col-md-12 col-sm-12 content-side"">
");
            WriteLiteral("                <div class=\"blog-details-content\">\r\n                    <div class=\"inner-box\">\r\n                        \r\n                        <blockquote>\r\n                            <i class=\"icon-Quote\"></i>\r\n                            <p>“");
#nullable restore
#line 32 "D:\project\IceCream\IceCreamClient\Views\Recipe\Details.cshtml"
                           Write(Model.Ingredents);

#line default
#line hidden
#nullable disable
            WriteLiteral("”</p>\r\n                        </blockquote>\r\n                        <div class=\"text\">\r\n                            <h3>Preparation</h3>\r\n                            <p>");
#nullable restore
#line 36 "D:\project\IceCream\IceCreamClient\Views\Recipe\Details.cshtml"
                          Write(Model.Preparation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""post-share-option clearfix"">
                        <div class=""text pull-left""><h3>We Are Social On:</h3></div>
                        <ul class=""social-links pull-right clearfix"">
                            <li><a href=""blog-details.html""><i class=""fab fa-facebook-f""></i></a></li>
                            <li><a href=""blog-details.html""><i class=""fab fa-twitter""></i></a></li>
                            <li><a href=""blog-details.html""><i class=""fab fa-google-plus-g""></i></a></li>
                        </ul>
                    </div>
");
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-lg-4 col-md-12 col-sm-12 sidebar-side"">
                <div class=""blog-sidebar default-sidebar"">
                    <div class=""sidebar-widget search-widget"">
                        <div class=""widget-title"">
                            <h3>Search</h3>
                        </div>
                        <div class=""widget-content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21c69db06fc08c301703613a75a9ae394cba8b927431", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <input type=\"search\" name=\"search-field\" placeholder=\"Search\"");
                BeginWriteAttribute("required", " required=\"", 2670, "\"", 2681, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\"><i class=\"fas fa-search\"></i></button>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""sidebar-widget sidebar-categories"">
                        <div class=""widget-title"">
                            <h3>Flavor</h3>
                        </div>
                        <div class=""widget-content"">
                            <ul class=""categories-list clearfix"">
                                <li><a href=""blog-details.html"">Vanilla</a></li>
                                <li><a href=""blog-details.html"">Chocolate</a></li>
                                <li><a href=""blog-details.html"">Chocolate chip</a></li>
                                <li><a href=""blog-details.html"">Strawberry</a></li>
                                <li><a href=""blog-details.html"">Mango</a></li>
                                <li><a href=""blog-details.html"">Coffee</a></li>
                                <li><a href=""blog-details.html"">Cherry</a></li>
                                <li><a href=""blog-details.htm");
            WriteLiteral(@"l"">Butterscotch</a></li>
                                <li><a href=""blog-details.html"">Walnut</a></li>
                                <li><a href=""blog-details.html"">Vanilla and strawberry (two in one)</a></li>
                                <li><a href=""blog-details.html"">Pistachio</a></li>
                                <li><a href=""blog-details.html"">Banana</a></li>
                                <li><a href=""blog-details.html"">Banana Chocolate chip</a></li>
                                <li><a href=""blog-details.html"">Chocolate almond</a></li>
                                <li><a href=""blog-details.html"">Chocolate truffle</a></li>
                                <li><a href=""blog-details.html"">Kiwi fruit</a></li>
                                <li><a href=""blog-details.html"">Pineapple</a></li>
                                <li><a href=""blog-details.html"">Fruit and nut</a></li>
                                <li><a href=""blog-details.html"">Cashew Caramel crunch</a></li>
          ");
            WriteLiteral("                  </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- sidebar-page-container end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IceCreamClient.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
