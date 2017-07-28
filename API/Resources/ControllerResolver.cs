using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Web.Http.Dispatcher;

namespace API
{
    public class ControllerResolver : IAssembliesResolver 
    {
        public List<string> Controllers { get; set; }

        public ControllerResolver()
        {
            string ControllerPath = new System.Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            ControllerPath = ControllerPath.Substring(0, ControllerPath.LastIndexOf("\\")) + "\\Controllers";
            string[] ControllerPaths = Directory.GetFiles(ControllerPath, "*.DLL");
            Controllers = new List<string>(ControllerPaths);
        }

        public ICollection<Assembly> GetAssemblies()
        {
            List<Assembly> theseControllers = new List<Assembly>();
            foreach( var thisControllerPath in Controllers )
            {
                var thisController = System.Reflection.Assembly.LoadFrom(thisControllerPath);
                theseControllers.Add(thisController);               
            }
            return theseControllers;
        }

    }
}