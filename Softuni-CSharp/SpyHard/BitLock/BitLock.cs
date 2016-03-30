using System;

class Bitlock
{
    static void Main()
    {
        int[] numbers = new int[8];
        string[] lineNumbers = Console.ReadLine().Split();
        for (int i = 0; i < lineNumbers.Length; i++)
        {
            numbers[i] = int.Parse(lineNumbers[i]);
        }
        string command = Console.ReadLine();
        do
        {
            if (command.Contains("check"))
            {
                int position = int.Parse(command.Substring(6));
                int countOnes = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    int bit = numbers[i] >> position & 1;
                    if (bit == 1)
                    {
                        countOnes++;
                    }
                }
                Console.WriteLine(countOnes);
            }
            else if (command.Contains("right") || command.Contains("left"))
            {
                string[] line = command.Split();
                int row = int.Parse(line[0]);
                int rotations = int.Parse(line[2]);
                if (command.Contains("right"))
                {
                    for (int i = 0; i < rotations; i++)
                    {
                        int bitToLose = numbers[row] & 1;
                        numbers[row] >>= 1;
                        numbers[row] |= bitToLose << 11;
                    }
                }
                else
                {
                    for (int i = 0; i < rotations; i++)
                    {
                        int bitToLose = numbers[row] & 1;
                        numbers[row] <<= 1;
                        numbers[row] |= bitToLose >> 11;
                    }
                }
            }

            command = Console.ReadLine();
        } while (command != "end");
        for (int i = 0; i < lineNumbers.Length; i++)
        {
            Console.Write(numbers[i]+" ");
        }
    }
}
