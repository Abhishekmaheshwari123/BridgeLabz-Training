static List<Student> MergeSort(List<Student> students)
{
    if (students.Count <= 1)
        return students;

    int mid = students.Count / 2;

    List<Student> left = MergeSort(students.GetRange(0, mid));
    List<Student> right = MergeSort(students.GetRange(mid, students.Count - mid));

    return Merge(left, right);
}
