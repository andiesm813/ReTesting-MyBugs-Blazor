using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ReTestingMyBugs.Pages;

namespace TestReTestingMyBugs
{
	[Collection("ReTestingMyBugs")]
	public class TestView_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonGroupModule),
				typeof(IgbToggleButtonModule),
				typeof(IgbChipModule),
				typeof(IgbSwitchModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRatingModule),
				typeof(IgbBadgeModule),
				typeof(IgbAvatarModule),
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
				typeof(IgbSnackbarModule));
			var componentUnderTest = ctx.RenderComponent<View_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
