namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student=new Student[6];
            student[0] = new Student(1,"Murad",97);
            student[1] = new Student(2,"Niyazi",97);
            student[2] = new Student(3,"Mirallam",60);
            student[3] = new Student(4,"Peri",50);
            student[4] = new Student(5,"Beyim",48);
            student[5] = new Student(6,"Nuraib",95);

            

            foreach(Student i in student) 
            {
                Console.WriteLine("Total Student Count: "+i.Count);
                Console.WriteLine("Student's Name: "+i.Name);
                Console.WriteLine("Student's Grade: " + i.Grade);



                if (i.Grade >=50)
                {
                    Console.WriteLine("ortalama");
                }
                if (i.Grade>90)
                {
                    Console.WriteLine("yuksek");
                }
                if (i.Grade <50)
                {
                    Console.WriteLine("kesildiniz");
                }






            }

           

        }
    }
}