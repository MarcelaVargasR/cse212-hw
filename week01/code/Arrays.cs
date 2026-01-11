public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        // create an array with the specified size
        double[] result = new double[length];

        // use an for to iterate through the array
        for (int i = 0; i < length; i++)
        {
            // In each pocition store a multiple of the number
            result[i] = number * (i + 1);
        }

        // return the array 
        return result;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // determine how many elements will be moved from the end
        int count = data.Count;

        // get the last element for the list
        List<int> rightPart = data.GetRange(count - amount, amount);

        // get the remaining element at the beginning for the list
        List<int> leftPart = data.GetRange(0, count - amount);

        // rebuild in the new order
        data.Clear();

        // add the right part first
        data.AddRange(rightPart);

        // add the remaining element after
        data.AddRange(leftPart);

    }
}
