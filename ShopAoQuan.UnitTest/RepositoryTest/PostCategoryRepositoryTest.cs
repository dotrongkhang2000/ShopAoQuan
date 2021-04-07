using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopAoQuan.Data.Infrastructure;
using ShopAoQuan.Data.Repositories;
using ShopAoQuan.Model.Models;

namespace ShopAoQuan.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IFooterRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new FooterRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }



        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            Footer category = new Footer();
            category.ID = "Test category";
            category.Content = "category";
            

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            //Assert.AreEqual(3, result.ID);
        }

    }
}