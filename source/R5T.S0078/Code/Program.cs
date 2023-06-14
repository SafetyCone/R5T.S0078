using System;
using System.Threading.Tasks;


namespace R5T.S0078
{
    class Program
    {
        static async Task Main()
        {
            await WorkspaceScripts.Instance.OpenProject();
        }
    }
}