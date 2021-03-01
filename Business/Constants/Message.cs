using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
	public static class Message
	{
		public static string CarAdded = "Araba Eklendi!";
		public static string CarDeleted = "Araba Silindi!";
		public static string CarUpdated = "Araba Güncellendi!";
		public static string CarNameInvalid = "Araba ismi Geçersiz!";
		public static string MaintenanceTime = "Sistem Bakımda!";
		public static string CarListed = "Arabalar Listelendi!";

		public static string ColorAdded = "Renk Eklendi!";
		public static string ColorDeleted = "Renk Silindi!";
		public static string ColorUpdated = "Renk Güncellendi!";
		public static string ColorNameInvalid = "Renk ismi Geçersiz!";
		public static string ColorListed = "Renkler Listelendi!";
		public static string ImageLimitExceded = "En fazla 5 resim Eklenebilir!";
		public static string ImageAdded = "Resim Eklendi!";
		public static string Error = "Hata Mesajı!";
		public static string CarImageDeleted = "CarImage Silindi!";
		public static string UserNotFound = "Kullanıcı Bulunamadı!";
		public static string PasswordError = "Hatalı Şifre!";
		public static string SuccessFullLogin = "Giriş Yapıldı!";
		public static string UserAlreadyExists = "Bu Kullanıcı Zaten Mevcut!";
		public static string UserRegistered = "Kullanıcı Başarıyla Kydedildi!";
		public static string AccessTokenCreated = "AccessToken Başarıyla Oluşturuldu!";
		public static string AuthorizationDenied = "Yetkiniz Yok!";
	}
}
