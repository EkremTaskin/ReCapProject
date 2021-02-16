using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService:IBaseService<Car>
    {
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
