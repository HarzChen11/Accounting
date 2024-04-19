using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.記帳
{
    internal class CSVHelper
    {
        public List<T> ReadCSVModel<T>(DateTime StartTime, DateTime EndTime) where T : new()
        {
            string dirPath = ($@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\記帳本檔案\");

        List<DateTime> dayList = new List<DateTime>();
            TimeSpan timeSpan = EndTime.Subtract(StartTime);
            for (int i = 0; i <= timeSpan.Days; i++)
            {
                DateTime dateTime = StartTime.AddDays(i);
                dayList.Add(dateTime);
            }

            List<T> list = new List<T>();

            foreach (var dayTime in dayList)
            {
                list.AddRange(STReader<T>(Path.Combine(dirPath, dayTime.ToString("yyyy-MM-dd"), "記帳.csv")));
            }

            return list;
        }
        public List<T> ReadCSVModel<T>(String path) where T : new()
        {
            List<T> list = new List<T>();
            if (!path.Contains(".csv"))
            {
                path = Path.Combine(path, "記帳.csv");
            }
            if (!File.Exists(path))
            {
                return list;
            }

            list = STReader<T>(path);
            #region
            //StreamReader streamReader = new StreamReader(path);

            //while (!streamReader.EndOfStream)
            //{
            //    String[] datas = streamReader.ReadLine().Split(',');
            //    T t = new T();
            //    var porp = t.GetType().GetProperties();
            //    for (int i = 0; i < datas.Length; i++)
            //    {
            //        porp[i].SetValue(t, datas[i]);
            //    }
            //    list.Add(t);
            //}
            //streamReader.Close();
            #endregion
            return list;
        }

        private List<T> STReader<T>(string path) where T : new()
        {
            List<T> list = new List<T>();
            if (!File.Exists(path))
            {
                return list;
            }
            StreamReader streamReader = new StreamReader(path);

            while (!streamReader.EndOfStream)
            {
                String[] datas = streamReader.ReadLine().Split(',');
                T t = new T();
                var porp = t.GetType().GetProperties();
                for (int i = 0; i < datas.Length; i++)
                {
                    porp[i].SetValue(t, datas[i]);
                }
                list.Add(t);
            }
            streamReader.Close();
            return list;
        }

        public void WriteCSV(String path, object data)
        {
            if (path.Contains(".csv"))
            {
                var paths = path.Split('\\').ToList();
                paths.Remove(paths.Last());
                path = String.Join("\\", paths);
            }

            if (File.Exists(path))
            {
                throw new Exception("該路徑非csv檔案格式");
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            StreamWriter streamWriter = new StreamWriter(path + "記帳.csv", true);
            var props = data.GetType().GetProperties();
            String line = "";
            foreach (var prop in props)
            {
                line += $"{prop.GetValue(data)},";
            }

            line = line.TrimEnd(',');

            streamWriter.WriteLine(line);
            streamWriter.Flush();
            streamWriter.Close();

        }

        public void WriteCSV(String path, List<object> dataModels)
        {
            if (path.Contains(".csv"))
            {
                var paths = path.Split('\\').ToList();
                paths.Remove(paths.Last());
                path = String.Join("\\", paths);
            }

            if (File.Exists(path))
            {
                throw new Exception("該路徑非csv檔案格式");
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            StreamWriter streamWriter = new StreamWriter(path + "記帳.csv", true);
            var props = dataModels.GetType().GetProperties();
            String line = "";
            foreach (var prop in props)
            {
                line += $"{prop.GetValue(dataModels)},";
            }

            line = line.TrimEnd(',');

            streamWriter.WriteLine(line);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }

    //public List<DataModel> WriteCST(String path, List<DataModel> data)
    //{
    //    if (path.Contains(".csv"))
    //    {
    //        var paths = path.Split('\\').ToList();
    //        paths.Remove(paths.Last());
    //        path = String.Join("\\", paths);
    //    }

    //    if (File.Exists(path))
    //    {
    //        throw new Exception("該路徑非csv檔案格式");
    //    }

    //    if (!Directory.Exists(path))
    //    {
    //        Directory.CreateDirectory(path);
    //    }

    //    StreamWriter streamWriter = new StreamWriter(path + "記帳.csv", true);
    //    var props = data.GetType().GetProperties();
    //    String line = "";
    //    foreach (var prop in props)
    //    {
    //        line += $"{prop.GetValue(data)},";
    //    }
    //}

}

