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
        XmlSerializer xsSubmit = new XmlSerializer(typeof(User));
        
        public XMLParser(){}

        public Boolean LoadUsers()
        {
            return true;
        }
        
        public void XmlSerializer(List<User> listOfUsers)
        {
            var serializer = new XmlSerializer(listOfUsers.GetType());
            using (var writer = new StreamWriter("listOfUsers.xml"))
            {
                serializer.Serialize(writer, listOfUsers);
            }
        }

        public void XmlDeserializer(List<User> listOfUsers)
        {
            var deserializer = new XmlSerializer(listOfUsers.GetType());

            try {
                using (var reader = new StreamReader("listOfUsers.xml"))
                {
                    listOfUsers = deserializer.Deserialize(reader) as List<User>;
                }
            }
            catch (Exception e) {
                Console.WriteLine("Plik nie mógł zostać odczytany:");
                Console.WriteLine(e.Message);
            }
            FormManager.listOfUsers = listOfUsers;
        }

        // userAccounts.xml -> bin folder 
        public static bool IsValidLogin(string username, string password)
        {
            bool isValid = false;
            XmlDocument document = new XmlDocument();
            Console.WriteLine("directory:" + Environment.CurrentDirectory + "\\userAccounts.xml");
            document.Load(Environment.CurrentDirectory + "\\userAccounts.xml"); 
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
