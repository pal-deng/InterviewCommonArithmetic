using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : MonoBehaviour {

    void Start()
    {
        int[] numArray = { 3, 2, 1, 5, 9, 8, 6, 7, 0, 4 };

        QuickSortFunc(numArray, 0, numArray.Length-1);
        Util.PrintInfo(numArray);
    }


    private void QuickSortFunc(int[] numArray, int left, int right)
    {
        int i = left;
        int j = right;
        int temp = numArray[left];

        while (i < j)
        {
            // 从右向左选出第一个比temp小的数，放在左边
            while (i < j && numArray[j] >= temp)
            {
                --j;
            }
            numArray[i] = numArray[j];

            // 从左向右选出第一个比temp大的数，放在右边
            while (i < j && numArray[i] <= temp)
            {
                ++i;
            }
            numArray[j] = numArray[i];
        }
        // temp 回到中间某位置（并非正中间）
        numArray[i] = temp;

        if (left < i-1)
        {
            QuickSortFunc(numArray, left, i-1);
        }
        if (right > i+1)
        {
            QuickSortFunc(numArray, i+1, right);
        }   
    }
}
