using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LanZhouBeefNoodles.Models
{
    public class NoodleRepository : INoodleRepository
    {
        //使用数据库连接对象
        private readonly AppDbContext _context;
        public NoodleRepository(AppDbContext _appDbContext)
        {
            _context = _appDbContext;
        }
        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _context.Noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _context.Noodles.FirstOrDefault(x => x.Id == id);
        }
    }
}
