using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderBot_One.Components
{
    internal class Gntr
    {
        string ABUSE_OBJECT;
        string ABUSE_OBJECT_MOM;
        List<string> l;
        List<string> hlqk_l;
        Random rd;

        public Gntr()
        {
            ABUSE_OBJECT = Environment.UserName;
            ABUSE_OBJECT_MOM = $"{Environment.UserName}的妈";
            rd = new Random();

        }
        public async Task i()
        {
            var stream = await FileSystem.OpenAppPackageFileAsync("SwearList.txt");
            var reader = new StreamReader(stream);
            var contents = reader.ReadToEnd();
            l = contents.Split(new[] { "\ue2cd\uf854" }, StringSplitOptions.None).ToList();
            stream = await FileSystem.OpenAppPackageFileAsync("FoulestSwearList.txt");
            reader = new StreamReader(stream);
            contents = reader.ReadToEnd();
            hlqk_l = contents.Split(new[] { "\ue2cd\uf854" }, StringSplitOptions.None).ToList();
        }
        public string g(int amount = 1, bool hlqk = false, string name = "")
        {
            string t = "";
            for (int i = 0; i < amount; i++)
            {
                t += hlqk ? A.a(hlqk_l[rd.Next(hlqk_l.Count)].Trim()) : A.a(l[rd.Next(l.Count)].Trim());
                t += "\n";
            }
            if (!string.IsNullOrEmpty(name))
            {
                /*t = t.Replace("你妈", "你"+ABUSE_OBJECT_MOM);
                t = t.Replace("你🐴", "你"+ABUSE_OBJECT_MOM);
                t = t.Replace("你🐎", "你"+ABUSE_OBJECT_MOM);
                t = t.Replace("妈", ABUSE_OBJECT_MOM);
                t = t.Replace("🐴", ABUSE_OBJECT_MOM);
                t = t.Replace("🐎", ABUSE_OBJECT_MOM);
                t = t.Replace("母亲", ABUSE_OBJECT_MOM);
                t = t.Replace("马", ABUSE_OBJECT_MOM);*/
                t = t.Replace("你", name);
            }

            return t;
        }



    }
}
