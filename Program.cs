// See https://aka.ms/new-console-template for more information
/*Gagannath Dalavai
02-28-2024
This C# Console Application code demonstrates the
Selection Sort Algorithm
*/

int[] selection_sort_numbers = { 5, 72, 3, 14, 7, 1 };
Console.WriteLine("Here is the original array that will be used to execute the Selection Sort Algorithm: ");
for (int i = 0; i < selection_sort_numbers.Length; i++)
{
    Console.Write("  " + selection_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Here is the array after the execution of the Selection Sort Algorithm: ");
Selection_Sort(selection_sort_numbers);
Console.WriteLine("");
static void Selection_Sort(int[] ss_arr)
   {
            // min_position is used to keep track of the element position with the current lowest value  
            int min_position;
            
            int temp;// temp is used to conduct the swap during during the Selection Sort Algorithm

    for (int i = 0; i < ss_arr.Length; i++)
            {
                
                min_position = i;
        // From the min_position, check to see if the next element is smaller
        for (int x = i + 1; x < ss_arr.Length; x++)
                {
                    
                    if (ss_arr[x] < ss_arr[min_position])
                    {
                        
                        min_position = x;//min_position will keep track of the index that min is in, this is needed when a swap happens
            }
                }

        // If the min_position does not equal the current element being evaluated in the loop
        // Then execute the swap. by switching the postion of the lowest with the current element
        if (min_position != i)
                {
                    temp = ss_arr[i];
                    ss_arr[i] = ss_arr[min_position];
                    ss_arr[min_position] = temp;
                }
                Console.Write("  " + ss_arr[i]);
            }

}// End of Selection_Sort
