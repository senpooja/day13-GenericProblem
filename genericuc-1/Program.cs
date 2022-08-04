class MaxNumCheck
{
    public static int MaxIntNumber(int first_value, int second_value, int third_value)
    {

        if (first_value.CompareTo(second_value) > 0 && first_value.CompareTo(third_value) > 0)

        {
            return first_value;
        }
        if (second_value.CompareTo(first_value) > 0 && second_value.CompareTo(third_value) > 0)

        {
            return second_value;
        }
        if (third_value.CompareTo(second_value) > 0 && third_value.CompareTo(first_value) > 0)

        {
            return third_value;
        }
        throw new Exception("first_value,second_value,Third_value are same");

    }
}

class program
{
    static void Main(string[] args)
    {

        int output = MaxNumCheck.MaxIntNumber(11, 10, 39);
        Console.WriteLine(output);

    }
}