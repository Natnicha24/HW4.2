using System;

namespace ws_HW4._1
{
    class Program
    {
     static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

     static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
     static void Main(string[] args)
        {
            char continued;
            do {
                string halfDNASequence;
                halfDNASequence = Console.ReadLine();
                bool Sequence = IsValidSequence(halfDNASequence);
            if (Sequence == true)
            {
                    char answer;
                    Console.WriteLine("Current half DNA sequence:{0}", halfDNASequence);
                    do
                    {
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        answer = char.Parse(Console.ReadLine());
                        if (answer == 'Y')
                        {

                            string RSequence = ReplicateSeqeunce(halfDNASequence);

                            Console.WriteLine("Replicated half DNA sequence :{0} ", RSequence);
                        }
                        else if (answer == 'N') { }
                        else
                        {
                            Console.WriteLine("Please input Y or N");
                        }
                    } while (answer != 'Y' && answer != 'N');
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }
                do
                {
                    Console.Write("Do you want to process another sequence ? (Y/N) :");
                    continued = char.Parse(Console.ReadLine());
                    if (continued != 'Y' && continued != 'N')
                    {
                        Console.Write("Please input Y or N :");
                    }
                } while (continued != 'Y' && continued != 'N');
          }while(continued=='Y');
            Console.ReadLine();
       } 
  }
}
