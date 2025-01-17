namespace DI_Service_Lifetime.Services
{
    public class SingletonGuidService : ISingletonGuidService
    {
        private readonly Guid Id;   // 確保欄位的值在物件實例化之後無法被修改

        public SingletonGuidService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
/*
類別實作介面（或稱 "實現介面"）時，
必須實作介面中所有的成員，
否則會編譯失敗並出現像你提到的錯誤訊息。
*/