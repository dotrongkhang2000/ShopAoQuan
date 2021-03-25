using System;

namespace ShopAoQuan.Data.Infrastructure
{
    public interface IDbFactoty : IDisposable
    {
        //tiền trình đầu tiên
        ShopQuanAoDbContext Init();
    }
}