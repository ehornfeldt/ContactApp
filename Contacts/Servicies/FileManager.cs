using Contacts.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Contacts.Servicies
{
    public class FileManager
    {
        private string _directoryPath;
        private string _filePath;
        public FileManager(string directoryPath = "Data", string fileName = "list.json")
            {
                _directoryPath = directoryPath;
                _filePath = Path.Combine(_directoryPath, fileName);
            }
        public void SaveToFile(List<Contact> contacts) {
            try
            {
                if (!Directory.Exists(_directoryPath))
                {
                    Directory.CreateDirectory(_directoryPath);
                }

                string jsonString = JsonSerializer.Serialize(contacts);
                File.WriteAllText(_filePath, jsonString );
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
        public List<Contact> GetContacts()
        {
            try
            {
                if (Directory.Exists(_filePath))
                {
                    return [];
                }
                var json = File.ReadAllText(_filePath);
                var contacts = JsonSerializer.Deserialize<List<Contact>>(json);
                return contacts ?? [];
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return [];
            }

        }
    }
}
