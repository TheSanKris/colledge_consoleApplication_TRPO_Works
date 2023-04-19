using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    class Person : IComparable
    {
        public string Name;
        public int AssessmentMath;
        public int AssessmentRussian;
        public int AssessmentPhysic;
        public int AverageAssessment;

        public int flag = 0;

        public Person(string name, int assessmentMath, int assessmentRussian, int assessmentPhysic, int averageAssessment)
        {
            Name = name;
            AssessmentMath = assessmentMath;
            AssessmentRussian = assessmentRussian;
            AssessmentPhysic = assessmentPhysic;
            AverageAssessment = averageAssessment;
        }
        public int CompareTo(object o)
        {
            if (o is Person person)
            {
                if (person.flag != 0) 
                    return AverageAssessment.CompareTo(person.AverageAssessment);
                else
                    return Name.CompareTo(person.Name);
            }
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }

    internal class Work6
    {
        public void Function1()
        {
            Console.WriteLine("Сколько будет студентов");
            int m_cntStudent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите данные {m_cntStudent} стедентов");
            Console.WriteLine("Формат данных: ФИО(слитно и новое слово - врехний регистр) Математика Русский Физика");
            
            
            string[] tmp;
            Person[] m_arrListPerson = new Person[m_cntStudent];
            for (int i = 0; i < m_cntStudent; i++)
            {
                tmp = Console.ReadLine().Split(' ');
                string Name = tmp[0];
                int AssessmentMath = Convert.ToInt32(tmp[1]);
                int AssessmentRussian = Convert.ToInt32(tmp[2]);
                int AssessmentPhysic = Convert.ToInt32(tmp[3]);
                int AvarageAssessment = (AssessmentMath + AssessmentRussian + AssessmentPhysic) / 3;
                Person person = new Person(Name, AssessmentMath, AssessmentRussian, AssessmentPhysic, AvarageAssessment);
                m_arrListPerson[i] = person;
            }

            Array.Sort(m_arrListPerson);

            //Проверка совпадения среднего балла
            int flag = 0;
            
            for(int i = 0; i < m_cntStudent; i++)
            {
                for (int j = 0; j < m_cntStudent; j++)
                {
                    if (m_arrListPerson[i].AverageAssessment == m_arrListPerson[j].AverageAssessment)
                        flag++;
                }

                if (flag != 0)
                {
                    Array.Sort(m_arrListPerson);
                    break;
                }
                m_arrListPerson[i].flag = flag;
            }
            
            Array.Sort(m_arrListPerson);
            
            foreach(Person person in m_arrListPerson)
                Console.WriteLine(person.Name + " " + person.AssessmentMath + " "
                                    + person.AssessmentRussian + " " 
                                    + person.AssessmentPhysic + " "
                                    + person.AverageAssessment);

        }
       
    }
}
