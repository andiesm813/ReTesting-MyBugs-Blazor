using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ReTestingMyBugs;
using ReTestingMyBugs.Service;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IServiceService, ServiceService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule),
        typeof(IgbButtonModule),
        typeof(IgbButtonGroupModule),
        typeof(IgbToggleButtonModule),
        typeof(IgbChipModule),
        typeof(IgbSwitchModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbRatingModule),
        typeof(IgbAvatarModule),
        typeof(IgbBadgeModule),
        typeof(IgbTreeModule),
        typeof(IgbBannerModule),
        typeof(IgbCardModule),
        typeof(IgbTabsModule),
        typeof(IgbStepperModule),
        typeof(IgbInputModule),
        typeof(IgbSelectModule),
        typeof(IgbDatePickerModule),
        typeof(IgbTextareaModule),
        typeof(IgbSliderModule),
        typeof(IgbCalendarModule),
        typeof(IgbSnackbarModule),
        typeof(IgbComboModule)
    );
}