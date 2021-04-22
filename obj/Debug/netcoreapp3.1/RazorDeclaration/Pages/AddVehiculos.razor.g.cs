// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddVehiculos")]
    public partial class AddVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\AddVehiculos.razor"
           
        //String del Select
        String TipoDelVehiculo = "-- Sin seleccionar --";

        string MensajeError;
        bool ValidarInputs = false;

        //String del id de la institucion
        string id;

        //Instancia de la Clase Vehiculo
        Vehiculos vehiculo = new Vehiculos();

        //Variable de tipo int, para manejar el zoom del mapa
        int zoom = 6;

        //Metodo para manejar el click del mapa
        void OnMapClick(GoogleMapClickEventArgs args)
        {
            //Variables que cambian de valor cuando al mapa se le da un click en la Latitud y Longitud Deseada
            vehiculo.Latitud = args.Position.Lat;
            vehiculo.Longitud = args.Position.Lng;
        }

        //Metodo que permite agregar los datos de los inputs a la tabla de vehiculos y después vuelve a la lista de Vehiculos
        protected async Task CreateVehiculos()
        {
            if (vehiculo.Marca == null || vehiculo.Modelo == null || vehiculo.Año == null || vehiculo.Color == null || vehiculo.Precio_Dia == 0 || vehiculo.Tipo == "-- Sin seleccionar --" || vehiculo.Capacidad_Carga == 0 || vehiculo.Matricula == null || vehiculo.No_Seguro == null || vehiculo.Foto == null || vehiculo.Latitud == 0 || vehiculo.Longitud == 0)
            {
                MensajeError = "Todos los campos son necesarios...";
                ValidarInputs = true;
                return;
            }
            String name = await localStorage.GetItemAsync<string>("ID_Institucion");
            vehiculo.ID_Institucion = name;
            vehiculo.Tipo = TipoDelVehiculo;
            vehiculo.Generado = 0;
            vehiculo.Veces_Reservados = 0;
            vehiculo.Estado = "Habilitado";
            await VehiculosManager.Create(vehiculo);
            navigationManager.NavigateTo("/CRUDVehiculos");
        }

        //Metodo para cancelar la creaicon del vehiculo y volver a la lista de los Vehiculos
        void cancel()
        {
            navigationManager.NavigateTo("/CRUDVehiculos");
        }

        //Metodo para manejar el select de los tipos de Vehiculos
        public void TipoVehiculo(ChangeEventArgs e)
        {
            TipoDelVehiculo = e.Value.ToString();
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculosManager VehiculosManager { get; set; }
    }
}
#pragma warning restore 1591
