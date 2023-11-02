using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using lab7;

namespace ClassDiagGen
{
    internal class Diag7
    {
        static void Main(string[] args)
        {
            
            Assembly assembly = Assembly.LoadFrom("D:\\consol\\lab7\\lab7\\bin\\Debug\\lab7.exe");
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement rootElement = xmlDoc.CreateElement("ClassDiagram");
            xmlDoc.AppendChild(rootElement);
            Type[] types = { typeof(CommentAttribute), typeof(Animal), typeof(Cow), typeof(Lion), typeof(Pig)};
            foreach (Type type in types)
            {
                XmlElement classElement = xmlDoc.CreateElement("Class");
                classElement.SetAttribute("Name", type.Name);
                lab7.CommentAttribute commentAttribute = (lab7.CommentAttribute)Attribute.GetCustomAttribute(type, typeof(lab7.CommentAttribute));
                if (commentAttribute != null)
                {
                    Console.WriteLine(commentAttribute.Comment);
                    XmlElement commentElement = xmlDoc.CreateElement("Comment");
                    commentElement.InnerText = commentAttribute.Comment;
                    classElement.AppendChild(commentElement);
                }
                rootElement.AppendChild(classElement);
            }
            xmlDoc.Save("D:\\consol\\lab7\\XMLFile1.xml");
            Console.WriteLine("Диаграмма классов сгенерирована и сохранена в ClassDiagram.xml");
            Console.ReadLine();
        }
    }
}
