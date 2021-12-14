#pragma checksum "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcc2a7e7e178f24efb7e00c81ad7259aaa53f50e"
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
#nullable restore
#line 6 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcc2a7e7e178f24efb7e00c81ad7259aaa53f50e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fce59ba602e1b45291a8eaf0a5e04316d9abcdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var username = ViewBag.Username;
    var rolename = ViewBag.Role;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    let curr,\r\n        listLesson = [],\r\n        listContent = [],\r\n        listCate = [],\r\n        name = ");
#nullable restore
#line 13 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
          Write(Html.Raw(JsonConvert.SerializeObject(username)));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        role = ");
#nullable restore
#line 14 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
          Write(Html.Raw(JsonConvert.SerializeObject(rolename)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
        container = $('.sidebar'),
        menuItems;
    
        
    function renderSibar() {
        $("".sidebar-list"").empty();
        for (let i = 0; i < listCate.length; i++) {
            var listRender = listLesson.filter(x => x.lessonCateId == listCate[i].lessonCateId);
            $("".sidebar-list"").append('<li class=""sidebar-item sidebar-active"" id=""' + listCate[i].lessonCateId + '""><h1 class=""sidebar-link sidebar-link-active"">' + listCate[i].lessonCateName + '</h1></li>');
            for (let i = 0; i < listRender.length;i++) {
                $("".sidebar-list"").append('<li class=""sidebar-item""><a href=""#"" onclick=""return getContent(' + listRender[i].lessonId + ')"" class=""sidebar-link"" id=""' + listRender[i].lessonId+'"">' + listRender[i].lessonName + '</a></li>');
            }
        }
        
        return true;
    }

    function getContent(id) {
        $(""#content-body"").empty();
        curr = id;
        //add active class
        if ($("".sidebar-list"").find(""l");
            WriteLiteral(@"i.active"").length > 0)
            $("".sidebar-list"").find(""li.active"").removeClass(""active"");       
        $("".sidebar-list"").find(""a#"" + id).parent()[0].classList.add(""active"");
        $.ajax({
            ""async"": true,
            ""crossDomain"": true,
            ""url"": """);
#nullable restore
#line 42 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
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
#line 63 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
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
    function getListCate() {
        $.ajax({
            ""async"": false,
            ""crossDomain"": true,
            ""url"": """);
#nullable restore
#line 81 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
               Write(Url.Action("GetListLessonCategories", "LessonCategories"));

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
            listCate = result;

        }).fail(function (xhr) {
            console.log(""get lesson categories failed"");
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

            if (item.content.indexOf(""try-it-btn"") != -1)
                target.last().find(""a.try-it-btn"").attr(""href"", ""/Example/");
            WriteLiteral(@"ExampleView?id="" + item.lessonContentId);
            if (target.html().length > 0) {
                if (index < data.length - 1)
                    target.append(""<hr>"");
            }
        })
    }

    function lessonTraversing(e, cateId) {
        e.preventDefault();
        if ($(""#navbarResponsive"").find(""li>a.active"").length > 0)
            $(""#navbarResponsive"").find(""li>a.active"").removeClass(""active"");       
        
        e.currentTarget.classList.add(""active"");
        
        if ((listCate.filter(x => x.lessonCateId === cateId)).length > 0) {
            let listLessons = listLesson.filter(x => x.lessonCateId === cateId);
            if (listLessons.length > 0)
                getContent(listLessons[0].lessonId);
        }        
    }

    function prevOrNext(type){
        let currIndex = listLesson.findIndex(x => x.lessonId == curr);
        let index = type === 0 ? (currIndex > 0 ? currIndex - 1 : 0) : (type === 1 ? currIndex === listLesson.length - 1 ? curr");
            WriteLiteral(@"Index : currIndex + 1 : 0);
        getContent(listLesson[index].lessonId);
    }
    function fn_next(e) {
        e.preventDefault();
        prevOrNext(0);
    }
    function fn_prev(e) {
        e.preventDefault();
        prevOrNext(0);
    }
    function login() {
        let forAd = '<div class=""dropdown-divider""></div>' +
            '<a href=""#"" onclick=""gotoAdminPage(event)"" class=""dropdown-item"" id=""signout"">' +
            '<i class=""fas fa-user-shield mt-2 mr-3""></i>Go to admin page' +
            '</a>';
        var end = '</div>' +
            '</li>' +
            '</ul>';
        var html = '<ul class=""navbar-nav ml-auto mr-3"">' +
            '<!-- User info -->' +
            '<li class=""nav-item dropdown"">' +
            '<a class=""nav-link"" data-toggle=""dropdown"" href=""#"" style=""font-size:xx-large"">' +
            '<i class=""fas fa-user-circle"" ></i>' +
            '</a>' +
            '<div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">' +
          ");
            WriteLiteral(@"  '<a href=""#"" onclick=""return logout()"" class=""dropdown-item"" id=""signout"">' +
            '<i class=""fas fa-sign-out-alt mt-2 mr-3""></i>Sign out' +
            '</a>' +
            '<div class=""dropdown-divider""></div>' +
            '<a href=""#"" class=""dropdown-item"" id=""signout"">' +
            '<i class=""fas fa-user-edit mt-2 mr-3""></i>' + name +
            '</a>';
        if (name) {            
                
            html += role === 'Administrator' ? forAd +end : end;
            
            $(""#acc"").empty().html(html);
        }
    }
    function gotoAdminPage(e) {
        e.preventDefault();
        location.href = ""/Admin/Index"";
    }
    function logout() {
        $.ajax({
            ""async"": true,
            ""crossDomain"": true,
            ""url"": """);
#nullable restore
#line 180 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
               Write(Url.Action("SignoutWithAjax", "Auth"));

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
            if (result.status === 1) {
                $(""#acc"").empty().html('<div class=""account"">'+
                            '<div class=""login"">'+
                            '<a href=""");
#nullable restore
#line 190 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
                                 Write(Url.Action("Login","Auth"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Đăng Nhập</a>\'+\r\n                            \'</div>\'+\r\n                            \'<div class=\"register\">\'+\r\n                            \'<a href=\"");
#nullable restore
#line 193 "D:\Git project\w3schools\Source\w3schools_WEB\Views\Home\Index.cshtml"
                                 Write(Url.Action("Signup","Auth"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Đăng Ký</a>'+
                            '</div>'+
                        '</div>');
            }

        }).fail(function (xhr) {
            console.log(""Logout failed"");
        });
    }
    menuItems = $(""#navbarResponsive"").find(""a"");
    menuItems.click(function (e) {
        var href = $(this).attr(""href"");          
        updateListSelection(href);
    });      
    function updateListSelection(liID) {
        let scrollTo = $(""ul.sidebar-list"").children(liID);
        container.animate({
            scrollTop: scrollTo.offset().top - container.offset().top + container.scrollTop()
        });
    };
    $(function () {
        getListCate();
        getListLesson();
        login();
        
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
