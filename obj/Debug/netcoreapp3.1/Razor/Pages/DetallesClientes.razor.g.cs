#pragma checksum "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6b35d12c4e530270e3b93279e2ec3723221f551"
// <auto-generated/>
#pragma warning disable 1591
namespace PtoyectoFinal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DetallesClientes/{ID}")]
    public partial class DetallesClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n        .card {\r\n            display: flex;\r\n            justify-content: center;\r\n            align-items: center;\r\n        }\r\n    </style>\r\n\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "header");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "text-center alert alert-info");
                __builder2.AddMarkupContent(8, "\r\n                ");
                __builder2.OpenElement(9, "h1");
                __builder2.AddContent(10, "Detalles del cliente ");
                __builder2.AddContent(11, 
#nullable restore
#line 18 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                          clientes.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n        <br>\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-md-6");
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "card");
                __builder2.AddAttribute(23, "style", "width: 20rem; height:30rem;");
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenElement(25, "img");
                __builder2.AddAttribute(26, "class", "card-img-top");
                __builder2.AddAttribute(27, "src", 
#nullable restore
#line 26 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                                    clientes.Foto_Persona

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(28, "alt", "Picture" + " " + (
#nullable restore
#line 26 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                                                                         clientes.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "style", "height:24rem;");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "card-body");
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "center");
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __builder2.OpenElement(36, "h5");
                __builder2.AddAttribute(37, "class", "card-title");
                __builder2.AddContent(38, 
#nullable restore
#line 29 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                                    clientes.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, " ");
                __builder2.AddContent(40, 
#nullable restore
#line 29 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                                                     clientes.Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.OpenElement(42, "p");
                __builder2.AddAttribute(43, "class", "card-text");
                __builder2.AddMarkupContent(44, "<strong>Correo: </strong>");
                __builder2.AddContent(45, 
#nullable restore
#line 30 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                                                           clientes.Correo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.OpenElement(47, "p");
                __builder2.AddAttribute(48, "class", "card-text");
                __builder2.AddMarkupContent(49, "<strong>Licencia: </strong>");
                __builder2.AddContent(50, 
#nullable restore
#line 31 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                                                             clientes.Licencia

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.OpenElement(52, "p");
                __builder2.AddAttribute(53, "class", "card-text");
                __builder2.AddMarkupContent(54, "<strong>Nacionalidad: </strong>");
                __builder2.AddContent(55, 
#nullable restore
#line 32 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                                                                 clientes.Nacionalidad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __builder2.OpenElement(57, "p");
                __builder2.AddAttribute(58, "class", "card-text");
                __builder2.AddMarkupContent(59, "<strong>Tipo de Sangre: </strong>");
                __builder2.AddContent(60, 
#nullable restore
#line 33 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
                                                                                   clientes.Tipo_Sangre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(67, "<div>\r\n            <center>\r\n                <a class=\"btn btn-primary\" href=\"/CRUDClientes\"><i class=\"fas fa-backward\"></i>  Volver atrás</a>\r\n            </center>\r\n        </div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\DetallesClientes.razor"
            
        //Id que se recibe como parametro
        [Parameter]
        public string ID { get; set; }

        //Instancia de la Clase Clientes
        Clientes clientes = new Clientes();

        //Metodo que cuando se carga la vista, el mismo carga por medio del ID cada uno de los impus
        protected override async Task OnInitializedAsync()
        {
            //Se obtiene el ID por medio del LocalStorage
            String name = await localStorage.GetItemAsync<string>("ID_Institucion");
            clientes.ID_Institucion = name;
            clientes = await ClientesManager.GetById(Convert.ToInt32(ID), clientes.ID_Institucion);
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientesManager ClientesManager { get; set; }
    }
}
#pragma warning restore 1591
