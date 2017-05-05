using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("The document has been edited.");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document has been saved in an old format, saving in other formats is available in the Expert version.");
        }
    }
}
