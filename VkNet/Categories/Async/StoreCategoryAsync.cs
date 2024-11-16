using VkNet.Abstractions.Category;
using VkNet.Model;
using VkNet.Utils;

namespace VkNet.Categories;

/// <inheritdoc cref="IStoreCategory"/>
public partial class StoreCategory
{
	/// <inheritdoc />
	public bool AddStickersToFavorite(StoreAddStickerToFavoriteParams @params) =>
		_vk.Call<bool>("store.addStickersToFavorite", new()
		{
			{
				"sticker_ids", @params.StickerIds
			}
		});

	/// <inheritdoc />
	public VkCollection<Sticker> GetFavoriteStickers() =>
		_vk.Call<VkCollection<Sticker>>("store.getFavoriteStickers", new());
}