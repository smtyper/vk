﻿using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Utils;

namespace VkNet.Abstractions;

/// <summary>
/// Методы для работы со стикерами и продуктами
/// </summary>
public interface IStoreCategoryAsync
{
	/// <summary>
	/// Добавляет стикер в избранные.
	/// </summary>
	/// <param name="params">Параметры запроса</param>
	/// <param name="token">Токен отмены операции.</param>
	/// <returns>
	/// После успешного выполнения возвращает 1.
	/// </returns>
	/// <remarks>
	/// Страница документации ВКонтакте https://dev.vk.com/ru/method/store.addStickersToFavorite
	/// </remarks>
	Task<bool> AddStickersToFavoriteAsync(StoreAddStickerToFavoriteParams @params,
										CancellationToken token = default);

	/// <summary>
	/// Возвращает список избранных стикеров.
	/// </summary>
	/// <param name="token">Токен отмены операции</param>
	/// <returns>После успешного выполнения возвращает список объектов Sticker</returns>
	/// <remarks>
	/// Страница документации ВКонтакте https://dev.vk.com/ru/method/store.getFavoriteStickers
	/// </remarks>
	Task<VkCollection<Sticker>> GetFavoriteStickersAsync(CancellationToken token = default);

	/// <summary>
	/// Возвращает список продуктов.
	/// </summary>
	/// <param name="params">Параметры запроса</param>
	/// <param name="token">Токен отмены операции</param>
	/// <returns>После успешного выполнения возвращает список объектов Product</returns>
	Task<VkCollection<Product>> GetProductsAsync(StoreGetProductsParams @params,
												CancellationToken token = default);
}