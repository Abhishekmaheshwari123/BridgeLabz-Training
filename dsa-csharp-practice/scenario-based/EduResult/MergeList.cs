static List<Student> Merge(List<Student> left, List<Student> right)
{
    List<Student> result = new List<Student>();
    int i = 0, j = 0;

    while (i < left.Count && j < right.Count)
    {
        if (left[i].Marks >= right[j].Marks) // descending rank
            result.Add(left[i++]);
        else
            result.Add(right[j++]);
    }

    while (i < left.Count) result.Add(left[i++]);
    while (j < right.Count) result.Add(right[j++]);

    return result;
}
