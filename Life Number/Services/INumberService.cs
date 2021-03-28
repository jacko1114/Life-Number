using Life_Number.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Life_Number.Services
{
  public interface INumberService
  {
    LifeNumberData GetLifeNumberData(string constellation,int number);

    List<LifeNumberData> GetLifeNumberDatas();
  }
}
