#pragma checksum "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c98524f42c2913a29c0992299b7e4a0ffdacb31f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98524f42c2913a29c0992299b7e4a0ffdacb31f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("toggleMobileMenu()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Galeria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 1522, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c98524f42c2913a29c0992299b7e4a0ffdacb31f5156", async() => {
                BeginContext(52, 449, true);
                WriteLiteral(@"
    <header>
        <nav > 
                <ul>
                        <li id=""bt-mobile-menu"">
                                <a href=""javascript:void(6);"" class=""icon"" onclick=""toggleMobileMenu()"">
                                    <i class=""fa fa-bars""></i>
                                </a>
                            </li>
                    
                    <li class=""bt-common-menu""><a  onclick=""toggleMobileMenu()""");
                EndContext();
                BeginWriteAttribute("href", " href= \'", 501, "\'", 546, 2);
#line 12 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 509, Url.Action("Index", "Home"), 509, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 537, "#historia", 537, 9, true);
                EndWriteAttribute();
                BeginContext(547, 69, true);
                WriteLiteral(" >A RoleTop</a></li>\r\n                    <li class=\"bt-common-menu\">");
                EndContext();
                BeginContext(616, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c98524f42c2913a29c0992299b7e4a0ffdacb31f6595", async() => {
                    BeginContext(695, 7, true);
                    WriteLiteral("Galeria");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(706, 86, true);
                WriteLiteral("</li>\r\n                    <li class=\"bt-common-menu\"><a  onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href= \'", 792, "\'", 840, 2);
#line 14 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 800, Url.Action("Index", "Home"), 800, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 828, "#localização", 828, 12, true);
                EndWriteAttribute();
                BeginContext(841, 103, true);
                WriteLiteral(">Onde estamos</a></li>\r\n                    <li class=\"bt-common-menu\"><a  onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href= \'", 944, "\'", 987, 2);
#line 15 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 952, Url.Action("Index", "Home"), 952, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 980, "#Agenda", 980, 7, true);
                EndWriteAttribute();
                BeginContext(988, 97, true);
                WriteLiteral(">Agenda</a></li>\r\n                    <li class=\"bt-common-menu\"><a  onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href= \'", 1085, "\'", 1125, 2);
#line 16 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1093, Url.Action("Index", "Home"), 1093, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 1121, "#FAQ", 1121, 4, true);
                EndWriteAttribute();
                BeginContext(1126, 94, true);
                WriteLiteral(">FAQ</a></li>\r\n                    <li class=\"bt-common-menu\"><a  onclick=\"toggleMobileMenu()\"");
                EndContext();
                BeginWriteAttribute("href", " href= \'", 1220, "\'", 1263, 2);
#line 17 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 1228, Url.Action("Index", "Home"), 1228, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 1256, "#Pedido", 1256, 7, true);
                EndWriteAttribute();
                BeginContext(1264, 71, true);
                WriteLiteral(">Alugue Aqui!</a></li>\r\n                    <li class=\"bt-common-menu\">");
                EndContext();
                BeginContext(1335, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c98524f42c2913a29c0992299b7e4a0ffdacb31f10937", async() => {
                    BeginContext(1412, 14, true);
                    WriteLiteral("Cadastro/Login");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1430, 131, true);
                WriteLiteral("</li>\r\n                    \r\n                </ul>\r\n\r\n                \r\n                \r\n                \r\n    </nav>\r\n</header>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1568, 5457, true);
            WriteLiteral(@"


<hr/>
<section id=""Agenda"">
<img src=""img/logo.png"" alt=""logo"" width=""250px"" height=""200px""> 
<h4>Aqui seu Role fica Top!</h4>
<h2>Agenda</h2>
    <table border=""3""  id=""tabela"">
       
        
        <td colspan=""7"">SETEMBRO</td>
        
        <tr >
           <ul>
               <li>Indisponivel</li>
               <li>Disponivel</li>
              
           </ul>
            
            
            <th id=""ddd"" width=""70px"" height=""70px"">1</th>
            <th id=""zzz"" width=""70px"" height=""70px"">2</th>
            <th id=""zzz"" width=""70px"" height=""70px"">3</th>
            <th width=""70px"" height=""70px"">4</th>
            <th id=""ddd"" width=""70px"" height=""70px"">5</th>
            <th width=""70px"" height=""70px"">6</th>
            <th width=""70px"" height=""70px"">7</th>
        
        </tr>
        <tr>
            <td id=""zzz"" width=""70px"" height=""70px"">8</td>
            <td width=""70px"" height=""70px"">9</td>
            <td width=""70px"" height=""70px"">10</td>
  ");
            WriteLiteral(@"          <td id=""zzz"" width=""70px"" height=""70px"">11</td>
            <td id=""ddd"" width=""70px"" height=""70px"">12</td>
            <td id=""ddd"" width=""70px"" height=""70px"">13</td>
            <td width=""70px"" height=""70px"">14</td>
        </tr>
        <tr>
            <td id=""fff"" width=""70px"" height=""70px"">15</td>
            <td width=""70px"" height=""70px"">16</td>
            <td id=""fff"" width=""70px"" height=""70px"">17</td>
            <td width=""70px"" height=""70px"">18</td>
            <td width=""70px"" height=""70px"">19</td>
            <td id=""ddd"" width=""70px"" height=""70px"">20</td>
            <td width=""70px"" height=""70px"">21</td>
        </tr>
        <tr>
            <td id=""fff"" width=""70px"" height=""70px"">22</td>
            <td id=""fff"" width=""70px"" height=""70px"">23</td>
            <td width=""70px"" height=""70px"">24</td>
            <td id=""ddd"" width=""70px"" height=""70px"">25</td>
            <td width=""70px"" height=""70px"">26</td>
            <td id=""ddd"" width=""70px"" height=""70px"">27<");
            WriteLiteral(@"/td>
            <td width=""70px"" height=""70px"">28</td>
        </tr>
        <tr>
            <td id=""ddd"" width=""70px"" height=""70px"">29</td>
            <td id=""ddd"" width=""70px"" height=""70px"">30</td>
            <td id=""ddd"" width=""70px"" height=""70px"">31</td>
        </tr>
    
    </table>



</section>


<hr />



<section id=""historia"">
<h2>A RoleTop</h2>
    <div id=""aaa"">
        <div id=""container-historia"">
            <h3>Nossa História</h3>
                <p>
                A RoleTop, de acordo com o que muitos relataram sobre a lenda, 
                    é um dos seres que mais causavam medo nos indígenas nos séculos passados. 
                    A descrição física desse ser afirma que ele teria corpo de menino, baixa estatura, 
                    cabelos vermelhos e os pés ao contrário, isto é, com os calcanhares para frente. 
                    Além disso, esse também teria grande força física.
                    Essas características físicas fazem parte da");
            WriteLiteral(@" versão mais conhecida dessa lenda,
                    mas existem outras versões que apresentam o curupira com diferentes características. 
                    Existem aqueles que dizem o curupira seria careca e com olhos e/ou dentes verdes, por exemplo.
                </p>
        </div>
    <div id=""aleecesar"">
        <div id=""cesar"">
            <h3>Cesar Sportare</h3>
                <p>
                    Um dia descobrimos que beijar uma pessoa 
                    para esquecer outra, é bobagem.
                    Você não só não esquece a outra pessoa 
                    como pensa muito mais nela
                    Um dia nós percebemos que as mulheres têm instinto 
                    ""caçador"" e fazem qualquer homem sofrer 
                </p>
        
            </div>
        <div id=""ale"">
                <h3>Alexandre Fukaya</h3>
                    <p>
                        Um dia descobrimos que beijar uma pessoa 
                        para esquecer outra, ");
            WriteLiteral(@"é bobagem.
                        Você não só não esquece a outra pessoa 
                        como pensa muito mais nela
                        Um dia nós percebemos que as mulheres têm instinto 
                        ""caçador"" e fazem qualquer homem sofrer 
                    </p>
        </div>
    </div>
    </div>
</section>

<hr/>
<h2>FAQ</h2>
<section id=""FAQ"">
    <button class=""accordion"">Claudio Pereira</button>
        <div class=""panel"">
        <p>Como eu faço o casdatro?</p>
        </div>

        <button class=""accordion"">Tomas Turbando</button>
            <div class=""panel"">
                <p>Como eu vejo a agenda??</p>
            </div>

        <button class=""accordion"">Elimin Rabá</button>
            <div class=""panel"">
                <p>Como eu faço o pagamento?</p>
            </div>
    <script>
            var acc = document.getElementsByClassName(""accordion"");
            var i;
            
            for (i = 0; i < acc.length; i++) {
 ");
            WriteLiteral(@"               acc[i].onclick = function(){
                    this.classList.toggle(""active"");
                    this.nextElementSibling.classList.toggle(""show"");
                }
            }
    </script>        

</section>

<hr/>

<section id=""Pedido"">
<div class=""Pedidos"">
        <h2>Alugue Aqui!</h2>
        ");
            EndContext();
            BeginContext(7025, 1378, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c98524f42c2913a29c0992299b7e4a0ffdacb31f19490", async() => {
                BeginContext(7088, 1308, true);
                WriteLiteral(@"
            <div id=""nome"">
                <label for=""nome"">Nome Completo</label>
                <br />
                <input id=""nome"" type=""text"" maxlength=""20"" minlength=""3""  name=""nome""  placeholder=""___________________________________________________________________________________________""/>
            </div>

            

            <div>
                <label for=""telefone"">Telefone para contato</label>
                <br />
                <input id=""telefone"" type=""text"" placeholder=""11 12345 6789""  name=""telefone""  placeholder=""_________________________________________________________________________________""/>
            </div>

            <div>
                <label for=""email"">E-mail</label>
                <br />
                <input id=""email"" type=""email"" name=""email""   placeholder=""______________________________________________________________________________""/>
            </div>

            <div>
                <label for=""data"">Data do Evento</label>");
                WriteLiteral(@"
                <br />
                <input id=""data"" type=""datetime-local"" name=""data""   placeholder=""______________________________________________________________________________""/>
            </div>

            <input type=""submit"" value=""Finalizar pedido!"" />
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 181 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7053, Url.Action("Registrar","Pedido"), 7053, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8403, 2028, true);
            WriteLiteral(@"

        

    </div>

    </html>
</section>

            <hr/>

<section id=""localização"">
    <h2>Onde Estamos</h2>
    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410""
    width=""100%"" height=""100%"" frameborder=""0""></iframe>

</section>

<script>
    function toggleMobileMenu() {
        var ul = document.querySelector(""nav ul"");
        var commonButtons = document.querySelectorAll(""nav .bt-common-menu"");
        var icon = document.querySelector("".icon > i"");
        ul.classList.toggle(""mobile-mode"");
        if (icon.classList.contains(""fa-bars"")) {
            icon.classList.remove(""fa-bars"");
            icon.classList.remove(""fa"");
            icon.classList.add(""fas"");
   ");
            WriteLiteral(@"         icon.classList.add(""fa-skull"");
        } else {
            icon.classList.remove(""fas"");
            icon.classList.remove(""fa-skull"");
            icon.classList.add(""fa"");
            icon.classList.add(""fa-bars"");
        }
        for (var button of commonButtons) {
            button.classList.toggle(""active"");
        }
    }
    
</script>



<footer>
    <div class=""section-container "">
        <address>
            Avenida de Limeira, 539 - Campos Elíseos - SP  
            <br />
            RoleTop@email.com
            <br />
            11 1234 6789
        </address>
        <a href=""#"">Voltar para o topo!</a>
        <ul> 
            <li><img src=""img/what.png"" title=""Whatsap"" alt=""Whatsap"" > </li>
            <li><img src=""img/insta.png"" title=""Insta"" alt=""Instagram"" ></li>
            <li><img src=""img/face.png"" title=""Face"" alt=""Face""></li> 
            <li></li>
            
        </ul>
    </div>
</footer>



</html>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
