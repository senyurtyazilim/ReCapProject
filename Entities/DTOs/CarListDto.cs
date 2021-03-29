﻿namespace DataAccess.Concrete.EntityFramework
{
    public class CarListDto
    {
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public string ColorName { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
        public int BrandId { get; set; }
        public int CarId { get; set; }
        public int ColorId { get; set; }
        public long DailyPrice { get; set; }
        public string ImagePath { get; set; }
    }
}