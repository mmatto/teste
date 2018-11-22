using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            int na, nb, nc;
            double[] VetA;
            HashSet<int> alunosA = new HashSet<int>();
            Console.Write("O curso A possui quantos alunos? ");
            na = int.Parse(Console.ReadLine());
            VetA = new double[na];
            for (int i =0; i < na; i++)
            {
                //VetA[i] = int.Parse(Console.ReadLine());
                alunosA.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int xa in alunosA)
            {
                Console.WriteLine(xa);
                Console.WriteLine();
            }
                double[] VetB;
            HashSet<int> alunosB = new HashSet<int>();
            Console.Write("O curso B possui " +
                "quantos alunos? ");
            nb = int.Parse(Console.ReadLine());
            VetB = new double[nb];
            for (int i = 0; i < nb; i++)
            {
                //VetB[i] = int.Parse(Console.ReadLine());
                alunosB.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int xb in alunosB)
            {
                Console.WriteLine(xb);
                Console.WriteLine();
            }


            double[] VetC;
            HashSet<int> alunosC = new HashSet<int>();
            Console.Write("O curso C possui quantos alunos? ");
            nc = int.Parse(Console.ReadLine());
            VetC = new double[nc];
            for (int i = 0; i < nc; i++)
            {
                // VetC[i] = int.Parse(Console.ReadLine());
                alunosC.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int xc in alunosC)
            {
                Console.WriteLine(xc);
                Console.WriteLine();
            }

            int AlunosTotal;

            AlunosTotal = alunosA.Count + alunosB.Count + alunosC.Count;

            Console.WriteLine("Total de alunos:" + AlunosTotal );
            Console.ReadLine();






        }
    }
}
