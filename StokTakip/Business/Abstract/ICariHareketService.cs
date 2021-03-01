using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICariHareketService
    {
        IResult Add(CariHareket cariHareket);
        IResult Update(CariHareket cariHareket);
        IResult Delete(CariHareket cariHareket);
        IDataResult<List<CariHareket>> GetAll();
    }
}
