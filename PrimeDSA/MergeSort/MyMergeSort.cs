namespace PrimeDSA.MergeSort;

public class MyMergeSort
{
    public int[] Sort(int[] numbers)
    {
        if (numbers.Length <= 1)
        {
            return numbers;
        }

        int mid = (int)Math.Floor((decimal)(numbers.Length / 2));
        var left = Sort(numbers[..mid]);
        var right = Sort(numbers[mid..]);

        return Merge(left, right);
    }

    private int[] Merge(int[] left, int[] right)
    {
        //* result is temp array contains all smaller numbers in left | right
        var result = Array.Empty<int>().ToList();
        int i = 0;
        int j = 0;

        do
        {
            if (left[i] < right[j])
            {
                result.Add(left[i]);
                i++;
            }
            else
            {
                result.Add(right[j]);
                j++;
            }
        } while (i < left.Length && j < right.Length);

        //* left | right length must 0
        //* left and right must be sorted
        result.AddRange(left[i..]);
        result.AddRange(right[j..]);

        return result.ToArray();
    }
}