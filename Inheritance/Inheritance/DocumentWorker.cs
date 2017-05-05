using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class DocumentWorker
    {
        virtual public void OpenDocument()
        {
            Console.WriteLine("The document is opened.");
        }
        virtual public void EditDocument()
        {
            Console.WriteLine("Editing of the document is available in the Pro version.");
        }
        virtual public void SaveDocument()
        {
            Console.WriteLine("Saving the document is available in the Pro version.");
        }
    }
}
