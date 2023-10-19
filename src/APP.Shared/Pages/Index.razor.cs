using Microsoft.AspNetCore.Components;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using APP.Infrastructure.Events;
using CommunityToolkit.Mvvm.Messaging;

namespace App.Shared.Pages;

public partial class Index
{

    [Inject] IServiceProvider ServiceProvider { get; set; }

    protected override async Task OnInitializedAsync()
    {
      var freesql =  ServiceProvider.GetAutofacRoot().Resolve<IFreeSql>();
    }
}
