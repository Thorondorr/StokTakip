using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICariService
    {
        IDataResult<List<Cari>> GetAll();
        IResult Add(Cari cari);
        IResult Delete(Cari cari);
        IResult Update(Cari cari);
        IDataResult<List<Cari>> Search(Cari cari);
    }
}
