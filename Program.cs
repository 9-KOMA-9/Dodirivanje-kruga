using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public class Tocka
        {
            private double m_x;
            public double x
            {
                get { return m_x; }
                set { m_x = value; }
            }
            private double m_y;
            public double y
            {
                get { return m_y; }
                set { m_y = value; }
            }

            public Tocka(double x, double y)
            {
                m_x = x;
                m_y = y;
            }
            public Tocka()
            {
                m_x = 0;
                m_y = 0;
            }
            public void ispis()
            {
                Console.WriteLine("({0}, {1})", m_x, m_y);
            }
            public double udaljenost(Tocka T)
            {
                double rez = 0;
                rez = ((m_x - T.m_x) * (m_x - T.m_x) + (m_y - T.m_y) * (m_y - T.m_y));
                return Math.Sqrt(rez);
            }


        }
        public class Krug
        {
            private Tocka m_srediste;

            private double m_redijus;
            public double redijus
            {
                get { return m_redijus;}
                set { m_redijus = value;}
            }
            public Krug(double x, double y, double r)
            {
                m_redijus = r;
                m_srediste = new Tocka(x,y);
            }
            public bool dodir(Krug K)
            {
                double rezultat = 0;
                rezultat = m_srediste.udaljenost(K.m_srediste);
                if(rezultat <= (m_redijus + K.m_redijus))
                {
                    return true; 
                }
                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            Tocka T1 = new Tocka();
            Tocka T2 = new Tocka(1,1);
            Krug K1 = new Krug(1, 1, 2);
            Krug K2 = new Krug(5, 5, 2);
            
            T1.ispis();
            double u = T1.udaljenost(T2);
            bool d = K1.dodir(K2);


            
            Console.WriteLine(d);  
            Console.ReadLine();
         
        }
    }
}
