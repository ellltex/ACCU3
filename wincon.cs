using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wincon : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<dice>().tärninga + GetComponent<dice1>().tärningb + GetComponent<dice2>().tärningc == 18)
        {
            10*pengar
        }
    }
}