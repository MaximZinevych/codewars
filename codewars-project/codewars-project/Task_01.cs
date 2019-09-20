using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars_project
{
    class Task_01
    {
        /*
        Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.
        If you want to know more http://en.wikipedia.org/wiki/DNA
        In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". You have function with one side of the DNA (string, except for Haskell); 
        you need to get the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

        More similar exercise are found here http://rosalind.info/problems/list-view/ (source)

        MakeComplement("ATTGC") => "TAACG"
        MakeComplement("GTAT") => "CATA"
        */
        static void Main(string[] args)
        {
            Console.WriteLine(MakeComplement("ATTGC"));
            Console.WriteLine(MakeComplement("GTAT"));

            Console.ReadKey();
        }

        public static string MakeComplement(string dna)
        {
            return dna.Replace('A', 't').Replace('C', 'g').Replace('T', 'a').Replace('G', 'c').ToUpper();
        }
    }
}
