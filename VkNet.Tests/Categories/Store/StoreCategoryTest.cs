using FluentAssertions;
using VkNet.Tests.Infrastructure;
using Xunit;

namespace VkNet.Tests.Categories.Store;

public class StoreCategoryTest : CategoryBaseTest
{
	protected override string Folder => "Store";

	[Fact]
	public void AddStickersToFavorite()
	{
		Url = "https://api.vk.com/method/store.addStickersToFavorite";

		ReadCategoryJsonPath(nameof(AddStickersToFavorite));

		var result = Api.Store.AddStickersToFavorite(new()
		{
			StickerIds = ["126", "70"]
		});

		result.Should()
			.BeTrue();
	}
}