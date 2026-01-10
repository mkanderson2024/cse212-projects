public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    /// 

    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start

        // Solution:
        // 1. create an array using the number and length variables given from the inputs for this function
        // 2. create loop to add numbers to the array for the duration of length
        // 3. return the array

        // === Notes from student: First, create an array using the number and length variables given from the inputs for this function ===

        double[] multiples = new double[length];

        // === Note from student: create loop to add numbers to the array for the duration of length

        for (int i = 0; i < length; i++)
        {
            // Within the loop, use multiplaction to create the multiples of the given number to the length of value of length
            multiples[i] = number * (i + 1)
            ;
        }


        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start

        // Solution:
        // 1. find the amount of elements in the list and store them as an integer variable
        // 2. create a loop to loop trough the list for the duration of amount
        // 3. store the last element temporarily
        // 4. remove the last element from the list
        // 5. insert the stored element at the beginning

        // Notes from student: find the amount of elements in the list and store them as an integer variable
        int n = data.Count;

        // Notes from student: create a loop to loop through the list for the duragtion of amount
        for (int i = 0; i < amount; i++)
        {
            // Notes from student: store the last element temporaraliy
            int last = data[n - 1];

            // Notes from student: remove the last element from the list
            data.RemoveAt(n - 1);

            // insert the stored element at the beginning
            data.Insert(0, last);
        }


        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
