using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITahsilatService
    {
        IResult Add(Tahsilat tahsilat);
        IResult Update(Tahsilat tahsilat);
        IResult Delete(Tahsilat tahsilat);
        IDataResult<List<Tahsilat>> GetAll();
    }
}
