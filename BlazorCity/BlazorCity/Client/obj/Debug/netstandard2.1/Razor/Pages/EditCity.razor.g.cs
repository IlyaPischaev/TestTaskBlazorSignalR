#pragma checksum "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc3b76a47fcf84d57f6c8034f5d1cca45a40453"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCity.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using BlazorCity.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using BlazorCity.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using BlazorCity.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcity/{id}")]
    public partial class EditCity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
                  city

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
                                       UpdateCity

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "container-fluid");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col");
                __builder2.OpenElement(14, "table");
                __builder2.AddAttribute(15, "class", "table table-striped");
                __builder2.AddMarkupContent(16, "<thead class=\"table-dark\"><tr><th scope=\"col\">Название города</th>\r\n                            <th scope=\"col\">Население</th>\r\n                            <th scope=\"col\">Дата основания города</th></tr></thead>\r\n                    ");
                __builder2.OpenElement(17, "tbody");
                __builder2.OpenElement(18, "tr");
                __builder2.OpenElement(19, "td");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
                                                                    city.CityName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => city.CityName = __value, city.CityName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "td");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
                                                                    city.CityPopulation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => city.CityPopulation = __value, city.CityPopulation));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "td");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "type", "date");
                __builder2.AddAttribute(35, "min", "0000-01-01");
                __builder2.AddAttribute(36, "max", 
#nullable restore
#line 31 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
                                                              value

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
                                                     cityDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cityDate = __value, cityDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "type", "submit");
                __builder2.AddAttribute(46, "class", "btn btn-success");
                __builder2.AddAttribute(47, "disabled", 
#nullable restore
#line 39 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
                                                                                  !IsConnected

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(48, "Изменить город");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "type", "submit");
                __builder2.AddAttribute(54, "class", "btn btn-danger");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
                                                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(56, "Отмена");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Work\Новая папка (4)\BlazorCity\BlazorCity\Client\Pages\EditCity.razor"
       
    private HubConnection hubConnection;
    [Parameter]
    public string id { get; set; }
    DateTime? value = DateTime.Now;
    DateTime? cityDate;
    string date;

    City city = new City();

    protected override async Task OnInitializedAsync()
    {

        HubConnection();

        GetCityListener();

        await hubConnection.StartAsync();
        await AddOneCity(Int32.Parse(id));
    }

    private void HubConnection()
    {
        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/CityHub"))
        .Build();
    }

    private void GetCityListener()
    {
        hubConnection.On<City>("ReceiveOneCity", (cityData) =>
        {
            city = cityData;
            date = (city.CityFoundationYear * 10000 + city.CityDoundationMonth * 100 + city.CityDoundationDay).ToString();
            cityDate = DateTime.ParseExact(date, "yyyyMMdd", null);
            StateHasChanged();
        });
    }

    public async Task UpdateCity()
    {
        date = cityDate?.ToString("yyyyMMdd");

        if (date == null)
        {
            city.CityFoundationYear = city.CityDoundationMonth = city.CityDoundationDay = 0;
        }
        else
        {
            city.CityFoundationYear = Int32.Parse(date.Substring(0, 4));
            city.CityDoundationMonth = Int32.Parse(date.Substring(4, 2));
            city.CityDoundationDay = Int32.Parse(date.Substring(6));
        }

        await EditCityData(city);

        NavigationManager.NavigateTo("");
    }

    Task AddOneCity(int id)
    {
        return hubConnection.SendAsync("SendOneCity", id);
    }

    Task EditCityData(City city)
    {
        return hubConnection.SendAsync("SendEditCity", city);
    }

    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
