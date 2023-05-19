using System;

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

    static string ReplicateSequence(string halfDNASequence)
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
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.Write("Enter a half DNA sequence: ");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);

                bool validReplicateOption = false;
                while (!validReplicateOption)
                {
                    Console.Write("Do you want to replicate it? (Y/N): ");
                    string replicateOption = Console.ReadLine();

                    switch (replicateOption.ToUpper())
                    {
                        case "Y":
                            string replicatedSequence = ReplicateSequence(halfDNASequence);
                            Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                            validReplicateOption = true;
                            break;
                        case "N":
                            validReplicateOption = true;
                            break;
                        default:
                            Console.WriteLine("Please input Y or N.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            bool validContinueOption = false;
            while (!validContinueOption)
            {
                Console.Write("Do you want to process another sequence? (Y/N): ");
                string continueOption = Console.ReadLine();

                switch (continueOption.ToUpper())
                {
                    case "Y":
                        validContinueOption = true;
                        break;
                    case "N":
                        continueProgram = false;
                        validContinueOption = true;
                        break;
                    default:
                        Console.WriteLine("Please input Y or N.");
                        break;
                }
            }
        }
    }
}