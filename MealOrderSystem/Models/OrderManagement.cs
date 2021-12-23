using System;
using System.Collections.Generic;
using System.Web;


namespace MealSystem.Models
{
    public class MealData
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public int MealPrice { get; set; }
        public string MealUrl { get; set; }
    }
    public class Order : MealData
    {

        public int TotalPrice { get; set; }
        public string MealQuantity { get; set; }
    }
    public class DataManagement
    {
        public List<MealData> GetMealMenu()
        {
            List<MealData> mealDatas = new List<MealData>();
            mealDatas.Add(new MealData() { Id = 001, MealName = $"菲力牛排", MealPrice = 260 , MealUrl = "https://cdn2.ettoday.net/images/4909/d4909510.jpg" });
            mealDatas.Add(new MealData() { Id = 002, MealName = $"教父牛排", MealPrice = 250 , MealUrl = "https://www.daisyyohoho.com/wp-content/uploads/2020/07/meatgq-30.jpg" });
            mealDatas.Add(new MealData() { Id = 003, MealName = $"威靈頓牛排", MealPrice = 300 , MealUrl = "https://resource01-proxy.ulifestyle.com.hk/res/v3/image/content/2605000/2609151/cover_1024.jpg" });
            mealDatas.Add(new MealData() { Id = 004, MealName = $"肋眼牛排", MealPrice = 370 , MealUrl = "https://www.da-meat.com/upfile/editor/images/shutterstock_477023761.jpg" });
            mealDatas.Add(new MealData() { Id = 005, MealName = $"鐵板麵", MealPrice = 50 , MealUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/54714095/54714095_11.jpg" });
            mealDatas.Add(new MealData() { Id = 006, MealName = $"可樂", MealPrice = 20 , MealUrl = "https://media.etmall.com.tw/nximg/002126/2126818/2126818-3_xxl.jpg" });
            mealDatas.Add(new MealData() { Id = 007, MealName = $"雪碧", MealPrice = 20 , MealUrl = "https://www.costco.com.tw/medias/sys_master/images/h06/h39/11953650106398.jpg" });
            mealDatas.Add(new MealData() { Id = 008, MealName = $"紅茶", MealPrice = 10, MealUrl = "https://lab.mos.com.tw/archive/image/product3/images/1579505687.jpg" });
            return mealDatas;
        }
    }
}
