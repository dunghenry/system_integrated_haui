using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Bai07_Part2
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;

        public DataUtil()
        {
            filename = "Course.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement course = doc.CreateElement("course");
                doc.AppendChild(course);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public bool updateStudent(Student s)
        {
            XmlNode stdfind = root.SelectSingleNode("student[@id='" + s.id + "']");
            if(stdfind != null)
            {
                XmlElement st = doc.CreateElement("student");
                st.SetAttribute("id", s.id);
                XmlElement name = doc.CreateElement("name");
                name.InnerText = s.name;
                XmlElement age = doc.CreateElement("age");
                age.InnerText = s.age;
                XmlElement city = doc.CreateElement("city");
                city.InnerText = s.city;
                st.AppendChild(name);
                st.AppendChild(age);
                st.AppendChild(city);
                root.ReplaceChild(st, stdfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }
        public bool deleteStudent(string id)
        {
            XmlNode stdfind = root.SelectSingleNode("student[@id='" + id + "']");
            if (stdfind != null)
            {
                root.RemoveChild(stdfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }
        public void addStudent(Student s)
        {
            XmlElement st = doc.CreateElement("student");
            st.SetAttribute("id", s.id);
            XmlElement name = doc.CreateElement("name");
            name.InnerText = s.name;
            XmlElement age = doc.CreateElement("age");
            age.InnerText = s.age;
            XmlElement city = doc.CreateElement("city");
            city.InnerText = s.city;
            st.AppendChild(name);
            st.AppendChild(age);
            st.AppendChild(city);
            root.AppendChild(st);
            doc.Save(filename);
        }
        public List<Student> getAllStudents()
        {
            XmlNodeList nodes = root.SelectNodes("student");
            List<Student> li = new List<Student>();
            foreach(XmlNode item in nodes)
            {
                Student s = new Student();
                s.id = item.Attributes[0].InnerText;
                s.name = item.SelectSingleNode("name").InnerText;
                s.city = item.SelectSingleNode("city").InnerText;
                s.age = item.SelectSingleNode("age").InnerText;
                li.Add(s);
            }
            return li;
        }

        public Student findById(string id)
        {
            XmlNode stdfind = root.SelectSingleNode("student[@id='" + id + "']");
            Student s = null ;
            if(stdfind != null)
            {
                s = new Student();
                s.id = stdfind.Attributes[0].InnerText;
                s.name = stdfind.SelectSingleNode("name").InnerText;
                s.city = stdfind.SelectSingleNode("city").InnerText;
                s.age = stdfind.SelectSingleNode("age").InnerText;
            }
            return s;
        }

        public List<Student> findByCity(string city)
        {
            XmlNodeList students = root.SelectNodes("student[city='" + city + "']");

            List<Student> li = new List<Student>();
            foreach (XmlNode item in students)
            {
                Student s = new Student();
                s.id = item.Attributes[0].InnerText;
                s.name = item.SelectSingleNode("name").InnerText;
                s.city = item.SelectSingleNode("city").InnerText;
                s.age = item.SelectSingleNode("age").InnerText;
                li.Add(s);
            }
            return li;
        }
    }
}
