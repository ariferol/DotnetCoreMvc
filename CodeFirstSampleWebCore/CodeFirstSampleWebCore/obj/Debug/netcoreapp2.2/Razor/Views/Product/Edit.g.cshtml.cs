#pragma checksum "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1d287096f72dcc552cf20707c2fc475088d432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Edit.cshtml", typeof(AspNetCore.Views_Product_Edit))]
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
#line 1 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\_ViewImports.cshtml"
using CodeFirstSampleWebCore;

#line default
#line hidden
#line 2 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\_ViewImports.cshtml"
using CodeFirstSampleWebCore.Models;

#line default
#line hidden
#line 4 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1d287096f72dcc552cf20707c2fc475088d432", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91785e01912ab2e7ffca9bf2c8dfe54ca703f399", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntitiesLayer.Models.Products>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(72, 17, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n\n");
            EndContext();
#line 10 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(122, 23, false);
#line 12 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(151, 82, true);
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Product</h4>\n        <hr />\n        ");
            EndContext();
            BeginContext(234, 64, false);
#line 17 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(298, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(308, 40, false);
#line 18 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
   Write(Html.HiddenFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(348, 47, true);
            WriteLiteral("\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(396, 100, false);
#line 21 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.ProductName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(496, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(550, 100, false);
#line 23 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.EditorFor(model => model.ProductName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(650, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(668, 89, false);
#line 24 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.ProductName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(757, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(839, 113, false);
#line 29 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.SupplierId, "SupplierId", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(952, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(1006, 86, false);
#line 31 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.DropDownList("SupplierId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1110, 88, false);
#line 32 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.SupplierId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(1280, 113, false);
#line 37 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.CategoryId, "CategoryId", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(1447, 86, false);
#line 39 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.DropDownList("CategoryId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1551, 88, false);
#line 40 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(1721, 104, false);
#line 45 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.QuantityPerUnit, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1825, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(1879, 104, false);
#line 47 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.EditorFor(model => model.QuantityPerUnit, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(2001, 93, false);
#line 48 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.QuantityPerUnit, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2094, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(2176, 98, false);
#line 53 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.UnitPrice, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(2328, 98, false);
#line 55 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.EditorFor(model => model.UnitPrice, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2426, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(2444, 87, false);
#line 56 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.UnitPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2531, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(2613, 101, false);
#line 61 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.UnitsInStock, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2714, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(2768, 101, false);
#line 63 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.EditorFor(model => model.UnitsInStock, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2869, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(2887, 90, false);
#line 64 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.UnitsInStock, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2977, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(3059, 101, false);
#line 69 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.UnitsOnOrder, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3160, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(3214, 101, false);
#line 71 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.EditorFor(model => model.UnitsOnOrder, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3315, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(3333, 90, false);
#line 72 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.UnitsOnOrder, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3423, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(3505, 101, false);
#line 77 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.ReorderLevel, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3606, 53, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(3660, 101, false);
#line 79 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.EditorFor(model => model.ReorderLevel, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3761, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(3779, 90, false);
#line 80 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.ReorderLevel, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3869, 81, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(3951, 101, false);
#line 85 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.Discontinued, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4052, 96, true);
            WriteLiteral("\n            <div class=\"col-md-10\">\n                <div class=\"checkbox\">\n                    ");
            EndContext();
            BeginContext(4149, 43, false);
#line 88 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
               Write(Html.EditorFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(4192, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(4214, 90, false);
#line 89 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Discontinued, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4304, 266, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 100 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(4572, 11, true);
            WriteLiteral("\n<div>\n    ");
            EndContext();
            BeginContext(4584, 40, false);
#line 103 "E:\Projects\CodeFirst\CodeFirstSampleWebCore\CodeFirstSampleWebCore\Views\Product\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(4624, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntitiesLayer.Models.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591