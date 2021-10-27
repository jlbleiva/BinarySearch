using System;
using System.Linq;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int firstpos = 0;
        int lastpos = input.Length - 1;
        bool found = false;
        int middle;
        
        while (firstpos <= lastpos && found == false)
        {

            int middleindex = (firstpos + lastpos) / 2;
            int middlevalue = input[middleindex];
            if (middlevalue == value) return middleindex;

            if (value < middlevalue)
            {
                lastpos = middleindex-1;
            }
            else
            {
                firstpos =middleindex+1;
            }
        }
        return -1;
    }
}