using System;

namespace VectorSoftwareTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "WEAREDISCOVEREDFLEEATONCE";
            int key= 3;
            Encrypt(input, key);
        }
        private static string Encrypt (string input, int key)
        {
            string output = "";
            int size = input.Length;
            char[,] array = new char [key,size];

            for (int r = 0, c = 0, d = 1; c < size; r += d, ++c)
            {
                array[r,c] = input[c];
                if (r == key - 1)
                    d = -1;
                else if (r == 0)
                    d = 1;
            }
            for (int r = 0; r < key; ++r)
            {
                for (int c = 0; c < size; ++c)
                {
                    if (array[r, c] != 0)
                        output += array[r, c];
                }
            }
            Console.WriteLine(output);
            return output;
        }


        private static string Decrypt (string input, int key)
        {
            string output = "";
            int size = input.Length;
            char[,] array = new char[key, size];
            for (int r = 0, c = 0, d = 1; c < size; r += d, ++c)
            {
                array[r, c] = '*';
                if (r == key - 1)
                    d = -1;
                else if (r == 0)
                    d = 1;
            }

            int count = 0;
            for(int r = 0; r < key; ++r)
            {
                for(int c = 0; c < size; ++ c)
                {
                    if (array[r, c] == '*')
                        array[r, c] = input[count++];
                }
            }
            for(int r = 0, c = 0, d = 1;c < size; r += d, ++c)
            {
                output += array[r, c];
                if (r == key - 1)
                    d = -1;
                else if (r == 0)
                    d = 1;
            }
            Console.WriteLine(output);
            return output;
        }

    }
}


         
        




