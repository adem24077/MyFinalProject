using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi.";
        public  static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün bulunabilir.";
        public static string ProductNameAlreadyExists="Bu isimde başka bir ürün var.";
        public static string CategoryLimitExceded="Kategori sayısı 15'ten fazla ekleme yapamazsınız.";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt olundu.";
        internal static string UserNotFound="Kullanıcı bulunamadı.";
        internal static string PasswordError="Hatalı şifre";
        internal static string SuccessfulLogin="Giriş";
        internal static string UserAlreadyExists="Kullanıcı Mevcut";
        internal static string AccessTokenCreated="Giriş token çalıştırıldı.";
    }
}
