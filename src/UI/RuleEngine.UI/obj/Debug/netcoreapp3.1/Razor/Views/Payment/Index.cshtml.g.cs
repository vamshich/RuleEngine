#pragma checksum "D:\Assignment\RuleEngine\RuleEngine\src\UI\RuleEngine.UI\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43651bf15ffa331f1021924b38b915da1a0a69ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
#line 1 "D:\Assignment\RuleEngine\RuleEngine\src\UI\RuleEngine.UI\Views\_ViewImports.cshtml"
using RuleEngine.UI;

#line default
#line hidden
#line 2 "D:\Assignment\RuleEngine\RuleEngine\src\UI\RuleEngine.UI\Views\_ViewImports.cshtml"
using RuleEngine.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43651bf15ffa331f1021924b38b915da1a0a69ae", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d606381921dd8cf5e1064adae22e43e7dc8a98", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Assignment\RuleEngine\RuleEngine\src\UI\RuleEngine.UI\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Payment ";
    ViewBag.PaymentTypes = new List<string>{
               "Physical product",
                "Book",
                "Membership",
                "Upgrade",
                "Learning to Ski video"
            };

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Payment Engine</h1>\r\n    <br />\r\n");
#line 15 "D:\Assignment\RuleEngine\RuleEngine\src\UI\RuleEngine.UI\Views\Payment\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            WriteLiteral("        <fieldset>\r\n            Payment Type:\r\n            ");
#line 19 "D:\Assignment\RuleEngine\RuleEngine\src\UI\RuleEngine.UI\Views\Payment\Index.cshtml"
       Write(Html.DropDownList("PaymentType", new SelectList(ViewBag.PaymentTypes), "Select Payment Type"));

#line default
#line hidden
            WriteLiteral("\r\n            <p>\r\n                <br />\r\n                <input type=\"submit\" value=\"Submit\" onclick=\"return PaymentSelection()\" />\r\n            </p>\r\n        </fieldset>\r\n");
#line 25 "D:\Assignment\RuleEngine\RuleEngine\src\UI\RuleEngine.UI\Views\Payment\Index.cshtml"
    }

#line default
#line hidden
            WriteLiteral("\r\n    <div>\r\n        <h6>Operation Performed:</h6>\r\n        <p style=\"color:green\"> ");
#line 29 "D:\Assignment\RuleEngine\RuleEngine\src\UI\RuleEngine.UI\Views\Payment\Index.cshtml"
                           Write(ViewBag.Result);

#line default
#line hidden
            WriteLiteral(@" </p>
    </div>
</div>


<script type=""text/javascript"">
    function PaymentSelection()
    {
        var selection = document.getElementById('PaymentType').value;
        if (selection == '') {
            alert(""Select a payment type"");
            return false;
        }
        return true;
    }
</script>");
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
