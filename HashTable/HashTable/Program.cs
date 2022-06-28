namespace HashTable
{
    class Program
    {
        public static void Main(String [] args)
        {
           
            string frequency = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            //declaring List to compare hash table items with
            List<string> compareList = new List<string>();

            //declaring List to store word and frequency
            List<string> storeCountList = new List<string>();

            //spliting the string and converting it to an array 
            string[] frequencyArray = frequency.Split(' ');

            //decclaring hash table of the length of frequencyArray
            MyMapNode<int, string> hash1 = new MyMapNode<int, string>(frequencyArray.Length);
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                //Adding each word to hash table
                hash1.Add(i, frequencyArray[i]);

                //Displaying each word stored in the hash table
                Console.Write(hash1.Get(i) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                //declaring count to count number of occurances of the words
                int count = 0;
                for (int j = 0; j < frequencyArray.Length; j++)
                {
                    //if our phrase array contains same word
                    if (frequencyArray[j].ToLower() == hash1.Get(i).ToLower())
                    {
                        //then we will increase the count
                        count++;

                        
                        if (compareList.Contains(hash1.Get(j).ToLower()))
                        {
                            //if value is already available in our compareList2 list then we'll break internal loop
                            break;
                        }
                    }
                }
                
                if (compareList.Contains(hash1.Get(i).ToLower()))
                {
                    continue;
                }
                //Adding the word to compareList for further comparison for duplicates
                compareList.Add(hash1.Get(i));

                //finally storing the word and its frequency in storeCountList list
                storeCountList.Add(hash1.Get(i) + "\t" + count);
            }

            
            Console.WriteLine("Words and their frequencies shown below");
            for (int i = 0; i < storeCountList.Count; i++)
            {
                Console.WriteLine(storeCountList[i]);
            }
        }
    }
}