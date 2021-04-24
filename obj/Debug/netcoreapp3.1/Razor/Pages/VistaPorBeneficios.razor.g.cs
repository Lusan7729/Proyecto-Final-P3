#pragma checksum "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ea578581c7d437cb2f910916192592a2b247e1"
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
#line 1 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BeneficiosAuto")]
    public partial class VistaPorBeneficios : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<div>\r\n            <h1 class=\"text-center\">Listado de  Beneficios</h1>\r\n            <hr>\r\n        </div>\r\n\r\n        ");
                __builder2.AddMarkupContent(4, "<div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <a class=\"btn btn-primary\" href=\"/Beneficios\"><i class=\"fas fa-backward\"></i>  Volver atrás</a>\r\n            </div>\r\n        </div>\r\n        \r\n        <br>\r\n        ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-bordered table-hover");
                __builder2.AddAttribute(7, "id", "example");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, @"<thead class=""thead-dark"">
                <tr>
                    <th>ID</th>
                    <th>Marca</th>
                    <th>Modelo</th>
                    <th>Cantidad de veces reservado</th>
                    <th>Ingreso generado por el vehiculo</th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(10, "tbody");
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 30 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
                 if (VehiculosModel == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "                    ");
                __builder2.AddMarkupContent(13, "<tr>\r\n                        <td colspan=\"12\">\r\n                            No Records to display\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
                }
                else
                {
                    foreach (var vehiculo in VehiculosModel)
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
#line 43 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
                                 vehiculo.ID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 44 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
                                 vehiculo.Marca

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                            ");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 45 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
                                 vehiculo.Modelo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 46 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
                                 vehiculo.Veces_Reservados

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 47 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
                                 vehiculo.Generado.ToString("C", new CultureInfo("es-DO"))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 49 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
                        
                    }
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Lusan\Downloads\Proyecto-Final-P3\Pages\VistaPorBeneficios.razor"
           

        //Instancia una lista de la clase de vehiculos
        List<Vehiculos> VehiculosModel;

        //Instancia de la clase Vehiculos
        Vehiculos VehiculosEntity = new Vehiculos();

        //Metodo para borrar un vehiculo con los parametros del ID normal y el ID de institucion
        protected async Task DeleteVehiculos(int id, string id_institucion)
        {
            await VehiculosManager.Delete(id, id_institucion);
            VehiculosModel = await VehiculosManager.ListAll(id_institucion);
        }

        //Metodo que se ejecuta de inicio y que muestra la lista de los vehiculos, filtrandola por el id de institucion
        protected override async Task OnInitializedAsync()
        {
            String name = await localStorage.GetItemAsync<string>("ID_Institucion");
            VehiculosModel = await VehiculosManager.ListAll(name);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculosManager VehiculosManager { get; set; }
    }
}
#pragma warning restore 1591
