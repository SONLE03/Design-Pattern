using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _folder; // Thực thể thực sự sẽ được truy cập
        private Employee _employee;

        public SharedFolderProxy(Employee employee)
        {
            _employee = employee;
        }

        public void PerformRWOperations()
        {
            if (CheckAccess())
            {
                if (_folder == null)
                    _folder = new SharedFolder();

                _folder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
        private bool CheckAccess()
        {
            return _employee.Role.ToUpper() == "CEO" || _employee.Role.ToUpper() == "MANAGER";
        }
    }
}
