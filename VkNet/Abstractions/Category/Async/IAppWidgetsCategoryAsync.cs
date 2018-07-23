using System;
using System.Threading.Tasks;

namespace VkNet.Abstractions.Category
{
	/// <summary>
	/// Список методов секции appWidgets
	/// </summary>
	public interface IAppWidgetsCategoryAsync
	{
		/// <summary>
		/// Позволяет получить адрес для загрузки фотографии в коллекцию приложения для виджетов приложений сообществ.
		/// </summary>
		/// <param name = "imageType">
		/// Тип изображения. Возможные значения:
		/// 24x24;
		/// 50x50;
		/// 160x160;
		/// 160x240;
		/// 510x128.
		/// обязательный параметр
		/// </param>
		/// <returns>
		/// Возвращает объект с единственным полем upload_url, содержащим URL для загрузки изображения.
		/// Для загрузки изображения сгенерируйте POST-запрос с файлом в поле image на полученный адрес, а затем вызовите метод appWidgets.saveAppImage.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/appWidgets.getAppImageUploadServer
		/// </remarks>
		Task<Uri> GetAppImageUploadServerAsync(object imageType);

		/// <summary>
		/// Позволяет получить коллекцию изображений, загруженных для приложения, в виджетах приложений сообществ.
		/// </summary>
		/// <returns>
		/// Возвращает общее число результатов в поле count (integer) и массив объектов, описывающих изображения, в поле items (array).
		/// Каждый объект массива  items содержит следующие поля:
		/// id (string) — идентификатор изображения. Обратите внимание, идентификаторы изображений для виджетов отличаются от обычных фотографий, и НЕ представляют собой сочетание owner_id+"_"+photo_id. Полученный идентификатор нужно использовать в коде виджета «как есть».
		/// type (string) — тип изображения. Возможные значения:
		/// 160x160,
		/// 160x240,
		/// 24x24,
		/// 510x128,
		/// 50x50.
		/// images  (array) — массив копий изображения. Каждый объект в массиве содержит следующие поля:
		/// url (string) — URL копии;
		/// width (integer) — ширина в px;
		/// height (integer) — высота в px.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/appWidgets.getAppImages
		/// </remarks>
		Task<Uri> GetAppImagesAsync();

		/// <summary>
		/// Позволяет получить адрес для загрузки фотографии в коллекцию сообщества для виджетов приложений сообществ.
		/// </summary>
		/// <returns>
		/// Возвращает объект с единственным полем upload_url, содержащим URL для загрузки изображения.
		/// Для загрузки изображения сгенерируйте POST-запрос с файлом в поле image на полученный адрес, а затем вызовите метод appWidgets.saveGroupImage.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/appWidgets.getGroupImageUploadServer
		/// </remarks>
		Task<Uri> GetGroupImageUploadServerAsync();

		/// <summary>
		/// Позволяет получить коллекцию изображений, загруженных для приложения, в виджетах приложений сообществ.
		/// </summary>
		/// <returns>
		/// Возвращает общее число результатов в поле count (integer) и массив объектов, описывающих изображения, в поле items (array).
		/// Каждый объект массива  items содержит следующие поля:
		/// id (string) — идентификатор изображения. Обратите внимание, идентификаторы изображений для виджетов отличаются от обычных фотографий, и НЕ представляют собой сочетание owner_id+"_"+photo_id. Полученный идентификатор нужно использовать в коде виджета «как есть».
		/// type (string) — тип изображения. Возможные значения:
		/// 160x160,
		/// 160x240,
		/// 24x24,
		/// 510x128,
		/// 50x50.
		/// images  (array) — массив копий изображения. Каждый объект в массиве содержит следующие поля:
		/// url (string) — URL копии;
		/// width (integer) — ширина в px;
		/// height (integer) — высота в px.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/appWidgets.getGroupImages
		/// </remarks>
		Task<Uri> GetGroupImagesAsync();

		/// <summary>
		/// Позволяет получить изображение для виджетов приложений сообществ по его идентификатору.
		/// </summary>
		/// <returns>
		/// Возвращает объект, который содержит следующие поля:
		/// id (string) — идентификатор изображения. Обратите внимание, идентификаторы изображений для виджетов отличаются от обычных фотографий, и НЕ представляют собой сочетание owner_id+"_"+photo_id. Полученный идентификатор нужно использовать в коде виджета «как есть».
		/// type (string) — тип изображения. Возможные значения:
		/// 160x160,
		/// 160x240,
		/// 24x24,
		/// 510x128,
		/// 50x50.
		/// images  (array) — массив копий изображения. Каждый объект в массиве содержит следующие поля:
		/// url (string) — URL копии;
		/// width (integer) — ширина в px;
		/// height (integer) — высота в px.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/appWidgets.getImagesById
		/// </remarks>
		Task<Uri> GetImagesByIdAsync();

		/// <summary>
		/// Позволяет сохранить изображение в коллекцию приложения для виджетов приложений сообществ после загрузки на сервер.
		/// </summary>
		/// <param name = "hash">
		/// Параметр hash, полученный после загрузки на сервер. строка, обязательный параметр
		/// </param>
		/// <param name = "image">
		/// Параметр image, полученный после загрузки на сервер. строка, обязательный параметр
		/// </param>
		/// <returns>
		/// Возвращает объект, который содержит следующие поля:
		/// id (string) — идентификатор изображения.
		/// type (string) — тип изображения. Возможные значения:
		/// 160x160,
		/// 160x240,
		/// 24x24,
		/// 510x128,
		/// 50x50.
		/// images  (array) — массив копий изображения. Каждый объект в массиве содержит следующие поля:
		/// url (string) — URL копии;
		/// width (integer) — ширина в px;
		/// height (integer) — высота в px.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/appWidgets.saveAppImage
		/// </remarks>
		Task<Uri> SaveAppImageAsync(string hash, string image);

		/// <summary>
		/// Позволяет сохранить изображение в коллекцию сообщества для виджетов приложений сообществ. после загрузки на сервер.
		/// </summary>
		/// <returns>
		/// Возвращает объект, который содержит следующие поля:
		/// id (string) — идентификатор изображения.
		/// type (string) — тип изображения. Возможные значения:
		/// 160x160,
		/// 160x240,
		/// 24x24,
		/// 510x128,
		/// 50x50.
		/// images  (array) — массив копий изображения. Каждый объект в массиве содержит следующие поля:
		/// url (string) — URL копии;
		/// width (integer) — ширина в px;
		/// height (integer) — высота в px.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/appWidgets.saveGroupImage
		/// </remarks>
		Task<Uri> SaveGroupImageAsync();

		/// <summary>
		/// Позволяет обновить виджет приложения сообщества.
		/// </summary>
		/// <returns>
		/// После успешного выполнения возвращает 1.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/appWidgets.update
		/// </remarks>
		Task<bool> UpdateAsync();
	}
}