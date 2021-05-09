using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExamination.Application.ManageManagers
{
    public class ManagerDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class ManagerDTOList
    {
        public List<ManagerDTO> Managers { get; set; }
        public int ManagersCount { get; set; }
    }
}
