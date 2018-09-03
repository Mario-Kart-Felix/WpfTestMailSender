using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender
{
   static public class AddAttach
    {
       static public void AddAttachment()
        { 
        // Configure open file dialog box
       OpenFileDialog dlg = new OpenFileDialog();
        dlg.Filter = "All Files *|*"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                MailSet.addAttachAdr = dlg.FileName;                
            }
    }
        
}
}
