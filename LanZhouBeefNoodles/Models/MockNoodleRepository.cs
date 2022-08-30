using System.Collections.Generic;

namespace LanZhouBeefNoodles.Models
{
    public class MockNoodleRepository : INoodleRepository
    {
        private List<Noodle> _noodleList;

        public MockNoodleRepository()
        {
            if (_noodleList == null)
            {
                InitializeNoodle();
            }
        }

        private void InitializeNoodle()
        {
            _noodleList = new List<Noodle>
            {
                new Noodle { Id = 1, Name = "毛细", Price = 12, ShortDescription = "如发丝般细", LongDescription = "真的好细好细好细啊", ImageURL="/images/毛细.png"},
                new Noodle { Id = 2, Name = "细", Price = 10, ShortDescription = "普通细", LongDescription = "还是挺细的", ImageURL="/images/细.png"},
                new Noodle { Id = 3, Name = "三细", Price = 11, ShortDescription = "有点粗了", LongDescription = "比细的粗点，比二细细点", ImageURL="/images/三细.png"},
                new Noodle { Id = 4, Name = "二细", Price = 10, ShortDescription = "粗了", LongDescription = "粗的才有嚼劲", ImageURL="/images/二细.png"},
                new Noodle { Id = 5, Name = "二柱子", Price = 11, ShortDescription = "太粗了", LongDescription = "粗得快咬不动了", ImageURL="/images/二柱子.png"},
                new Noodle { Id = 6, Name = "韭叶子", Price = 12, ShortDescription = "扁的", LongDescription = "韭猜叶一样宽", ImageURL="/images/韭叶子.png"},
                new Noodle { Id = 7, Name = "薄宽", Price = 11, ShortDescription = "开始宽了", LongDescription = "比韭叶宽一点，比大宽窄一点", ImageURL="/images/薄宽.png"},
                new Noodle { Id = 8, Name = "大宽", Price = 10, ShortDescription = "裤带面", LongDescription = "比嘴还宽了", ImageURL="/images/大宽.png"},
                new Noodle { Id = 9, Name = "荞麦棱子", Price = 15, ShortDescription = "立方体的", LongDescription = "好像知道师傅怎么拉出来的", ImageURL="/images/荞麦棱子.png"},
                new Noodle { Id = 10, Name = "一窝丝", Price = 15, ShortDescription = "这是啥", LongDescription = "我也没吃过", ImageURL="/images/一窝丝.png"}
            };
        }

        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _noodleList;
        }

        public Noodle GetNoodleById(int id)
        {
            return _noodleList.Find(x => x.Id == id);
        }
    }
}
