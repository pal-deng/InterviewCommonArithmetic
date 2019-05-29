using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class Util : MonoBehaviour {

    const string connectStr = "-";

    public static void PrintInfo(int[] numArray)
    {
        int arrayCount = numArray.Length;
        StringBuilder stringBuilder = new StringBuilder();
        for (int k = 0; k < arrayCount; ++k)
        {
            stringBuilder.Append(numArray[k]);
            if (k < arrayCount - 1)
            {
                stringBuilder.Append(connectStr);
            }
        }
        Debug.Log(stringBuilder.ToString());
    }


}
