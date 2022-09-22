//Un-comment below code and fix the issues
//Push to github'
int nxtnumb;
int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    nxtnumb = first + second;
    first = second;
    second = nxtnumb;

    if (count == 0)
    {
        return nxtnumb;
    }
    else
    {
        return RecursiveFibonacci(first, second, count);
    }
}

int lastFibo = RecursiveFibonacci(1, 1, 5);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine();



