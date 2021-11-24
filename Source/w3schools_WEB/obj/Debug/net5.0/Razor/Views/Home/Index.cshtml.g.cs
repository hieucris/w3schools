#pragma checksum "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00004d2d92cd8759be1ec4af906462b8e146c9ba"
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
#line 1 "D:\Git project\w3schools\Source\w3schools_WEB\Views\_ViewImports.cshtml"
using w3schools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git project\w3schools\Source\w3schools_WEB\Views\_ViewImports.cshtml"
using w3schools.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00004d2d92cd8759be1ec4af906462b8e146c9ba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fce59ba602e1b45291a8eaf0a5e04316d9abcdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    let listLesson = [];
    let listContent = []

    function renderSibar() {
        $("".sidebar-list"").empty();
        listLesson.forEach(function (item, index) {
            $("".sidebar-list"").append('<li class=""sidebar-item""><a href=""#"" onclick=""return getContent('+item.lessonId+')"" class=""sidebar-link"">'+item.lessonName +'</a></li>');
        });
    }
    function getContent(id) {
        
        $.ajax({
                ""async"": true,
                ""crossDomain"": true,
                ""url"": """);
#nullable restore
#line 20 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
                   Write(Url.Action("RenderContents", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id=""+id,
                ""headers"": {
                    ""Content-Type"": ""application/json"",
                    ""cache-control"": ""no-cache""
                },
                ""method"": ""GET""
        }).done(function (result) {
                renderContent(result,id);
                
            }).fail(function (xhr) {
                console.log(""get contents failed"");
            });
        return false;
    }
    function getListLesson() {
        $.ajax({
                ""async"": true,
                ""crossDomain"": true,
                ""url"": """);
#nullable restore
#line 38 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
                   Write(Url.Action("GetListLesson", "Lesson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                ""headers"": {
                    ""Content-Type"": ""application/json"",
                    ""cache-control"": ""no-cache""
                },
                ""method"": ""GET""
        }).done(function (result) {
                listLesson = result;
            renderSibar(); 
            getContent(listLesson[0].lessonId);
            }).fail(function (xhr) {
                console.log(""get lesson list failed"");
        });
    }
    function renderContent(data, id) {
        var lessonName = (listLesson.filter(x => x.lessonId == id))[0].lessonName;
        $("".content-title"").text(lessonName);
        var target = $(""#content-body"");
        target.empty();
        data.forEach(function (item, index) {
            var title = item.contentTitle ? item.contentTitle : """";
            var html = '<div class=""text-block"">' +
                '<h2 class=""text-title"">' + title + '</h2>' + item.content + '</div>';
           
            target.append(html);
            
        ");
            WriteLiteral(@"    if (item.content.indexOf(""try-it-btn"") != -1)
                target.last().find(""a.try-it-btn"").attr(""href"", ""/Example/ExampleView?id="" + item.lessonContentId);
            if (target.html().length > 0) {
                if (index < data.length - 1)
                    target.append(""<hr>"");
            }
        })
    }
    $(function () {

        getListLesson();        
    })
</script>



");
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
