using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKullanıcıService
    {
        IDataResult<List<Kullanıcı>> GetAll();
        IResult Add(Kullanıcı kullanıcı);
        IResult Delete(Kullanıcı kullanıcı);
        IResult UserAutenticacion(Kullanıcı kullanıcı);
    }
}
