namespace prove_01;

public class Lists
{
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start (don't forget to fill out the 01-prove-response.docx)
        // replace this return statement with your own
        //The Lenght of the list need to be larger than 0, ADD IF STATEMENT TO MAKE SURE EVERYTHINGG IS GOOD.
        if (length <= 0)
        {
            throw new ArgumentException("Error in length, please try again!");
        }

        double[] result = new double[];

        for (int i = 0; i <= length; i++)
        {
            result[i] = number * (i * 1);
        }

        return result;
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start (don't forget to fill out the 01-prove-response.docx)
        // Make sure the values are greater than 0 or we could have an error
        if (data == null || data.Count == 0 || amount <= 0)
        {
            return data;
        }
        
        int lenght = data.Count;
        int rotatios = amount % lenght;
        
        if (rotations == 0)
        {
            return data; 
        }

        for (int r = 0; r < rotations; r++)
        {
            int temp = data[lenght - 1];
            for (int i = (lenght-2); i>=0; i--)
            {
                data[i+1] = data[1]
            }
            data[0] = temp;
        }
    }
    return data;
