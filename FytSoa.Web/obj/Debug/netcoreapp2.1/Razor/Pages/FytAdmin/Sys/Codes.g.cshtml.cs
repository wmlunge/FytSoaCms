#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\Codes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581b8c42eeceb04e270e2e0e89df44fa9ed8e8ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_Codes), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sys/Codes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sys/Codes.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_Codes), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581b8c42eeceb04e270e2e0e89df44fa9ed8e8ca", @"/Pages/FytAdmin/Sys/Codes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sys_Codes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/ztree/css/metroStyle/metroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\Codes.cshtml"
  
    ViewData["Title"] = "字典管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(141, 1341, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""layui-col-220"">
        <div class=""layui-nav-title"">字典管理　<button class=""layui-btn layui-btn-sm"" id=""code-class-add""><i class=""layui-icon""></i>添加</button></div>
        <ul id=""code-tree"" class=""ztree layui-tree-cus""></ul>
        <div class=""tree-footer"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""typeEdit""><i class=""layui-icon""></i> 修改</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""typeDel""><i class=""layui-icon""></i> 删除</button>
        </div>
    </div>
    <div class=""right-col-body"">
        <div class=""list-wall"">
            <div class=""layui-form list-search"">
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""codeAdd""><i class=""layui-icon""></i> 新增</button>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""codeDel""><i class=""layui-icon""></i> 删除</button>
            </div>
            <table class=""layui-hide"" id=""tabl");
            WriteLiteral(@"ist"" lay-filter=""tool""></table>
        </div>
    </div>
    <script type=""text/html"" id=""switchTpl"">
        <!-- 这里的 checked 的状态只是演示 -->
        <input type=""checkbox"" name=""status"" value=""{{d.guid}}"" lay-skin=""switch"" lay-text=""ON|OFF"" lay-filter=""statusedit"" {{ d.status?'checked':''}}>
    </script>
    ");
            EndContext();
            BeginContext(1482, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "674fd69fb537451dacf11e301129bc9c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1573, 6909, true);
            WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'ztree', 'common'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    ztree = layui.ztree,
                    os = layui.common,
                    form = layui.form;
                table.render({
                    elem: '#tablist',
                    url: '/api/code/getpages',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'name', title: '字典名称', sort: true, fixed: 'left' },
                            { field: 'codeType', title: '阈值' }, { field: 'sort', width: 150, title: '顺序', sort: true },
                            { field: 'status', width: 150, title: '状态', templet: '#switchTpl' },
                            { width: 100, title: '操作', t");
            WriteLiteral(@"emplet: '#tool' }
                        ]
                    ],
                    page: true,
                    id: 'tables'
                });
                //监听状态操作
                form.on('switch(statusedit)', function (obj) {
                    var index = layer.load(1, {
                        shade: [0.1, '#000']
                    });
                    os.ajax('api/code/editstatus', { guid: this.value, status: obj.elem.checked }, function (res) {
                        if (res.statusCode === 200) {
                            os.success('状态更改成功~');
                            layer.close(index);
                        } else {
                            os.error(res.message);
                        }
                    });
                });
                var setting = {
                    async: {
                        enable: true,
                        url: ""/api/codetype/gettree""
                    },
                    callback: {
           ");
            WriteLiteral(@"             onClick: onClick
                    }
                };
                var guid = '', typeName = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    guid: guid
                                }
                            });
                    },
                    typeEdit: function () {
                        os.Open('字典修改', '/fytadmin/sys/codesmodify/?guid=' + guid, '500px', '280px', function () {
                            $.fn.zTree.init($(""#code-tree""), setting);
                        });
                    },
                    typeDel: function () {
                        layer.confirm('确定要删除 ' + typeName + ' 吗？', function (index) {
                            layer.close(index);
");
            WriteLiteral(@"                            os.ajax('api/codetype/delete/', { guid: guid }, function (res) {
                                if (res.statusCode === 200) {
                                    $.fn.zTree.init($(""#code-tree""), setting);
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    },
                    codeAdd: function () {
                        if (!guid) {
                            os.error(""请选择左侧字典类型~"");
                            return;
                        }
                        os.Open('添加字典值', '/fytadmin/sys/codesvalmodify/?guid=' + guid, '620px', '370px', function () {
                            active.reload();
                        });
                    },
                    codeDel: function () {
                        var checkStatus = ");
            WriteLiteral(@"table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/code/delete/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    os.success('删除成功！');");
            WriteLiteral(@"
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    }
                };
                //添加栏目
                $('#code-class-add').on('click',
                    function () {
                        os.Open('字典栏目', '/fytadmin/sys/codesmodify/', '500px', '280px', function () {
                            $.fn.zTree.init($(""#code-tree""), setting);
                        });
                    });

                $.fn.zTree.init($(""#code-tree""), setting);

                $('.tree-footer .layui-btn,.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                function onClick(event, treeId, treeNode, clickFlag) {
                    $("".tree-footer"").addClass(""active"");
         ");
            WriteLiteral(@"           guid = treeNode.guid;
                    typeName = treeNode.name;
                    active.reload();
                }
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑字典值', '/fytadmin/sys/codesvalmodify/?guid=' + data.guid, '620px', '370px', function () {
                            active.reload();
                        })
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sys.CodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.CodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.CodesModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sys.CodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
