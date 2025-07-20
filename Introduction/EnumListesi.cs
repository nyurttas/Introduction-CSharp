namespace Introduction
{
    /*
     Enumaration (Enum) listesi, belirli bir veri tipindeki sabit değerlerin bir araya getirilmesiyle oluşturulan bir veri türüdür.
    Durumları Belirtirken: beklemede, tamamlandı, iptal edildi
    Sabitler    : Haftanın günleri, aylar
    Seçenekler  : Cinsiyet, medeni durum
     */
    enum HaftaninGunleri
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum Cinsiyet
    {
        Kadın,
        Erkek
    }

    enum UrunDurumu
    {
        Stokta,
        Siparişte,
        TeminEdilemiyor,
        TeminEdildi
    }

    enum Kategoriler:byte
    {
        Elektronik = 1,
        Bahçe_Malzemeleri = 2
    }

}
