// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PtoyectoFinal.Shared
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Main")]
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 183 "C:\Users\LUIS ANTONIO DE AZA\Desktop\Ultimos Ajustes del final\Proyecto-Final-P3\Proyecto-Final-P3\Shared\MainLayout.razor"
      

    bool Registrado = false;
    bool UserError = false;
    bool Cargando = true;
    async Task Cerrar()
    {
        await localStorage.RemoveItemAsync("ID_login");
        navigationManager.NavigateTo("/Main");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        // String name = await localStorage.GetItemAsync<string>("id_login");

        if (firstRender)
        {
            if (await localStorage.ContainKeyAsync("ID_login"))
            {
                //navigationManager.NavigateTo("/CRUDVehiculos");
                Registrado = true;
                StateHasChanged();
                return;

            }
            Cargando = false;
            StateHasChanged();
        }

    }


    /// <summary>
    ///
    /// </summary>
    ///
    String UserID;
    String passID;
    String id;
    String ID_Institucion;
    String id_inst;
    String msj;
    String e;

    bool error = false;


    public void melo()
    {
        Cargando = true;
        CreateArticle();
    }

    protected async Task CreateArticle()
    {


        // await articleManager.Createlogin(log);

        id = await articleManager.getloginID(UserID, passID);
        ID_Institucion = await articleManager.getIDCompani(id);



        if (id != null && id != "")
        {
            UserError = true;
            GuardarLogin();
            OnAfterRender(true);
            Registrado = true;
            navigationManager.NavigateTo("/CRUDVehiculos");

        }
        else
        {
            Cargando = false;
            error = true;
            UserError = true;
            msj = "Usuario o clave incorrecta";
        }


    }

    void cancel()
    {
        navigationManager.NavigateTo("/articlelist");
    }


    async Task GuardarLogin()
    {
        await localStorage.SetItemAsync("ID_login", id);
        await localStorage.SetItemAsync("ID_Institucion", id);
        OnAfterRender(true);


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArticleManager articleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
