using blog.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace blog.UnitTests
{
    [TestClass]
    public class TestHarness
    {
        private const string _conn = "Data Source=MU00121366\\MSSQLSERVER16;Initial Catalog=blog;Integrated Security=True";        
        private DbContextOptions<DataContext> _contextOptions;
        private DataContext _context;
        //private IMapper _mapper;

        public TestHarness()
        {
            _contextOptions = new DbContextOptionsBuilder<DataContext>()
             .UseSqlServer(_conn)
             .Options;
            _context = new DataContext(_contextOptions);

            //var config = new AutoMapper.MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile(new Proms.Service.AutoMapperProfile());
            //});
            //_mapper = config.CreateMapper();

        }

        [TestMethod]
        public void GetUserTest()
        {
            var dao = new Dao(_context);

            var users = dao.GetUserById(1);
        }
    }
}
