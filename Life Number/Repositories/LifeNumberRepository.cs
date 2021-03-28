using Life_Number.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Life_Number.Repositories
{
  public class LifeNumberRepository
  {
    public List<LifeNumberData> datas { get; set; }

    public LifeNumberRepository()
    {
      datas = GetDataFromFile();
    }

    public List<LifeNumberData> GetDataFromFile()
    {
      List<LifeNumberData> lifeList = new List<LifeNumberData>();
      string[] datas = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/" , "LifeData.txt"));

      string star = "";
      foreach (var item in datas)
      {
        string line = item.Trim();
        if (line != string.Empty)
        {
          if (line.Contains("【"))
          {
            star = line.Split(' ')[1];
            continue;
          }
          else
          {
            string[] s = line.Split('：');
            LifeNumberData data = new LifeNumberData()
            {
              ConstellationName = star,
              LifeNumber = int.Parse(s.First().Last().ToString()),
              Info = s.Last()
            };
            lifeList.Add(data);
          }
        }
      }

      return lifeList;
    }
  }
}
