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
#nullable restore
#line 6 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\AddReservas.razor"
using Microsoft.OData.Edm;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addReserva")]
    public partial class AddReservas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "C:\Users\LUIS ANTONIO DE AZA\Desktop\pf\Proyecto-Final-P3\Pages\AddReservas.razor"
      

    Reservas reserva = new Reservas();
    Factura factura = new Factura();
    String msj;
    Date INC;
    Date FIN;
    bool errorFecha = false;




    //Datos del Vehiculo
    String vehiculo;
    String Marca;
    String Modelo;
    String Year;
    String Color;
    String Tipo;
    String Carga;
    String Pasagero;
    String Matricula;
    String Nseguro;
    String Precio;
    bool ExistSelect = true;

    //Datos del cliente
    String cedula;
    String Nombre;
    String Apellido;
    String Correo;
    String Licencia;
    String Nacionalidad;
    String Sangre;
    bool ExistSelectC = true;
    int MontoP;

    public void AP()
    {
        MontoP = (FIN.Day + 1 - INC.Day) * Convert.ToInt32(Precio);
    }


    public void SelectVehiculo()
    {
        navigationManager.NavigateTo("/SelecVehiculo");

    }
    public void SelectCliente()
    {
        navigationManager.NavigateTo("/SelectCliente");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {

            if (!await localStorage.ContainKeyAsync("ID_login"))
            {
                navigationManager.NavigateTo("/Main");

            }
            // String name = await localStorage.GetItemAsync<string>("id_login");

            if (await localStorage.ContainKeyAsync("CID"))
            {
                ExistSelectC = false;
                cedula = await localStorage.GetItemAsStringAsync("CCEDULA");
                Nombre = await localStorage.GetItemAsStringAsync("CNOMBRE");
                Apellido = await localStorage.GetItemAsStringAsync("CAPELLIDO");
                Correo = await localStorage.GetItemAsStringAsync("CCORREO");
                Licencia = await localStorage.GetItemAsStringAsync("CLICENCIA");
                Nacionalidad = await localStorage.GetItemAsStringAsync("CNACIONALIDAD");
                Sangre = await localStorage.GetItemAsStringAsync("CSANGRE");


            }

            if (await localStorage.ContainKeyAsync("VID"))
            {
                ExistSelect = false;

                Marca = await localStorage.GetItemAsStringAsync("VMarca");
                Modelo = await localStorage.GetItemAsStringAsync("VMODELO");
                Year = await localStorage.GetItemAsStringAsync("VAño");
                Color = await localStorage.GetItemAsStringAsync("VCOLOR");
                Precio = await localStorage.GetItemAsStringAsync("VPRECIO");
                Tipo = await localStorage.GetItemAsStringAsync("VTIPO");
                Carga = await localStorage.GetItemAsStringAsync("VCARGA");
                Pasagero = await localStorage.GetItemAsStringAsync("VPASAJERO");
                Matricula = await localStorage.GetItemAsStringAsync("VMATRICULA");
                Matricula = await localStorage.GetItemAsStringAsync("VMATRICULA");
                Nseguro = await localStorage.GetItemAsStringAsync("VSEGURO");

                StateHasChanged();

            }
        }

    }

    protected async Task Guardar()
    {
        ExistSelect = true;
        ExistSelect = true;

        string ID_V = await localStorage.GetItemAsync<string>("VID");
        string ID_C = await localStorage.GetItemAsync<string>("CID");
        string ID_Institucion = await localStorage.GetItemAsync<string>("ID_Institucion");

        reserva.ID_Vehiculo = ID_V;
        reserva.ID_Cliente = ID_C;
        reserva.ID_Institucion = ID_Institucion;
        reserva.Fecha_Inc = INC.ToString();
        reserva.Fecha_Fin = FIN.ToString();

        int MontoPagar = (FIN.Day + 1 - INC.Day) * Convert.ToInt32(Precio);
        MontoP = MontoPagar;


        //await ReservaManager.Agregar(reserva);


        factura.ID_Institucion = ID_Institucion;
        factura.ID_Cliente = ID_C;
        factura.ID_Vehiculo = ID_V;
        factura.Nombre_Cliente = Nombre;
        factura.Apellido_Cliente = Apellido;
        factura.Cedula_Cliente = cedula;
        factura.Fecha_Inc = INC.ToString();
        factura.Fecha_Fin = FIN.ToString();
        factura.Monto_pagar = MontoPagar;
        factura.Marca = Marca;
        factura.Color = Color;
        factura.Tipo = Tipo;
        factura.Matricula = Matricula;
        factura.pago = 1;

        int ValidadoFehca = await ReservaManager.ValidadFecha(INC.ToString(), FIN.ToString(), ID_Institucion,ID_V);
        if (ValidadoFehca != 0)
        {
            errorFecha = true;
            return;
        }
        //Obtines lo que tiene el vehiculo generado y suma lo actual
        int IDV = await localStorage.GetItemAsync<int>("VID");
        int GENERADO = await localStorage.GetItemAsync<int>("VGENERADO");
        int TotalGenerado = (GENERADO + MontoP);
        await VehiculosManager.Generado(IDV,TotalGenerado);

        //Obtiene las veces generado y le suma una vez mas
        int Reservado = await localStorage.GetItemAsync<int>("VVRESERVADO");
        int TotalReservado = Reservado + 1;
        await VehiculosManager.Reservado(IDV, TotalReservado);

        await ReservaManager.Agregar(reserva);
        await ReservaManager.AgregarFactura(factura);
        msj = "agregado" + ValidadoFehca;
        LimpiarDatos();

    }

    protected async Task LimpiarDatos()
    {
        await localStorage.RemoveItemAsync("VID");
        await localStorage.RemoveItemAsync("VMarca");
        await localStorage.RemoveItemAsync("VMODELO");
        await localStorage.RemoveItemAsync("VAño");
        await localStorage.RemoveItemAsync("VCOLOR");
        await localStorage.RemoveItemAsync("VPRECIO");
        await localStorage.RemoveItemAsync("VTIPO");
        await localStorage.RemoveItemAsync("VCARGA");
        await localStorage.RemoveItemAsync("VPASAJERO");
        await localStorage.RemoveItemAsync("VMATRICULA");
        await localStorage.RemoveItemAsync("VMATRICULA");
        await localStorage.RemoveItemAsync("VSEGURO");
        await localStorage.RemoveItemAsync("VGENERADO");

        await localStorage.GetItemAsStringAsync("CCEDULA");
        await localStorage.GetItemAsStringAsync("CNOMBRE");
        await localStorage.GetItemAsStringAsync("CAPELLIDO");
        await localStorage.GetItemAsStringAsync("CCORREO");
        await localStorage.GetItemAsStringAsync("CLICENCIA");
        await localStorage.GetItemAsStringAsync("CNACIONALIDAD");
        await localStorage.GetItemAsStringAsync("CSANGRE");
        await localStorage.RemoveItemAsync("CID");

        msj = "Agregado haha";
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculosManager VehiculosManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReservaManager ReservaManager { get; set; }
    }
}
#pragma warning restore 1591
