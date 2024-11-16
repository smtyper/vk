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

	[Fact]
	public void GetFavoriteStickers()
	{
		Url = "https://api.vk.com/method/store.getFavoriteStickers";

		ReadCategoryJsonPath(nameof(GetFavoriteStickers));

		var result = Api.Store.GetFavoriteStickers();

		result.Count.Should()
			.Be(2);

		var first = result[0];

		first.Id.Should()
			.Be(126);

		first.InnerType.Should()
			.Be("base_sticker_new");

		first.IsAllowed.Should()
			.BeTrue();

		var second = result[1];

		second.Id.Should()
			.Be(70);

		second.InnerType.Should()
			.Be("base_sticker_new");

		second.IsAllowed.Should()
			.BeFalse();
	}
}