using UnityEngine;
using System.Collections;

public class Binitial : MonoBehaviour {
	public GameObject target;
	// Use this for initialization
	void Start () {
		GetComponent<UISlider>().value =target.GetComponent<Renderer> ().material.color.b;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<UISlider>().value =target.GetComponent<Renderer> ().material.color.b;
	}
}
