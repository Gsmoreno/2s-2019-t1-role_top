#pragma checksum "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\User\Usuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "272e5f925209d7dca7d594fa024876bdf56516d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Usuario), @"mvc.1.0.view", @"/Views/User/Usuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Usuario.cshtml", typeof(AspNetCore.Views_User_Usuario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"272e5f925209d7dca7d594fa024876bdf56516d6", @"/Views/User/Usuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Usuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Galeriauser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 104, true);
            WriteLiteral("\r\n\r\n    <header>\r\n        <nav> \r\n                <ul>\r\n                    \r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href= \'", 104, "\'", 149, 2);
#line 7 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\User\Usuario.cshtml"
WriteAttributeValue("", 112, Url.Action("Dados", "Home"), 112, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 140, "#historia", 140, 9, true);
            EndWriteAttribute();
            BeginContext(150, 46, true);
            WriteLiteral(" >A RoleTop</a></li>\r\n                    <li>");
            EndContext();
            BeginContext(196, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "272e5f925209d7dca7d594fa024876bdf56516d65433", async() => {
                BeginContext(249, 7, true);
                WriteLiteral("Galeria");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(260, 33, true);
            WriteLiteral("</li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href= \'", 293, "\'", 341, 2);
#line 9 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\User\Usuario.cshtml"
WriteAttributeValue("", 301, Url.Action("Dados", "Home"), 301, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 329, "#localização", 329, 12, true);
            EndWriteAttribute();
            BeginContext(342, 50, true);
            WriteLiteral(">Onde estamos</a></li>\r\n                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href= \'", 392, "\'", 435, 2);
#line 10 "C:\Users\49801332824\Desktop\workspace\2s-2019-t1-role_top\Role Top\RoleTopMVC\Views\User\Usuario.cshtml"
WriteAttributeValue("", 400, Url.Action("Dados", "Home"), 400, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 428, "#Agenda", 428, 7, true);
            EndWriteAttribute();
            BeginContext(436, 64, true);
            WriteLiteral(">Agenda</a></li>\r\n                    \r\n                    <li>");
            EndContext();
            BeginContext(500, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "272e5f925209d7dca7d594fa024876bdf56516d68166", async() => {
                BeginContext(547, 6, true);
                WriteLiteral("Carlos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(557, 31, true);
            WriteLiteral("</li>\r\n                    <li>");
            EndContext();
            BeginContext(588, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "272e5f925209d7dca7d594fa024876bdf56516d69771", async() => {
                BeginContext(633, 8, true);
                WriteLiteral("Deslogar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(645, 6018, true);
            WriteLiteral(@"</li>
                </ul>
        </nav>
    <section id=""logo-area"">
        <img src=""../img/logo.png"" title=""Logo"" alt=""Logo tipo super maneiro meuuuu"" height=""300px"" width=""350px"" />
        <h2>Aqui seu Role fica Top! </h2>
    </section>
</header>

<hr/>
<section id=""Agenda"">
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
      ");
            WriteLiteral(@"      <td id=""zzz"" width=""70px"" height=""70px"">8</td>
            <td width=""70px"" height=""70px"">9</td>
            <td width=""70px"" height=""70px"">10</td>
            <td id=""zzz"" width=""70px"" height=""70px"">11</td>
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
         ");
            WriteLiteral(@"   <td id=""ddd"" width=""70px"" height=""70px"">25</td>
            <td width=""70px"" height=""70px"">26</td>
            <td id=""ddd"" width=""70px"" height=""70px"">27</td>
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
                    cabelos vermelhos e os pés ao contrário, isto é, com os calcanha");
            WriteLiteral(@"res para frente. 
                    Além disso, esse também teria grande força física.
                    Essas características físicas fazem parte da versão mais conhecida dessa lenda,
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
                <h3>Alexa");
            WriteLiteral(@"ndre Fukaya</h3>
                    <p>
                        Um dia descobrimos que beijar uma pessoa 
                        para esquecer outra, é bobagem.
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
    <sc");
            WriteLiteral(@"ript>
            var acc = document.getElementsByClassName(""accordion"");
            var i;
            
            for (i = 0; i < acc.length; i++) {
                acc[i].onclick = function(){
                    this.classList.toggle(""active"");
                    this.nextElementSibling.classList.toggle(""show"");
                }
            }
    </script>        

</section>

<hr/>

<section id=""localização"">
    <h2>Onde Estamos</h2>
    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410""
    width=""100%"" height=""100%"" frameborder=""0""></iframe>

</section>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591