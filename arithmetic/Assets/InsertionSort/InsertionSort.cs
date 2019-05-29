using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSort : MonoBehaviour {


	void Start () 
    {
        int[] numArray = { 3, 2, 1, 5, 9, 8, 6, 7, 0, 4 };
        InsertionSortFunc(numArray);
    }

    void InsertionSortFunc(int[] numArray)
    {
        int arrayCount = numArray.Length;
        for (int i = 1; i < arrayCount; i++)
        {
            int curOprateNum = numArray[i];
            int j = i-1;
            //while (j>=0 && numArray[j] > curOprateNum) //递增
            while (j >= 0 && numArray[j] < curOprateNum) //递减
            {
                numArray[j + 1] = numArray[j];
                --j;
            }
            numArray[j + 1] = curOprateNum;
        }

        Util.PrintInfo(numArray);
    }
}
