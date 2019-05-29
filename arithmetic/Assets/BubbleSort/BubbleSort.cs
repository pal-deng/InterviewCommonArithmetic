using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class BubbleSort : MonoBehaviour {


    void Start()
    {
        int[] numArray = { 3, 2, 1, 5, 9, 8, 6, 7, 0, 4 };
        //BubbleSortFunc(numArray);
        BetterBubbleSortFunc(numArray);
    }


    void BubbleSortFunc(int[] numArray)
    {
        int arrayCount = numArray.Length;
        for (int i = arrayCount - 1; i > 0; --i)
        {
            for (int j = 0; j < i; ++j)
            {
                //if (numArray[j] > numArray[j+1]) // 递增
                if (numArray[j] < numArray[j + 1]) // 递减
                {
                    int temp = numArray[j];
                    numArray[j] = numArray[j+1];
                    numArray[j+1] = temp;
                }
            }
        }

        Util.PrintInfo(numArray);
    }

    void BetterBubbleSortFunc(int[] numArray)
    {
        int arrayCount = numArray.Length;
        int i = arrayCount - 1;
        while (i > 0)
        {
            int pos = 0;
            for (int j = 0; j < i; ++j)
            {
                //if (numArray[j] > numArray[j+1]) // 递增
                if (numArray[j] < numArray[j + 1]) // 递减
                {
                    pos = j;
                    int temp = numArray[j];
                    numArray[j] = numArray[j + 1];
                    numArray[j + 1] = temp;
                }
            }
            i = pos;
        }

        Util.PrintInfo(numArray);
    }

}
