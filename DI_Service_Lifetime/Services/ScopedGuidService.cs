namespace DI_Service_Lifetime.Services
{
    public class ScopedGuidService : IScopedGuidService
    {
        private readonly Guid Id;   // 確保欄位的值在物件實例化之後無法被修改

        public ScopedGuidService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
