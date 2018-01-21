using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingScreenScript : MonoBehaviour {

    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    public void RendEnable()
    {
        rend.enabled = true;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
