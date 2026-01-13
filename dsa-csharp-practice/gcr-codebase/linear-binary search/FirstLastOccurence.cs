class FirstLastOccurrence
{
    public static int[] Run(int[] arr, int t)
    {
        return new int[] { Bound(arr, t, true), Bound(arr, t, false) };
    }

    static int Bound(int[] arr, int t, bool first)
    {
        int l = 0, r = arr.Length - 1, res = -1;
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (arr[m] == t)
            {
                res = m;
                if (first)
                    r = m - 1;
                else
                    l = m + 1;
            }
            else if (arr[m] < t)
                l = m + 1;
            else
                r = m - 1;
        }
        return res;
    }
}
