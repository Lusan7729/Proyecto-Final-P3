#pragma checksum "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155c0155abf92b2dcc03d97d8a5a3f44dbdc149e"
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
#line 1 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using PtoyectoFinal.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\_Imports.razor"
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
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-md-6");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n                ");
                    __builder3.AddMarkupContent(12, "<h1 class=\"text-center\">Añadir Vehiculo</h1>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Vehiculos>>(13);
                    __builder3.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Vehiculos>(
#nullable restore
#line 11 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                            vehiculo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Vehiculos>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Vehiculos>(this, 
#nullable restore
#line 11 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                             CreateVehiculos

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(16, "InvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.FormInvalidSubmitEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.FormInvalidSubmitEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                            CreateVehiculos

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(18, "\r\n                    ");
                        __builder4.OpenElement(19, "div");
                        __builder4.AddAttribute(20, "class", "form-group");
                        __builder4.AddMarkupContent(21, "\r\n\r\n                        ");
                        __builder4.AddMarkupContent(22, "<label for=\"Marca\" class=\"control-label\"><strong>Escriba la marca del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(23);
                        __builder4.AddAttribute(24, "class", "form-control");
                        __builder4.AddAttribute(25, "Name", "Marca");
                        __builder4.AddAttribute(26, "Placeholder", "Marca");
                        __builder4.AddAttribute(27, "value", 
#nullable restore
#line 15 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                       vehiculo.Marca

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(28, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Marca = __value, vehiculo.Marca));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n\r\n                        <br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(30, "<label for=\"Modelo\" class=\"control-label\"><strong>Escriba el modelo del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                        __builder4.AddAttribute(32, "class", "form-control");
                        __builder4.AddAttribute(33, "id", "Modelo");
                        __builder4.AddAttribute(34, "Placeholder", "Modelo");
                        __builder4.AddAttribute(35, "value", 
#nullable restore
#line 20 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                      vehiculo.Modelo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(36, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Modelo = __value, vehiculo.Modelo));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n\r\n                        <br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(38, "<label for=\"Año\" class=\"control-label\" typeof=\"number\"><strong>Escriba el Año del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMask>(39);
                        __builder4.AddAttribute(40, "class", "form-control");
                        __builder4.AddAttribute(41, "id", "Año");
                        __builder4.AddAttribute(42, "Mask", "****");
                        __builder4.AddAttribute(43, "Pattern", "[^0-9]");
                        __builder4.AddAttribute(44, "Placeholder", "Año");
                        __builder4.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                            vehiculo.Año

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Año = __value, vehiculo.Año))));
                        __builder4.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.Año));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(48, "\r\n\r\n                        <br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(49, "<label for=\"Color\" class=\"control-label\"><strong>Escriba el color del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(50);
                        __builder4.AddAttribute(51, "class", "form-control");
                        __builder4.AddAttribute(52, "id", "Color");
                        __builder4.AddAttribute(53, "Placeholder", "Color");
                        __builder4.AddAttribute(54, "value", 
#nullable restore
#line 30 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                     vehiculo.Color

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(55, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Color = __value, vehiculo.Color));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n\r\n                        <br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(57, "<label for=\"Precio_Dia\" class=\"control-label\" typeof=\"number\"><strong>Escriba el Precio por día del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Double>>(58);
                        __builder4.AddAttribute(59, "class", "form-control");
                        __builder4.AddAttribute(60, "id", "Precio_Dia");
                        __builder4.AddAttribute(61, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                                                         false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(62, "Placeholder", "Precio por día");
                        __builder4.AddAttribute(63, "value", 
#nullable restore
#line 35 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                         vehiculo.Precio_Dia

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(64, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Precio_Dia = __value, vehiculo.Precio_Dia));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\r\n\r\n                        <br><br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(66, "<label for=\"Tipo\" class=\"control-label\"><strong>Seleccione el tipo del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenElement(67, "select");
                        __builder4.AddAttribute(68, "class", "form-control");
                        __builder4.AddAttribute(69, "id", "Tipo");
                        __builder4.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                          TipoVehiculo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(71, "\r\n                            ");
                        __builder4.OpenElement(72, "option");
                        __builder4.AddContent(73, " -- Sin seleccionar -- ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(74, "\r\n                            ");
                        __builder4.OpenElement(75, "option");
                        __builder4.AddContent(76, "Carro");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(77, "\r\n                            ");
                        __builder4.OpenElement(78, "option");
                        __builder4.AddContent(79, "Yipeta");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(80, "\r\n                            ");
                        __builder4.OpenElement(81, "option");
                        __builder4.AddContent(82, "Camioneta");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(83, "\r\n                            ");
                        __builder4.OpenElement(84, "option");
                        __builder4.AddMarkupContent(85, "Camión");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(86, "\r\n                            ");
                        __builder4.OpenElement(87, "option");
                        __builder4.AddContent(88, "Motocicleta");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(89, "\r\n                            ");
                        __builder4.OpenElement(90, "option");
                        __builder4.AddContent(91, "Barco");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(92, "\r\n                            ");
                        __builder4.OpenElement(93, "option");
                        __builder4.AddMarkupContent(94, "Avión");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(95, "\r\n                            ");
                        __builder4.OpenElement(96, "option");
                        __builder4.AddContent(97, "Nave Espacial (space X)");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(98, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(99, "\r\n\r\n                        <br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(100, "<label for=\"Capacidad_Carga\" class=\"control-label\"><strong>Escriba la capacidad de carga del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Double>>(101);
                        __builder4.AddAttribute(102, "class", "form-control");
                        __builder4.AddAttribute(103, "id", "Capacidad_Carga");
                        __builder4.AddAttribute(104, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                                                                   false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(105, "Placeholder", "Capacidad_Carga");
                        __builder4.AddAttribute(106, "value", 
#nullable restore
#line 55 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                              vehiculo.Capacidad_Carga

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(107, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Capacidad_Carga = __value, vehiculo.Capacidad_Carga));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(108, "\r\n\r\n                        <br><br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(109, "<label for=\"Pasajeros\" class=\"control-label\"><strong>Escriba la cantidad de pasajeros:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Int32>>(110);
                        __builder4.AddAttribute(111, "class", "form-control");
                        __builder4.AddAttribute(112, "id", "Pasajeros");
                        __builder4.AddAttribute(113, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                                                      false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(114, "Placeholder", "Pasajeros");
                        __builder4.AddAttribute(115, "value", 
#nullable restore
#line 60 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                       vehiculo.Pasajeros

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(116, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Pasajeros = __value, vehiculo.Pasajeros));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(117, "\r\n\r\n                        <br><br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(118, "<label for=\"Matricula\" class=\"control-label\"><strong>Escriba la matricula del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenMask>(119);
                        __builder4.AddAttribute(120, "class", "form-control");
                        __builder4.AddAttribute(121, "Mask", "**-*****");
                        __builder4.AddAttribute(122, "Pattern", "[^0-9]");
                        __builder4.AddAttribute(123, "id", "Matricula");
                        __builder4.AddAttribute(124, "Placeholder", "Matricula");
                        __builder4.AddAttribute(125, "value", 
#nullable restore
#line 65 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                                       vehiculo.Matricula

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(126, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Matricula = __value, vehiculo.Matricula));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(127, "\r\n\r\n                        <br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(128, "<label for=\"No_Seguro\" class=\"control-label\"><strong>Escriba el número de seguro del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(129);
                        __builder4.AddAttribute(130, "class", "form-control");
                        __builder4.AddAttribute(131, "id", "No_Seguro");
                        __builder4.AddAttribute(132, "Placeholder", "No_Seguro");
                        __builder4.AddAttribute(133, "value", 
#nullable restore
#line 70 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                         vehiculo.No_Seguro

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(134, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.No_Seguro = __value, vehiculo.No_Seguro));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(135, "\r\n\r\n                        <br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(136, "<label for=\"Foto\" class=\"control-label\"><strong>Inserte la foto del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenFileInput<string>>(137);
                        __builder4.AddAttribute(138, "Style", "width:400px");
                        __builder4.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 75 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                      vehiculo.Foto

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(140, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Foto = __value, vehiculo.Foto))));
                        __builder4.AddAttribute(141, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => vehiculo.Foto));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(142, "\r\n\r\n                        <br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(143, "<label for=\"Latitud\" class=\"control-label\"><strong>Escriba la Latitud del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Double>>(144);
                        __builder4.AddAttribute(145, "class", "form-control");
                        __builder4.AddAttribute(146, "id", "Latitud");
                        __builder4.AddAttribute(147, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 80 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                                                   false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(148, "Placeholder", "Latitud");
                        __builder4.AddAttribute(149, "value", 
#nullable restore
#line 80 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                      vehiculo.Latitud

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(150, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Latitud = __value, vehiculo.Latitud));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(151, "\r\n\r\n                        <br><br>\r\n\r\n                        ");
                        __builder4.AddMarkupContent(152, "<label for=\"Longitud\" class=\"control-label\"><strong>Escriba la Longitud del vehiculo:</strong></label>\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenNumeric<Double>>(153);
                        __builder4.AddAttribute(154, "class", "form-control");
                        __builder4.AddAttribute(155, "id", "Longitud");
                        __builder4.AddAttribute(156, "ShowUpDown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 85 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                                                     false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(157, "Placeholder", "Longitud");
                        __builder4.AddAttribute(158, "value", 
#nullable restore
#line 85 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                       vehiculo.Longitud

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(159, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Longitud = __value, vehiculo.Longitud));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(160, "\r\n\r\n                        <br><br>\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(161, "\r\n\r\n");
#nullable restore
#line 90 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                     if (ValidarInputs)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(162, "                        ");
                        __builder4.OpenElement(163, "div");
                        __builder4.AddAttribute(164, "class", "alert alert-danger");
                        __builder4.AddMarkupContent(165, "\r\n                            ");
                        __builder4.AddContent(166, 
#nullable restore
#line 93 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                             MensajeError

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(167, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(168, "\r\n");
#nullable restore
#line 95 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                    }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(169, "\r\n                    ");
                        __builder4.OpenElement(170, "div");
                        __builder4.AddAttribute(171, "class", "d-grid gap-2");
                        __builder4.AddMarkupContent(172, "\r\n                        ");
                        __builder4.OpenElement(173, "button");
                        __builder4.AddAttribute(174, "type", "button");
                        __builder4.AddAttribute(175, "class", "btn btn-success btn-block");
                        __builder4.AddAttribute(176, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                          () => CreateVehiculos()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(177, "Crear");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(178, "\r\n                        ");
                        __builder4.OpenElement(179, "button");
                        __builder4.AddAttribute(180, "type", "button");
                        __builder4.AddAttribute(181, "class", "btn btn-danger btn-block");
                        __builder4.AddAttribute(182, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                         () => cancel()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(183, "Cancelar");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(184, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(185, "\r\n\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(186, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(187, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(188, "\r\n        ");
                __builder2.OpenElement(189, "div");
                __builder2.AddAttribute(190, "class", "col-md-6");
                __builder2.AddMarkupContent(191, "\r\n            <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(192);
                __builder2.AddAttribute(193, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(194, "\r\n                ");
                    __builder3.AddMarkupContent(195, "<h3 class=\"text-center\">Seleccione su latitud y longitud</h3>\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(196);
                    __builder3.AddAttribute(197, "style", "height: 400px");
                    __builder3.AddAttribute(198, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 109 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                             zoom

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(199, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 109 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                           new GoogleMapPosition() { Lat = 18.94983041735482, Lng = -70.74993105485618 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(200, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
                                                                                                                                                                    OnMapClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(201, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(202, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(203, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(204, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Users\LUIS ANTONIO DE AZA\Desktop\commit\Proyecto-Final-P3\Pages\AddVehiculos.razor"
       

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
