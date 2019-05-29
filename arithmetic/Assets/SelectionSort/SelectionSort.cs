using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSort : MonoBehaviour {


    void Start()
    {
        int[] numArray = { 3, 2, 1, 5, 9, 8, 6, 7, 0, 4 };
        SelectionSortFunc(numArray);
    }

    void SelectionSortFunc(int[] numArray)
    {
        int arrayCount = numArray.Length;
        int minIndex = 0;
        int temp = 0;

        for (int i = 0; i < arrayCount - 1; ++i)
        {
            minIndex = i;
            for (int j = i + 1; j < arrayCount; ++j)
            {
                if (numArray[j] < numArray[minIndex]) //递增
                //if (numArray[j] > numArray[minIndex]) //递减
                {
                    minIndex = j;
                }
            }

            temp = numArray[i];
            numArray[i] = numArray[minIndex];
            numArray[minIndex] = temp;
        }

        Util.PrintInfo(numArray);
    }
}
