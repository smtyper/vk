using FluentAssertions;
using VkNet.Tests.Infrastructure;
using Xunit;

namespace VkNet.Tests.Categories.Calls;

public class CallsCategoryTest : CategoryBaseTest
{
	protected override string Folder => "Calls";

	[Fact]
	public void ForceFinish()
	{
		Url = "https://api.vk.com/method/calls.forceFinish";

		ReadCategoryJsonPath(nameof(ForceFinish));

		var result = Api.Calls.ForceFinish(new()
		{
			CallId = "10c5386e-10cb-43c6-999a-d01a37ee71e0"
		});

		result.Should()
			.BeTrue();
	}
}