using Bunit;
using Microsoft.Extensions.DependencyInjection;
using ReTestingMyBugs.Pages;
using ReTestingMyBugs.Service;

namespace TestReTestingMyBugs
{
	[Collection("ReTestingMyBugs")]
	public class TestView_2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbStepperModule),
				typeof(IgbDatePickerModule),
				typeof(IgbComboModule),
				typeof(IgbInputModule),
				typeof(IgbSelectModule),
				typeof(IgbTextareaModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			ctx.Services.AddScoped<IServiceService>(sp => new MockServiceService());
			var componentUnderTest = ctx.RenderComponent<View_2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
