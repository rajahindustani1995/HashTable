namespace HashTable
{
    class Program
    {
        public static void Main(String [] args)
        {

            string removeString = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            //removeStringArray will contain each word separately
            string[] removeStringArray = removeString.Split(' ');

            //creating object and passing removeStringArray's length/size to it
            MyMapNode<int, string> hash3 = new MyMapNode<int, string>(removeStringArray.Length);
            Console.WriteLine("Given phrase is : \n");

            //Adding each word to the hash table and printing it
            for (int i = 0; i < removeStringArray.Length; i++)
            {
                hash3.Add(i, removeStringArray[i]);
                Console.Write(hash3.Get(i) + " ");
            }

            //key for word avoidable is 17
            hash3.Remove(17);

            Console.WriteLine("\n\nAfter removing word \"avoidable\" from phrase, the phrase is : \n");

            //Printing all words in the hash table after we removed the word avoidable
            for (int i = 0; i < removeStringArray.Length; i++)
            {
                Console.Write(hash3.Get(i) + " ");
            }
            Console.WriteLine();
        }
    }
}