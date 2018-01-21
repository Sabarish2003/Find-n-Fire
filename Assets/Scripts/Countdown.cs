using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

    public GameObject Number1Prefab;
    public GameObject Number2Prefab;
    public GameObject Number3Prefab;
    public GameObject Number4Prefab;

    public void Countdown1()
    {
        GameObject Number = Instantiate(Number1Prefab, new Vector3(0, 0, 3), Quaternion.identity) as GameObject;
        Number.transform.parent = GameObject.Find("Canvas").transform;
        
    }

    public void Countdown2()
    {
        GameObject Number2 = Instantiate(Number2Prefab, new Vector3(0, 0, 3), Quaternion.identity) as GameObject;
        Number2.transform.parent = GameObject.Find("Canvas").transform;
    }

    public void Countdown3()
    {
        GameObject Number3 = Instantiate(Number3Prefab, new Vector3(0, 0, 3), Quaternion.identity) as GameObject;
        Number3.transform.parent = GameObject.Find("Canvas").transform;
    }

    public void CountdownGo()
    {
        GameObject Number4 = Instantiate(Number4Prefab, new Vector3(0, 0, 3), Quaternion.identity) as GameObject;
        Number4.transform.parent = GameObject.Find("Canvas").transform;
    }

    void Start()
    {
        Invoke("Countdown1", 1);
        Invoke("Countdown2", 2);
        Invoke("Countdown3", 3);
        Invoke("CountdownGo", 4);
    }
}
