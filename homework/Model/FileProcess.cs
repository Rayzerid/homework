using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using homework.Structs;
using homework.ViewModel;

namespace homework.Model
{
    public class FileProcess
    {
        GlobalViewModel _globalViewModel;
        public FileProcess(GlobalViewModel globalViewModel)
        {
            _globalViewModel = globalViewModel;
        }

        public void SaveToFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, _globalViewModel.StudentInfos);
            fs.Close();
        }

        public ObservableCollection<StudentInfo> ReadFromFile(string path)
        {
            ObservableCollection<StudentInfo> tovarList;
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            object result = formatter.Deserialize(fs);
            tovarList = (ObservableCollection<StudentInfo>)result;
            fs.Close();
            return tovarList;
        }
        public ObservableCollection<StudentInfo> ResultStudent(ObservableCollection<StudentInfo> studentInfos)
        {
            DateTime dateTime = DateTime.Now;
            var Infos = _globalViewModel.StudentInfos.Where(x => x.Birthday.Month == dateTime.Month);
            return studentInfos = new ObservableCollection<StudentInfo>(Infos);
        }
    }
}
