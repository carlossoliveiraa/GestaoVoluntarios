#pragma checksum "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3e543faefee29ee4afca58aad8ec6cead0c6bd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VoluntariosFemininoInativos_Index), @"mvc.1.0.view", @"/Views/VoluntariosFemininoInativos/Index.cshtml")]
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
#line 1 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\_ViewImports.cshtml"
using GestaodeVoluntarios.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\_ViewImports.cshtml"
using GestaodeVoluntarios.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e543faefee29ee4afca58aad8ec6cead0c6bd4", @"/Views/VoluntariosFemininoInativos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f128bb8fdacca7b3a6dbd4351918fdc4c4e65d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VoluntariosFemininoInativos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestaodeVoluntarios.UI.Models.Feminino.FemininoCadastro>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "A", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "B1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "B2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "C1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "C2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "D-E", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-sm-12"">
    <div class=""page-header card"">
        <div class=""card-block"">
            <h5 class=""m-b-10"">Voluntário Feminino Inativos</h5>
            <ul class=""breadcrumb-title b-t-default p-t-10"">
                <li class=""breadcrumb-item"">
                    <a href=""\Home\index""> <i class=""fa fa-home""></i> </a>
                </li>
                <li class=""breadcrumb-item"">
                    <a href=""\VoluntariosFemininoInativos\index"">Voluntário Feminino Inativo</a>
                </li>
            </ul>
        </div>
    </div>
    <div class=""page-header card"">
        <div class=""card-block"">
            <fieldset class=""border p-3"">
                <h4 class=""sub-title"">Filtros</h4>
                <div class=""form-group row"">
                    <div class=""col-sm-2"">
                        <input type=""number"" min=""0"" max=""100000"" id=""femininoId"" class=""form-control"" placeholder=""Registro: "">
                    </div>
                    <div cl");
            WriteLiteral("ass=\"col-sm-2\">\r\n                        <select id=\"cboClasseSocial\" class=\"form-control form-control-bold\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e543faefee29ee4afca58aad8ec6cead0c6bd46652", async() => {
                WriteLiteral("-- Classe Social --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e543faefee29ee4afca58aad8ec6cead0c6bd47852", async() => {
                WriteLiteral("A");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e543faefee29ee4afca58aad8ec6cead0c6bd49034", async() => {
                WriteLiteral("B1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e543faefee29ee4afca58aad8ec6cead0c6bd410217", async() => {
                WriteLiteral("B2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e543faefee29ee4afca58aad8ec6cead0c6bd411401", async() => {
                WriteLiteral("C1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e543faefee29ee4afca58aad8ec6cead0c6bd412585", async() => {
                WriteLiteral("C2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e543faefee29ee4afca58aad8ec6cead0c6bd413769", async() => {
                WriteLiteral("D-E");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""col-sm-2"">
                        <input type=""number"" min=""0"" max=""100"" id=""idadeDe"" class=""form-control"" placeholder=""Idade De:"">
                    </div>
                    <div class=""col-sm-2"">
                        <input type=""number"" min=""0"" max=""100"" id=""idadeAte"" class=""form-control"" placeholder=""Idade Até:"">
                    </div>
                    <div class=""col-sm-3"">
                        <input type=""text"" id=""nome"" class=""form-control"" placeholder=""Busca por Nome"">
                    </div>
                    <div class=""col-sm-1"">
                        <button class=""btn btn-danger btn-sm pull-center"" type=""button"" id=""FiltrarnoBackEnd"">Filtrar</button>
                    </div>
                </div>
            </fieldset>

            <input type=""text"" id=""myInput"" style=""display:none"">
            <div class=""col-sm-12 col-md-12 col-xl-12"">
               ");
            WriteLiteral(@" <div id=""alerta"" class=""alert alert-danger"" style=""display:none"">
                    <p><strong>Mensagem: </strong><code>Informações copiadas com sucesso!</code></p>
                </div>
            </div>

            <div class=""dt-responsive table-responsive"">
                <div class=""page-header card"">
                    <div class=""card-block"">
                        <div class=""form-group row"">

                            <div class=""col-sm-12"">
                                <input type=""text"" id=""search"" class=""form-control"" placeholder=""Faça sua pesquisa aqui"">
                            </div>
                        </div>
                        <div class=""dt-responsive table-responsive"">
                            <table id=""tbFemininoCadastro"" class=""table table-striped table-bordered nowrap"">
                                <thead>
                                    <tr>
                                        <th>Ação</th>
                                     ");
            WriteLiteral("   <th>Registro</th>\r\n                                        <th>Nome</th>\r\n                                        <th>Idade</th>\r\n                                        <th>Classe Social</th>\r\n");
#nullable restore
#line 76 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
                                         if (ViewBag.PerfilUsuario == "Admin")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th></th>\r\n");
#nullable restore
#line 79 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody class=\"tbody\"></tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 86 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
                         if (ViewBag.QuantidadedePaginas > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div id=""paginador"" class=""row"">
                                <div class=""col-md-12"">
                                    <nav aria-label=""Page navigation"">
                                        <ul class=""pagination"">
                                            <li class=""page-item active""> <a class=""page-link"" href=""#"">1</a></li>
");
#nullable restore
#line 93 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
                                             for (int i = 2; i <= ViewBag.QuantidadedePaginas; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item\"> <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 95 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
                                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 96 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul>\r\n                                    </nav>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 101 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">

    $(document).ready(function () {

        $.ajax({
            type: ""POST"",
            url: ""/VoluntariosFemininoInativos/GrupoPagina"",
            data: 1,
            datatype: ""html"",
            contentType: 'application/x-www-form-urlencoded',
            success: function (result) {
                if (result != null) {
                    var table = $('#tbFemininoCadastro').find('tbody');
                    table.empty();
                    for (var i = 0; i < result.length; i++) {
                        table.append(criar_linha_grid(result[i]));
                    }
                }
            },
            error: function () {
                swal(""Oops"", ""Não foi possível conectar ao servidor!"", ""error"");
            }
        });
    })
        .on('click', '.voluntariosEstudos', function () {
            var btn = $(thi");
            WriteLiteral(@"s),
                _id = btn[0].id;
            window.location.href = '/VoluntariosEstudos/Index/' + _id;
        }
        ).on('click', '.ativar', function () {
            var btn = $(this),
                _id = btn[0].id;
            Ativar(_id);

        }
        ).on('click', '.copiadados', function () {
            var btn = $(this),
                _id = btn[0].id;

            CopiarDados(_id);
        }
        ).on('click', '.page-item', function () {
            var btn = $(this),
                pagina = btn.text();

            dados = { NrPagina: pagina };

            $.ajax({
                type: ""POST"",
                url: ""/VoluntariosFemininoInativos/GrupoPagina"",
                data: dados,
                datatype: ""html"",
                contentType: 'application/x-www-form-urlencoded',
                success: function (result) {
                    if (result != null) {
                        var table = $('#tbFemininoCadastro').find('tbody');
  ");
            WriteLiteral(@"                      table.empty();
                        for (var i = 0; i < result.length; i++) {
                            table.append(criar_linha_grid(result[i]));
                        }
                        btn.siblings().removeClass('active');
                        btn.addClass('active');
                    }
                },
                error: function () {
                    swal(""Oops"", ""Não foi possível conectar ao servidor!"", ""error"");
                }
            });
        });

    function CopiarDados(id) {
        $(""#tbFemininoCadastro tbody tr"").each(function (i, row) {
            if (parseInt(id) == parseInt(row.id)) {
                document.getElementById(""myInput"").style.display = ""block"";
                $(""#alerta"").show();
                var nome = $("":nth-child(3)"", row).html();
                var CadastroIdade = $("":nth-child(4)"", row).html();
                var classesocial = $("":nth-child(5)"", row).html();
                //var tel");
            WriteLiteral(@"celular = $("":nth-child(6)"", row).html();
                //var telfixo = $("":nth-child(7)"", row).html();
                var textoparacopiar = nome + '; ' + CadastroIdade + '; ' + classesocial;
                var copyText = document.getElementById(""myInput"");
                copyText.value = textoparacopiar;
                copyText.select();
                copyText.setSelectionRange(0, 99999);
                document.execCommand(""copy"");
                document.getElementById(""myInput"").style.display = ""none"";
                FecharDiv();
            }
        });
    }

    function Ativar(id) {
        swal({
            title: ""Você tem certeza?"",
            text: ""Você tem certeza que deseja ativar o voluntário?"",
            type: ""warning"",
            showCancelButton: true,
            closeOnConfirm: false,
            confirmButtonText: ""Sim, ativar!"",
            confirmButtonColor: ""#ec6c62""
        },
            function () {
                $.ajax({
            ");
            WriteLiteral(@"        url: ""/VoluntariosFemininoInativos/DesableItem/"" + id,
                    data: id,
                    type: ""POST""
                })
                    .done(function (data) {
                        sweetAlert
                            ({
                                title: ""Ativado!"",
                                text: ""Voluntário Ativado com sucesso!"",
                                type: ""success""
                            },
                                function () {
                                    window.location.reload();
                                });
                    })
                    .error(function (data) {
                        swal(""Oops"", ""Não foi possível conectar ao servidor!"", ""error"");
                    });
            });
    }

    function FecharDiv() {
        setTimeout(function () {
            $(""#alerta"").hide();
        }, 3000);
    };

    function criar_linha_grid(dados) {
        var template = $('#templ");
            WriteLiteral(@"ategridVoluntarioFeminino').html();
        return Mustache.render(template, dados);
    }

    $(""#search"").keyup(function () {
        var value = this.value.toLowerCase().trim();

        $(""table tr"").each(function (index) {
            if (!index) return;
            $(this).find(""td"").each(function () {
                var id = $(this).text().toLowerCase().trim();
                var not_found = (id.indexOf(value) == -1);
                $(this).closest('tr').toggle(!not_found);
                return not_found;
            });
        });
    });

    $(""#FiltrarnoBackEnd"").click(function () {

        dados =
        {
            ativo: false,
            femininoId: $(""#femininoId"").val(),
            classesocial: $(""#cboClasseSocial option:selected"").val(),
            idadeDe: $(""#idadeDe"").val(),
            idadeAte: $(""#idadeAte"").val(),
            nome: $(""#nome"").val(),
        };
        if (dados.femininoId == ""0"" || dados.femininoId == """" && dados.classesocia");
            WriteLiteral(@"l == ""0"" && dados.idadeDe == """" && dados.idadeAte == """" && dados.nome == """") {
            swal({
                title: ""Filtro sem dados informados!"",
                text: ""Informe os dados que deseja filtrar!"",
                type: ""warning""
            });
            return null;
        }

        $.ajax({
            type: ""POST"",
            url: ""/VoluntariosFemininoInativos/FiltrarnoBackEnd"",
            data: dados,
            datatype: ""html"",
            contentType: 'application/x-www-form-urlencoded',
            success: function (result) {
                if (result != null) {
                    if (result.length > 0) {
                        var table = $('#tbFemininoCadastro').find('tbody');
                        table.empty();

                        for (var i = 0; i < result.length; i++) {
                            table.append(criar_linha_grid(result[i]));
                        }
                    }
                    else {
                     ");
            WriteLiteral(@"   var table = $('#tbFemininoCadastro').find('tbody');
                        table.empty();

                        swal({
                            title: ""Nenhum registro encontrado!"",
                            text: ""Informe outros dados para realizar o filtro!"",
                            type: ""warning""
                        });
                    }
                    $('#paginador').hide();
                }
                else {
                    var table = $('#tbFemininoCadastro').find('tbody');
                    table.empty();
                    $('#paginador').hide();

                    swal({
                        title: ""Nenhum registro encontrado!"",
                        text: ""Informe outros dados para realizar o filtro!"",
                        type: ""warning""
                    });
                }
            },
            error: function () {
                swal(""Oops"", ""Não foi possível conectar ao servidor!"", ""error"");
            }
 ");
            WriteLiteral(@"       });
    })


</script>

<script id=""templategridVoluntarioFeminino"" type=""x-tmpl-mustache"">
    <tr id=""{{ id }}"">
        <td><a href=""#"" id=""{{ id }}"" class=""copiadados""><i class=""ion-ios-photos-outline""></i></a></td>
        <td>
            {{ femininoCadastroId  }}
        </td>
        <td>
            {{ cadastroNome }}
        </td>
        <td>
            {{ cadastroIdade }}
        </td>
        <td>
            {{ cadastroClasseSocial }}
        </td>
");
#nullable restore
#line 343 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
         if (ViewBag.PerfilUsuario == "Admin")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td align=\"center\"><a href=\"#\" id=\"{{ id }}\" class=\"ativar\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Ativar Voluntário\"><i class=\"ion-ios-checkmark\"></i></a></td>\r\n");
#nullable restore
#line 346 "E:\2021\Backups 2021\Projetos\GestaodeVoluntarios\GestaodeVoluntarios.UI\Views\VoluntariosFemininoInativos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tr>\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestaodeVoluntarios.UI.Models.Feminino.FemininoCadastro>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
