#pragma checksum "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cf699e0ce5ec015c73ae7d0f1e799e239a5ac8"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\_Imports.razor"
using Assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
using Assigntment_2_Web_API;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Register</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<label>User name:</label>\r\n            ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "placeholder", "user name");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
                                                                    username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.AddMarkupContent(12, "<label>Password</label>\r\n            ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "password");
            __builder.AddAttribute(15, "placeholder", "password");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
                                                                       password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "color:red");
            __builder.AddContent(21, 
#nullable restore
#line 17 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
                        errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "color:green");
            __builder.AddContent(25, 
#nullable restore
#line 18 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
                                  successMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "choices-div");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
                                    PerformRegistration

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\r\n        Register \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    or\r\n    ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", "");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
                         Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\r\n        cancel\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\simon\RiderProjects\Assignment_2_DNP_Client\Assignment 1\Pages\Register.razor"
       
    private string username;
    private string password;
    private string errorMessage;
    private string successMessage;

    public async Task PerformRegistration() {
        if (username == null || username.Equals("") || password == null || password.Equals(""))
        {
            Console.WriteLine("Info lacking!");
            errorMessage = "Please fill out all the forms!";
            successMessage = "";
            return;
        }

        User NewUser = new User();
        NewUser.userName = username;
        NewUser.role = "Admin";
        NewUser.password = password;

        // We check if the user exists
        User temp;
        try
        {
            temp = await UserService.GetUser(username);
            if (temp.userName != null)
            {
                        errorMessage = "Username already taken! Try again.";
                        successMessage = "";
            } else 
            {
                        UserService.AddUserAsync(NewUser);
                        successMessage = "New user successfully registered!";
                        errorMessage = "";
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed to retrieve existing users..."  + e.Message);
            errorMessage = "Failed to retrieve existing users!";
            StateHasChanged();
        }
    }

    public void Cancel() {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
