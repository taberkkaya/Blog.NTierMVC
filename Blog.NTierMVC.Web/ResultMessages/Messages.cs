namespace Blog.NTierMVC.Web.ResultMessages
{
    public static class Messages
    {
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

            public static string SafeDelete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silinmiştir.";
            }
        }

        public static class Category
        {
            public static string Add(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı kategori başarıyla eklenmiştir.";
            }

            public static string Update(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı kategori başarıyla güncellenmiştir.";
            }

            public static string SafeDelete(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı kategori başarıyla silinmiştir.";
            }
        }
    }
}
