using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slajd : MonoBehaviour {

    public Slider mainSlider;

	// Use this for initialization
	void Start () {
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ValueChangeCheck()
    {
        Debug.Log(mainSlider.value);
    }
}
