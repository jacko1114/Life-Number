using Life_Number.Models;
using Life_Number.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Life_Number.Services
{
  public class LifeNumberService : INumberService
  {
    private readonly LifeNumberRepository _repo;

    public LifeNumberService()
    {
      _repo = new LifeNumberRepository();
    }

    public LifeNumberData GetLifeNumberData(string constellation, int number)
    {
      var datas = _repo.datas;

      constellation = constellation.Substring(0, 1).ToUpper() + constellation.Substring(1);

      return datas.FirstOrDefault(x => x.ConstellationName == constellation && x.LifeNumber == number);
    }
    public List<LifeNumberData> GetLifeNumberDatas()
    {
      return _repo.datas;
    }
  }
}
