﻿namespace BlogWebSite.Core.ResultMessages
{
    public static class Messages
    {
        public static class ToastTitle
        {
            public static string Success = "İşlem Başarılı";
            public static string Error = "İşlem Başarısız";
        }

        public static class GlobalMessage
        {
            public static string Success = "İşlem başarılı";
            public static string Error = "İşlem sırasında hata oluştu. Tekrar deneyiniz.";
        }

        public static class Role
        {
            public static string Add(string roleName)
            {
                return $"{roleName} isimli rol başarıyla eklenmiştir.";
            }

            public static string Update(string roleName)
            {
                return $"{roleName} isimli rol başarıyla güncellenmiştir.";
            }

            public static string Delete(string roleName)
            {
                return $"{roleName} isimli rol başarıyla silinmiştir.";
            }
            public static string UndoDelete(string roleName)
            {
                return $"{roleName} isimli rol başarıyla geri alınmıştır.";
            }
        }
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla eklenmiştir.";
            }

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir.";
            }

            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silinmiştir.";
            }
            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla geri alınmıştır.";
            }
        }
        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} başlıklı kategori başarıyla eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} başlıklı kategori başarıyla güncellenmiştir.";
            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName} başlıklı kategori başarıyla silinmiştir.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} başlıklı kategori başarıyla geri alınmıştır.";
            }
        }

        public static class User
        {
            public static string Add(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla eklenmiştir.";
            }

            public static string Update(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla güncellenmiştir.";
            }

            public static string Delete(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla silinmiştir.";
            }
            public static string UndoDelete(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla geri alınmıştır.";
            }
        }


    }
}
