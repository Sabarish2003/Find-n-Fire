using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberDissappear : MonoBehaviour {

    public float time = 1;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
}
