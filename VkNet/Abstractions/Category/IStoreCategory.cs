using VkNet.Model;
using VkNet.Utils;

namespace VkNet.Abstractions.Category;

/// <summary>
/// Методы для работы со стикерами и продуктами
/// </summary>
public interface IStoreCategory : IStoreCategoryAsync
{
	/// <inheritdoc cref="IStoreCategoryAsync.AddStickersToFavoriteAsync"/>
	bool AddStickersToFavorite(StoreAddStickerToFavoriteParams @params);

	/// <inheritdoc cref="IStoreCategoryAsync.GetFavoriteStickersAsync"/>
	VkCollection<Sticker> GetFavoriteStickers();
}