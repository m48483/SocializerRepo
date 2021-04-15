using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float a;    // 변수 선언
        float b;

        a = 3.14f;  // 저장
        b = 4.05f;

        float sum, sub, mul, div;   //더하기 빼기 곱하기 나누기
        sum = a + b;
        sub = a - b;
        mul = a * b;
        div = a / b;

        Debug.Log(sum);
        Debug.Log(sub);
        Debug.Log(mul);
        Debug.Log(div);
    }
}