#pragma checksum "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "764ca9ccc33968fe628f591ae36c24fd72cc660a"
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
#line 1 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
using Microsoft.OData.Edm;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CRUDVehiculsos")]
    public partial class VistaPorVehiculos : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.AddMarkupContent(3, "<header>\r\n        <h1 class=\"text-center\">Listado de Vehiculos</h1>\r\n        <hr>\r\n    </header>\r\n    ");
                __builder2.OpenElement(4, "input");
                __builder2.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                         INC

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => INC = __value, INC));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                         FIN

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FIN = __value, FIN));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.AddMarkupContent(12, "<button class=\"btn btn-primary\">Veficicar</button>\r\n    ");
                __builder2.AddMarkupContent(13, @"<div class=""row"">
        <div class=""col-md-6"">
            <a class=""btn btn-success"" href=""/AddVehiculos""><i class=""far fa-plus-square""></i>  Añadir Vehiculo</a>
        </div>
        <div class=""col-md-6 text-right"">
            <a class=""btn btn-warning"" href=""/ListadoVehiculosDeshabilitados""><i class=""fas fa-clipboard-list""></i> Listado de Vehiculos deshabilitados</a>
        </div>
    </div>
    <br>

    ");
                __builder2.OpenElement(14, "table");
                __builder2.AddAttribute(15, "class", "table table-bordered table-hover");
                __builder2.AddAttribute(16, "id", "example");
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.AddMarkupContent(18, @"<thead class=""thead-dark"">
            <tr>
                <th>ID</th>
                <th>Marca</th>
                <th>Modelo</th>
                <th>Año</th>
                <th>Color</th>
                <th>Precio_Dia</th>
                <th>Tipo</th>
                <th>Cap_Carga</th>
                <th>Pasajeros</th>
                <th>Matricula</th>
                <th>No_Seguro</th>
                <th>Acciones</th>
            </tr>
        </thead>
        ");
                __builder2.OpenElement(19, "tbody");
                __builder2.AddMarkupContent(20, "\r\n");
#nullable restore
#line 46 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
             if (VehiculosModel == null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(21, "                ");
                __builder2.AddMarkupContent(22, "<tr>\r\n                    <td colspan=\"12\">\r\n                        No Records to display\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
            }
            else
            {
                foreach (var vehiculo in VehiculosModel)
                {
                   


#line default
#line hidden
#nullable disable
                __builder2.AddContent(23, "                    ");
                __builder2.OpenElement(24, "tr");
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 61 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.ID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 62 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Marca

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "td");
                __builder2.AddContent(33, 
#nullable restore
#line 63 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Modelo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 64 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Año

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 65 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Color

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 66 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Precio_Dia.ToString("C", new CultureInfo("es-DO"))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 67 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Tipo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.OpenElement(47, "td");
                __builder2.AddContent(48, 
#nullable restore
#line 68 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Capacidad_Carga

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(49, " Kg");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.OpenElement(51, "td");
                __builder2.AddContent(52, 
#nullable restore
#line 69 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Pasajeros

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.OpenElement(54, "td");
                __builder2.AddContent(55, 
#nullable restore
#line 70 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.Matricula

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.OpenElement(57, "td");
                __builder2.AddContent(58, 
#nullable restore
#line 71 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                             vehiculo.No_Seguro

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.OpenElement(60, "td");
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.OpenElement(62, "a");
                __builder2.AddAttribute(63, "href", "/EditVehiculos/" + (
#nullable restore
#line 73 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                                                     vehiculo.ID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(64, "<i style=\"color:dodgerblue;\" class=\"far fa-edit\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.OpenElement(66, "a");
                __builder2.AddAttribute(67, "href", "/DetallesVehiculos/" + (
#nullable restore
#line 74 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                                                         vehiculo.ID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(68, "<i style=\"color:deepskyblue;\" class=\"fas fa-info-circle\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                            ");
                __builder2.OpenElement(70, "a");
                __builder2.AddAttribute(71, "href", "/DeshabilitarVehiculo/" + (
#nullable restore
#line 75 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                                                            vehiculo.ID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(72, "<i style=\"color:orange;\" class=\"fas fa-ban\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __builder2.OpenElement(74, "a");
                __builder2.AddAttribute(75, "href", "/CRUDVehiculos");
                __builder2.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                                                               () => DeleteVehiculos(vehiculo.ID, vehiculo.ID_Institucion)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(77, "<i style=\"color:red;\" class=\"fas fa-trash-alt\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n");
#nullable restore
#line 79 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
                }
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Pages\VistaPorVehiculos.razor"
       
    Date INC;
    Date FIN;

    //Instancia una lista de la clase de vehiculos
    List<Vehiculos> VehiculosModel;
    List<Factura> FacturaModels;

    //Instancia de la clase Vehiculos
    Vehiculos VehiculosEntity = new Vehiculos();
    Factura FacturaEntity = new Factura();



    //Metodo para borrar un vehiculo con los parametros del ID normal y el ID de institucion
    protected async Task DeleteVehiculos(int id, string id_institucion)
    {
        await VehiculosManager.Delete(id, id_institucion);
        VehiculosModel = await VehiculosManager.ListAll(id_institucion);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (!await localStorage.ContainKeyAsync("ID_login"))
            {
                navigationManager.NavigateTo("/Main");

            }
            String name = await localStorage.GetItemAsync<string>("ID_Institucion");
            VehiculosModel = await VehiculosManager.ListAll(name);

            StateHasChanged();
        }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReservaManager ReservaManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculosManager VehiculosManager { get; set; }
    }
}
#pragma warning restore 1591
