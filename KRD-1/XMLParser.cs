using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace KRD_1
{
    public class XMLParser
    {
        List<Package> allPackages = new List<Package>();
        XmlDocument document = new XmlDocument();
        
        private String userAccountsFileName = "userAccounts.xml";
        private String listOfUsersFileName = "listOfUsers.xml";
        private String allPackagesFileName = "allPackages.xml";
        private String userAccountsPath = Environment.CurrentDirectory + "\\userAccounts.xml";
        public String UserAccountsFileName { get; set; }
        public String ListOfUsersFileName { get; set; }
        public String AllPackagesFileName { get; set; }
        public String UserAccountsPath { get; set; }

        public XMLParser(){}
        
        public void SerializeListOfUsers(List<User> listOfUsers)
        {
            var serializer = new XmlSerializer(listOfUsers.GetType());
            using (var writer = new StreamWriter(listOfUsersFileName))
            {
                serializer.Serialize(writer, listOfUsers);
            }
        }

        // do ogarnięcia
        public List<Package> LoadPackages()
        {
            var deserializer = new XmlSerializer(allPackages.GetType());
            try
            {
                using (var reader = new StreamReader(allPackagesFileName))
                {
                    allPackages = deserializer.Deserialize(reader) as List<Package>;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Plik nie mógł zostać odczytany:");
                Console.WriteLine(e.Message);
            }
            return allPackages;
        }

        public void ChangeStatusOfPackage(int index, String newStatus)
        { 
            document.Load(allPackagesFileName);
            XmlNodeList nodeList = document.GetElementsByTagName("Status");
            nodeList[index].InnerXml = newStatus;
            document.Save(allPackagesFileName);
        }

        public List<User> DeserializeListOfUsers(List<User> listOfUsers)
        {
            var deserializer = new XmlSerializer(listOfUsers.GetType());

            try {
                using (var reader = new StreamReader(listOfUsersFileName))
                {
                    listOfUsers = deserializer.Deserialize(reader) as List<User>;
                }
            }
            catch (Exception e) {
                Console.WriteLine("Plik nie mógł zostać odczytany:");
                Console.WriteLine(e.Message);
            }
            // poprawić na zwracanie i wtedy mozna sprawdzić 
            FormManageUsers.listOfUsers = listOfUsers;
            return listOfUsers;
        }

        // userAccounts.xml -> bin folder 
        public bool IsValidLogin(string username, string password)
        {
            bool isValid = false;
            Console.WriteLine("directory:" + Environment.CurrentDirectory + "\\userAccounts.xml");
            document.Load(userAccountsPath); 
            foreach (XmlNode node in document.SelectNodes("/accounts/user"))
            {
                String accountUsername = node.SelectSingleNode("username").InnerText;
                String accountPassword = node.SelectSingleNode("password").InnerText;

                if(username == accountUsername && password == accountPassword)
                {
                    isValid = true;
                    break;
                }
            }
            return isValid;
        }
    }
}
