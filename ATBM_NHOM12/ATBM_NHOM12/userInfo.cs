using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_NHOM12
{
    public class RoleEventArgs : EventArgs
    {
        public string Role { get; }
        public string username { get; }

        public RoleEventArgs(string role, string username)
        {
            this.Role = role;
            this.username = username;
        }
    }
}
