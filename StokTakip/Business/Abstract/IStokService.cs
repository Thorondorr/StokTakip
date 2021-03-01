using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStokService
    {
        IResult Add(Stok stok);
        IResult Update(Stok stok);
        IResult Delete(Stok stok);
        IDataResult<List<Stok>> GetAll();
    }
}
