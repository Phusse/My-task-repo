using System;
 
class program {

    static bool areConsecutive(int []arr, int n)
    {
        if (n < 1)
            return false;
 
        int min = getMin(arr, n);
 
        int max = getMax(arr, n);
 
        if (max - min + 1 == n)
        
        {
             
            bool []visited = new bool[n];
            int i;
             
            for (i = 0; i < n; i++)
            {
             
                if (visited[arr[i] - min] != false)
                    return false;
 
                visited[arr[i] - min] = true;
            }
       
            return true;
        }
        return false; 

    }

    static int getMin(int []arr, int n)
    {
        int min = arr[0];
         
        for (int i = 1; i < n; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
         
        return min;
    }
 
    static int getMax(int []arr, int n)
    {
        int max = arr[0];
         
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
         
        return max;
    }

    public static void Main()
    {
        int []arr = {4, 4, 2, 3, 1, 6};
        int n = arr.Length;
         
        if (areConsecutive(arr, n) == true)
            Console.Write("Elements are"
                              + " consecutive");
        else
            Console.Write("Elements are"
                         + " not consecutive");
    }
}