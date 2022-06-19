using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dice1 : MonoBehaviour {

public GameObject Image1a;
public GameObject Image2a;
public GameObject Image3a;
public GameObject Image4a;
public GameObject Image5a;
public GameObject Image6a;
private int sida1;
public int tärningb;
public void RandomGenerate ()
{
    sida1 = Random.Range (1, 7);

if (true )
{
    Image1a.SetActive(false);
    Image2a.SetActive(false);
    Image3a.SetActive(false);
    Image4a.SetActive(false);
    Image5a.SetActive(false);
    Image6a.SetActive(false);

}

if (sida1 == 1)
{
    Image1a.SetActive(true);
}
if (sida1 == 2)
{
    Image2a.SetActive(true);
}
if (sida1 == 3)
{
    Image3a.SetActive(true);
}
if (sida1 == 4)
{
    Image4a.SetActive(true);
}
if (sida1 == 5)
{
    Image5a.SetActive(true);
}
if (sida1 == 6)
{
    Image6a.SetActive(true);
}
tärningb = sida1;
}
}