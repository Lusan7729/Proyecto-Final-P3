#pragma checksum "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49171476d361f2b131ed1d8c2ad4a34e845b70a4"
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
#line 1 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUDClientes")]
    public partial class CRUDClientes : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<header>\r\n            <h1 class=\"text-center\">Listado de los Clientes</h1>\r\n            <hr>\r\n        </header>\r\n\r\n        ");
                __builder2.AddMarkupContent(4, @"<div class=""row"">
            <div class=""col-md-6"">
                <a class=""btn btn-success"" href=""/AddClientes""><i class=""fas fa-user-plus""></i>  Añadir Cliente</a>
            </div>
            <div class=""col-md-6 text-right"">
                <a class=""btn btn-warning"" href=""/ListadoClientesDeshabilitados""><i class=""far fa-address-book""></i> Listado de Clientes deshabilitados</a>
            </div>
        </div>
        <br>

        ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-bordered table-hover");
                __builder2.AddAttribute(7, "id", "example");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, @"<thead class=""thead-dark"">
                <tr>
                    <th>ID</th>
                    <th>Cedula</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Correo</th>
                    <th>Licencia</th>
                    <th>Nacionalidad</th>
                    <th>Tipo_Sangre</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(10, "tbody");
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 41 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                 if (ClientesModel == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "                    ");
                __builder2.AddMarkupContent(13, "<tr>\r\n                        <td colspan=\"12\">\r\n                            No Records to display\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                }
                else
                {
                    foreach (var cliente in ClientesModel)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, "                        ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "\r\n                            ");
                __builder2.OpenElement(17, "td");
                __builder2.AddContent(18, 
#nullable restore
#line 54 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                 cliente.ID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 55 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                 cliente.Cedula

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                            ");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 56 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                 cliente.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 57 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                 cliente.Apellido

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 58 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                 cliente.Correo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __builder2.OpenElement(32, "td");
                __builder2.AddContent(33, 
#nullable restore
#line 59 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                 cliente.Licencia

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 60 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                 cliente.Nacionalidad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 61 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                 cliente.Tipo_Sangre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.OpenElement(41, "td");
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.OpenElement(43, "a");
                __builder2.AddAttribute(44, "href", "/EditClientes/" + (
#nullable restore
#line 63 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                                        cliente.ID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(45, "<i style=\"color:dodgerblue;\" class=\"fas fa-pencil-alt\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.OpenElement(47, "a");
                __builder2.AddAttribute(48, "href", "/DetallesClientes/" + (
#nullable restore
#line 64 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                                            cliente.ID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(49, "<i style=\"color:deepskyblue;\" class=\"fas fa-info-circle\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                                ");
                __builder2.OpenElement(51, "a");
                __builder2.AddAttribute(52, "href", "/DeshabilitarCliente/" + (
#nullable restore
#line 65 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                                               cliente.ID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(53, "<i style=\"color:orange;\" class=\"fas fa-user-times\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.OpenElement(55, "a");
                __builder2.AddAttribute(56, "href", "/CRUDClientes");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                                                                  () => DeleteClientes(cliente.ID, cliente.ID_Institucion)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(58, "<i style=\"color:red;\" class=\"fas fa-trash-alt\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n");
#nullable restore
#line 69 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
                    }
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\LUIS ANTONIO DE AZA\Desktop\PF\Proyecto-Final-P3\Pages\CRUDClientes.razor"
           

        //Instancia una lista de la clase de Clientes
        List<Clientes> ClientesModel;

        //Instancia de la clase Clientes
        Clientes ClientesEntity = new Clientes();

        //Metodo para borrar un Cliente con los parametros del ID normal y el ID de institucion
        protected async Task DeleteClientes(int id, string id_institucion)
        {
            await ClientesManager.Delete(id, id_institucion);
            ClientesModel = await ClientesManager.ListarClientes(id_institucion);
        }

        //Metodo que se ejecuta de inicio y que muestra la lista de los Clientes, filtrandola por el id de institucion
        protected override async Task OnInitializedAsync()
        {
            String name = await localStorage.GetItemAsync<string>("ID_Institucion");
            ClientesModel = await ClientesManager.ListarClientes(name);
        }

        //Metodos para poder implementar el Datatable
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
        }

        void IDisposable.Dispose()
        {
            JSRuntime.InvokeAsync<object>("TestDataTablesRemove", "#example");
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientesManager ClientesManager { get; set; }
    }
}
#pragma warning restore 1591
