using System;
using System.Collections;

namespace NameListWindowsFormsApp
{
    public interface INameList
    {
        bool Add(string name);
        string GetNames();
        bool Erasing();
    }

    public class NameList : INameList
    {
        private ArrayList _nameList;

        public NameList()
        {
            this._nameList = new ArrayList();
        }

        public bool Add(string name)
        {
            if (!this._nameList.Contains(name))
            {
                this._nameList.Add(name);
                return true;
            }
            return false;
        }

        public bool Erasing()
        {
            if(this._nameList.Count > 0)
            {
                _nameList.Clear();
                return true;
            }
            return false;
        }

        public string GetNames()
        {
            string names = null;
            foreach (string item in this._nameList)
            {
                names += string.Format("{0}{1}",item, Environment.NewLine);
            }
            return names;
        }
    }
}
