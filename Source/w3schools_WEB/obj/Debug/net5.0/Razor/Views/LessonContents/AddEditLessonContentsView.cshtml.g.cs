#pragma checksum "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "390d6199f5a2a1cba1909c9d9090d2f5caaca0e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LessonContents_AddEditLessonContentsView), @"mvc.1.0.view", @"/Views/LessonContents/AddEditLessonContentsView.cshtml")]
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
#line 1 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\_ViewImports.cshtml"
using w3schools;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\_ViewImports.cshtml"
using w3schools.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
using w3schools_API.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390d6199f5a2a1cba1909c9d9090d2f5caaca0e9", @"/Views/LessonContents/AddEditLessonContentsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fce59ba602e1b45291a8eaf0a5e04316d9abcdf", @"/Views/_ViewImports.cshtml")]
    public class Views_LessonContents_AddEditLessonContentsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<w3schools_API.Models.LessonContents>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
  
    Layout = "Admin_Layout";
    ViewData["Title"] = "Add&Edit Lesson Contents";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
  
    var data = Model;
    var rOrder = ViewBag.RowOrder;
    var meth = ViewBag.Method;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid p-5"">
    <div class=""mt-5 row"">
        <div class=""col-md-6"">
            <div class=""form-group"">
                <h5>Content Title:</h5>
                <div class=""w-75"" id=""ContentTitle""></div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <h5>Content Type:</h5>
                <div class=""w-75"" id=""ContentTypeId""></div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <h5>Lesson Content Id:</h5>
                <div class=""w-75"" id=""LessonContentId""></div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <h5>Content Order:</h5>
                <div class=""w-75"" id=""ContentOrder""></div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""form-group"">
                <h5>Lesson:</h5>
                <div");
            WriteLiteral(@" class=""w-75"" id=""LessonId""></div>
            </div>
        </div>
        <div class=""col-md-6 text-right"" id=""htmlSaveBtn""></div>
        <h5>Content:</h5>
        <div class=""col-md-12"" id=""ctner"">

        </div>
    </div>
</div>
<style>
    #framesize {
        position: absolute;
        right: 2rem;
        top: 40%
    }

    #rotate {
        border: unset;
        padding: 0 0;
    }
    .row {
        font-family: fontawesome;
    }
    textarea:focus {
        outline: none !important;
        border: 1px solid #808080;
        box-shadow: 0 0 0.2rem #0094ff;
    }
    #ctner {
        background-color: #E7E9EB;
        /*margin-top: 8rem;*/
    }
    #targetCode {
        background-color: #fff !important;
        border: unset;
    }
</style>
<script>

    var data =  ");
