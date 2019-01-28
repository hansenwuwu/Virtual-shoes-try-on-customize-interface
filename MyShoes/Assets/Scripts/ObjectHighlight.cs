using UnityEngine;
using System.Collections;

public class ObjectHighlight : MonoBehaviour {


//	private Color startColor;
	private Shader startShader;
	public bool showGlow = false;
	private bool lastShowGlow;
	void Start()
	{
		lastShowGlow = showGlow;
//		startShader = GetComponent<Renderer> ().material.shader;
	}

	void Update(){
		//Debug.Log(Screen.width+" , "+Screen.height);
		//Debug.Log (Input.mousePosition.x+" , "+Input.mousePosition.y);
		if (lastShowGlow != showGlow) {	// change texture only on tag change
			if (showGlow) {
				GlowTextureOn ();
				lastShowGlow = true;
			} else {
				GlowTextureOff ();
				lastShowGlow = false;
			}
		}
	}

	void GlowTextureOn()
	{
		startShader = GetComponent<Renderer> ().material.shader;
		GetComponent<Renderer> ().material.shader = Shader.Find("Custom/GradientGlow2");
		//print (startShader.name);
//		startColor = GetComponent<Renderer>().material.color;
//		GetComponent<Renderer> ().material.color = new Color(0.7f,0.8f,0.8f,1.0f);
//		GetComponent<Renderer> ().material = mat1;
		//nui.SetActive (true);

	}

	void GlowTextureOff()
	{
//		Debug.Log (startShader.name);
//		GetComponent<Renderer>().material.color = startColor;
		GetComponent<Renderer> ().material.shader = startShader;

	}


}
