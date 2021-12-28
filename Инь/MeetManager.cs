using System;
using System.Collections.Generic;
using System.Text;
using Инь.Models;

namespace Инь
{
    public class MeetManager
    {
        private List<Meet> meets = new List<Meet>();

        public List<Meet> GetAll()
        {
            return meets;
        }
        public void AddNewMeet(string name, DateTime meetTime)
        {
            Meet newMeet = new Meet() { Name = name, CreateTime = DateTime.Now };
            meets.Add(newMeet);
        }
    }
}
