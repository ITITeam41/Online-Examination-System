using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamination.OnlineExam.Application.ManageManagers
{
    public class ManagerDTO
    {
        public string Id { get; set; }
        public string NAMe { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
    }

    public class ManagerDTOList
    {
        public List<ManagerDTO> Managers { get; set; }
        public int ManagersCount { get; set; }
    }
}
