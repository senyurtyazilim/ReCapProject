﻿using System.Collections.Generic;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;


namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<List<CarDetailDto>> GetCarDetailsId(int id);


        IDataResult<List<CarListDto>> GetCarList();
        IDataResult<List<CarListDto>> GetCarListWithBrand(int brandId);
        IDataResult<List<CarListDto>> GetCarListWithColor(int colorId);
        IDataResult<List<CarListDto>> GetCarListWithBrandName(string brandName);
        IDataResult<List<CarListDto>> GetCarListWithColorName(string colorName);
        IDataResult<List<CarListDto>> GetCarDetailsWithImage(int id);

        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
