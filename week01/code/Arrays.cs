public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Writing a function that returns an array of multiples of a given number
        // Step 1:  I will create an array of doubles with the specified length
        // Step 2:  I will use a for loop to iterate from 0 to length - 1
        // Step 3:  Inside the loop, I will calculate the multiple by multiplying the number by (i + 1)
        // Step 4:  I will assign the calculated multiple to the array at index i
        // Step 5:  After the loop, I will return multiples of that number in an array
 
        //here is the code 
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            double multiple = number * (i + 1);
            multiples[i] = multiple;
        }
        return multiples;



         // replace this return statement with your own
        
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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //steps to rotate a list to the right by a given amount
        // using the above example of List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount of 3
        // Step 1:  I will identify the last 'amount' elements of the list
        // Step 2:  I will store these elements in a temporary list
        // Step 3:  I will remove these elements from the end of the original list
        // Step 4:  I will insert the elements from the temporary list at the beginning of the original list
        // Step 5:  The original list is now rotated to the right by the specified amount

        //here is the code
        List<int> temp = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, temp);
    }
}
