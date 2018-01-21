using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonDisable : MonoBehaviour {

    public Button myButton;

	// Use this for initialization
	void Start () {
        myButton.interactable = false;        
	}

    public void ButtonEnable()
    {
        myButton.interactable = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
