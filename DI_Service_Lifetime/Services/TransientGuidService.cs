namespace DI_Service_Lifetime.Services
{
    public class TransientGuidService : ITransientGuidService
    {
        private readonly Guid Id;   // 確保欄位的值在物件實例化之後無法被修改

        public TransientGuidService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