#nullable restore
#line 83 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
           Write(Html.Raw(JsonConvert.SerializeObject(data)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var currContentType = data.ContentTypeId;\r\n    var editor;\r\n    var content=\"\";\r\n    var iframe;\r\n    var method = ");
#nullable restore
#line 88 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
            Write(Html.Raw(JsonConvert.SerializeObject(meth)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var order = ");
#nullable restore
#line 89 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
           Write(Html.Raw(JsonConvert.SerializeObject(rOrder)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    const contentTypeStore = new DevExpress.data.CustomStore({
        key: ""contentTypeId"",
        loadMode:""raw"",
        load: function () {
            var d = $.Deferred();
            $.ajax({
                ""async"": false,
                ""crossDomain"": true,
                ""url"": """);
#nullable restore
#line 99 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
                   Write(Url.Action("GetListContentType", "ContentType"));

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
                d.resolve(result);
            }).fail(function (xhr) {
                console.log(""failed"");
            });
            return d.promise();
        }
    });

    const lessonStore = new DevExpress.data.CustomStore({
        key: ""lessonId"",
        loadMode:""raw"",
        load: function () {
            var d = $.Deferred();
            $.ajax({
                ""async"": false,
                ""crossDomain"": true,
                ""url"": """);
#nullable restore
#line 122 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
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
                d.resolve(result);
            }).fail(function (xhr) {
                console.log(""failed"");
            });
            return d.promise();
        }
    });

    const TitleTxtBox = $(""#ContentTitle"").dxTextBox({
        value: data.ContentTitle
    }).dxTextBox(""instance"");

    const LessonContentIdTxtBox = $(""#LessonContentId"").dxTextBox({
        value: data.LessonContentId,
        readOnly: true,
        hoverStateEnabled: false
    }).dxTextBox(""instance"");

    const ContentTypeIdSelectBox = $(""#ContentTypeId"").dxSelectBox({
        dataSource: contentTypeStore,
        displayExpr: ""contentTypeName"",
        valueExpr: ""contentTypeId"",
        value: currContentType,
        onValueChanged: function (e) {
            currConten");
            WriteLiteral(@"tType = e.value;
            renderEditor();
        }
    }).dxValidator({
        validationGroup: ""data"",
        validationRules: [{
            type: ""required"",
            message: "" is required""
        }]
    }).dxSelectBox(""instance"");

    const ContentOrderTxtBox =
        $(""#ContentOrder"").dxNumberBox({
            value: data.ContentOrder ? data.ContentOrder : order,
        }).dxValidator({
            validationGroup: ""data"",
            validationRules: [{
                type: ""required"",
                message: "" is required""
            }]
        }).dxNumberBox  (""instance"");

    const LessonTxtBox = $(""#LessonId"").dxSelectBox({
        value: data.LessonId,
        dataSource: lessonStore,
        displayExpr: ""lessonName"",
        valueExpr: ""lessonId"",
        onValueChanged: function (e) {

        }
    }).dxValidator({
        validationGroup: ""data"",
        validationRules: [{
            type: ""required"",
            message: "" is required""
 ");
            WriteLiteral(@"       }]
    }).dxSelectBox(""instance"");

    function getSize() {
        iframe = document.getElementById('targetCode');
        $(""#framesize"").find(""span"").text(""Result Size: "" + iframe.contentWindow.innerWidth + "" x "" + iframe.contentWindow.innerHeight);
    }

    function renderEditor(){
        if (currContentType === 2) {
            $(""#htmlSaveBtn"").html('<button id = ""saveBtn"" onclick = ""saveEdit()""  class=""pl-3 pr-3 mr-3 btn btn-success"" > Save <i class=""pl-2 pr-2 fa fa-save""></i></button >');
            $(""#ctner"").html('<div style=""background-color:#fff"" class=""m-4"" id=""Content"">')
            editor = $(""#Content"").dxHtmlEditor({
                height: 300,
                value: data.Content,
                toolbar: {
                    items: [
                        'undo', 'redo', 'separator',
                        {
                            name: 'size',
                            acceptedValues: ['8pt', '10pt', '12pt', '14pt', '18pt', '24pt', '36pt'],
   ");
            WriteLiteral(@"                     },
                        {
                            name: 'font',
                            acceptedValues: ['Arial', 'Courier New', 'Georgia', 'Impact', 'Lucida Console', 'Tahoma', 'Times New Roman', 'Verdana'],
                        },
                        'separator', 'bold', 'italic', 'strike', 'underline', 'separator',
                        'alignLeft', 'alignCenter', 'alignRight', 'alignJustify', 'separator',
                        'orderedList', 'bulletList', 'separator',
                        {
                            name: 'header',
                            acceptedValues: [false, 1, 2, 3, 4, 5],
                        }, 'separator',
                        'color', 'background', 'separator',
                        'link', 'image', 'separator',
                        'clear', 'codeBlock', 'blockquote', 'separator',
                        'insertTable', 'deleteTable',
                        'insertRowAbove', 'insertRowBelow', 'deleteRo");
            WriteLiteral(@"w',
                        'insertColumnLeft', 'insertColumnRight', 'deleteColumn',
                    ],
                }, onValueChanged: function (e) {
                    content = e.value;
                }
            }).dxHtmlEditor(""instance"");

        } else if (currContentType === 1 || currContentType ===3) {
            $(""#htmlSaveBtn"").empty();
            var code;
            if (data.Content != null) {
                if (currContentType === 1)
                    code =  data.Content;
                else
                    code = '<div class=""main-content"">\n    <div class=""example"">\n        <h3>Example</h3>\n        <div class=""w3-code"">\n            <\!-- start css-block -->\n' + data.Content + '\n \n \n \n \n \n            <\!-- end css-block -->\n        </div>\n        <a class="" try-it-btn btn-link"" target=""_blank"" href="""">Try it Yourself >></a>\n    </div>\n</div>';
            } else {
                if (currContentType === 1)
                    code = conte");
            WriteLiteral(@"nt ? content: """";
                else
                    code = '<div class=""main-content"">\n    <div class=""example"">\n        <h3>Example</h3>\n        <div class=""w3-code"">\n            <\!-- start css-block -->\n            <\!-- end css-block -->\n        </div>\n        <a class=""try-it-btn btn-link"" target=""_blank"" href="""">Try it Yourself >></a>\n    </div>\n</div>';
            }

            var html = '<div class=""w-100"" id=""Content""><div class=""row"">'+
                '<div class=""p-1 col-sm-12"">'+
                    '<div id = ""btns"" class=""ml-md-5"">'+
                        '<button onclick=""rotate()"" class=""btn mr-2"" id=""rotate"">'+
                            '<img class=""img-fluid""src=""../image/iconb.png""/>'+
                        '</button>'+
                        '<button id=""runBtn"" class=""btn btn-success pl-3 pr-2 mr-2"">Run<i class=""pl-2 pr-2 fa fa-chevron-right""></i></button>' +
                        '<button id=""saveBtn"" onclick=""saveEdit()"" class=""pr-2 mr-2 btn btn-");
            WriteLiteral(@"success""> Save <i class=""pl-2 pr-2 fa fa-save""></i></button></div>'+
                    '<div id=""framesize"" style="""">' +
                    '<span>Result Size:</span>' +
                '</div>' +
                    '</div>' +

                '</div>' +
                '<div class=""row"">' +
                    '<div class=""workspace col-md-6 pr-md-1 p-1"">' +
                    '<textarea class=""p-2"" name=""sourceCode"" id=""sourceCode"">' + code +
                    '</textarea>' +
                    '</div>' +
                    '<div class=""workspace col-md-6 pl-md-1 p-1"">' +
                    '<iframe class=""p-2""name=""targetCode"" id=""targetCode""></iframe>' +
                '</div>' +
                '</div>'+
            '</div>';

            $(""#ctner"").html(html);

            editor = CodeMirror.fromTextArea($(""#sourceCode"")[0], {
                lineNumbers: true,
            });
            editor.on(""change"", function (cm) {
                content = cm.getValue();
 ");
            WriteLiteral(@"               $(""#sourceCode"").html(content);
            });
            editor.setSize(""100%"", ""75vh"");

            var bUrl = ""https://localhost:44322"";
            var header =
                '<meta charset=""utf-8""/><meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />' +
                '<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css""/>' +
                '<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""><\/script>' +
                '<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""><\/script>' +
                '<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""><\/script>' +
                '<script type=""text/javascript"" src=""http://js.nicedit.com/nicEdit-latest.js""><\/script>' +
                '<!--front-end-->' +                
                '<link href=""' + bUrl + '/css/site.css"" rel=""stylesheet""/>' +
        ");
            WriteLiteral(@"        '<link href=""' + bUrl + '/css/base.css"" rel=""stylesheet""/>' +
                '<!--font-awesome-->' +
                '<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">';

            iframe = document.getElementById('targetCode');
            iframe.contentDocument.head.innerHTML = header;

            $(""#runBtn"").click(function () {
                content = $(""#sourceCode"").val();                
                runCode();
            });           
            getSize();
        }
    }

    function saveEdit() {
        var valid = DevExpress.validationEngine.validateGroup(""data"");
        if (valid.isValid) {
            if (currContentType == 2) {
                content = editor.option(""value"");
            } else if (currContentType == 1 || currContentType == 3) {
                content = $(""#sourceCode"").val();
            }

            var obj = {};
            obj[""ContentOrder""] = ContentOrderTxtBo");
            WriteLiteral(@"x.option(""value"");
            obj[""LessonId""] = LessonTxtBox.option(""value"");
            obj[""Content""] = content;
            obj[""ContentTitle""] = TitleTxtBox.option(""value"");
            obj[""LessonContentId""] = LessonContentIdTxtBox.option(""value"");
            obj[""ContentTypeId""] = ContentTypeIdSelectBox.option(""value"");
            obj[""Content""] = content;
            $.ajax({
                ""async"": true,
                ""method"": ""POST"",
                ""crossDomain"": true,
                ""data"": JSON.stringify(obj),
                ""url"": """);
#nullable restore
#line 331 "C:\Users\HieuCris\Downloads\website\Source\w3schools_WEB\Views\LessonContents\AddEditLessonContentsView.cshtml"
                   Write(Url.Action("AddEditLessonContentsMethod", "LessonContents"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?method="" + method,
                ""headers"": {
                    ""Content-Type"": ""application/json"",
                    ""cache-control"": ""no-cache""
                }
            }).done(function (result) {
                if (result.data.status == 1)
                    DevExpress.ui.notify(result.data.message, ""success"", 2000);
                else
                    DevExpress.ui.notify(result.data.message, ""warning"", 2000);
            }).fail(function (xhr) {
                DevExpress.ui.notify(""Error!Not completed"", ""warning"", 2000);
            });
        }
    }

    function rotate() {
        var target = $("".workspace"");
        if (target.hasClass(""col-md-6"")) {
            target.removeClass(""col-md-6"").addClass(""col-md-12"");
            target.children().css(""height"", ""18rem"");
        } else if (target.hasClass(""col-md-12"")) {
            target.removeClass(""col-md-12"").addClass(""col-md-6"");
            target.children().css(""height"", ""33rem"");
        }
        ");
            WriteLiteral(@"getSize();
    }

    function runCode() {
        iframe = document.getElementById('targetCode');
        iframe = iframe.contentDocument;
        //iframe.document.open();

        /*iframe.document.getElementsByTagName('body')[0].innerHTML = content;*/
        
        //iframe.document.write(content);
        //iframe.document.close();
        iframe.body.innerHTML = content;
    }

    $(function () {
        window.addEventListener(""resize"", getSize);
        //render editor
        renderEditor();
        $("".breadcrumb"").empty().append('<li class=""breadcrumb-item""><span>Home</span></li>'+
            '<li class= ""breadcrumb-item active""><a href=""/LessonContents/Index"">Lesson Content</a></li > ' +
            '<li class= ""breadcrumb-item active""><span>Add & Edit</span></li>'
        );        
    });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<w3schools_API.Models.LessonContents> Html { get; private set; }
    }
}
#pragma warning restore 1591
