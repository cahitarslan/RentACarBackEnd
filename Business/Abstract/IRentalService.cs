﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);

        IDataResult<List<RentalDetailsDto>> GetRentalDetails();
    }
}
