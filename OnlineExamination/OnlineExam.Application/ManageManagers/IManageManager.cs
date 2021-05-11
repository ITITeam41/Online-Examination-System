using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamination.OnlineExam.Application.ManageManagers
{
    public interface IManageManager
    {
        public ManagerDTOList GetManagers();
        public ManagerDTO GetManager(string ManagerID);
        public void EditManager(ManagerDTO Manager);
        public void AddManager(ManagerDTO Manager);
        //public void DeleteManager(string ManagerId);
    }
}
