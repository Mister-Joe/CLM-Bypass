using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Stager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitialSessionState iss = InitialSessionState.CreateDefault();
            Runspace rs = RunspaceFactory.CreateRunspace(iss);
            rs.Open();
            PowerShell ps = PowerShell.Create();
            ps.Runspace = rs;
            string cmd = "command here";
            ps.AddScript(cmd);
            ps.Invoke();
            rs.Close();
        }
    }
}
