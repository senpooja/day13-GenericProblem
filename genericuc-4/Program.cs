class MaxNumCheck<T> where T : IComparable<T>
{
    public T[] value;

    public MaxNumCheck(T[] value)
    {
        this.value = value;
    }
    public T[] Sort(T[] value)
    {
        Array.Sort(value);
        return value;
    }
    public T MaxValue(T[] value)
    {
        var sorted_value = Sort(value);
        return sorted_value[sorted_value.Length - 1];

    }

    public void PrintMaxValue()
    {
        var max = MaxValue(this.value);
        Console.WriteLine(max);
    }
}

class program
{
    static void Main(string[] args)
    {
        int[] arr = { 23, 41, 32, 44, 66 };
        MaxNumCheck<int> generic = new MaxNumCheck<int>(arr);
        generic.PrintMaxValue();

        double[] double_arr = { 2.34, 3.54, 1.45, 3.567 };
        MaxNumCheck<double> genericd = new MaxNumCheck<double>(double_arr);
        genericd.PrintMaxValue();

        string[] string_arr = { "Cat", "Dog", "Rat", "Bat" };
        MaxNumCheck<string> generics = new MaxNumCheck<string>(string_arr);
        generics.PrintMaxValue();


    }
}