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
        // I will use a for loop to iterate through the length of the numbers the  user needs.
        // Every time the loop runs, I will multiply the number given starting with 1 and then
        // as the loop grows it will keep multiplying by the next numbers until the lenght is reached.    
        
        double[] numbers = new double[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = number * (i + 1);
        }
        return numbers;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // First, I will get a list of the numbers to be moved right.
        // Second, I will create a list in reversed order.
        // With that list I will get the numbers that will be moved at the beginning of the list.
        // Since they are reversed now, I will need to put them in the correct order again.
        // With that list finished, I will add at the end the list the numbers that I set apart in the first step.

        List<int> slice = data.GetRange(0, data.Count - amount); // Numbers to be moved right 
        // List in reversed order
        List<int> reversedlist = new List<int> { };
        for (int i = 0; i < data.Count; i++)
        {
            reversedlist.Insert(i, data[data.Count - 1 - i]);
        }
        // Numbers to be moved at the beginning
        List<int> newslice = reversedlist.GetRange(0, amount);
        // Correct order again
        List<int> finalList = new List<int> { };
        for (int i = 0; i < newslice.Count; i++)
        {
            finalList.Insert(i, newslice[newslice.Count - 1 - i]);
        }
        // Add at the end the list the first slice
        foreach (int ele in slice)
        {
            finalList.Add(ele);
        }
        return finalList;
    }
}
