using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Servicies
{
    public class FileManager
    {
        private string _fileName;
        private string _fileDirectory;
        public FileManager(string fileName, string fileDirectory)
            {
                _fileName = fileName;
                _fileDirectory = fileDirectory;
            }
        }
    }
