using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface ITediyeService
    {
        IResult Add(Tediye tediye);
        IResult Update(Tediye tediye);
        IResult Delete(Tediye tediye);
        IResult CreateTediye(Fatura fatura);
        IDataResult<List<Tediye>> GetAll();
    }
}
