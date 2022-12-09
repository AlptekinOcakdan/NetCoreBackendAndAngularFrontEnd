using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün adı geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Kategoriye 10 üründen fazlası eklenemez.";
        public static string ProductNameAlreadyExist="Var olan bir ad eklenemez.";
        public static string CheckIfCategoryLimitExceeded="Kategori sayısı 15'ten fazla olmaz.";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Parola hatası.";
        public static string SuccessfulLogin="Başarıyla giriş yapıldı.";
        public static string UserAlreadyExists="Kullanıcı var.";
        public static string AccessTokenCreated="Giriş token'ı üretildi.";
    }
}
