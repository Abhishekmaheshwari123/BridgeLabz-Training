class SearchMatrix
{
    public static bool Run(int[,] mat, int target)
    {
        int r = mat.GetLength(0);
        int c = mat.GetLength(1);
        int l = 0, h = r * c - 1;
        while (l <= h)
        {
            int m = (l + h) / 2;
            int v = mat[m / c, m % c];
            if (v == target)
                return true;
            if (v < target)
                l = m + 1;
            else
                h = m - 1;
        }
        return false;
    }
}
