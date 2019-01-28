using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {
	
	public GameObject[] target;
	public Color _color1 = new Color(0.847f,0.047f,0.184f,1.0f);
	public Color _color2 = new Color(0.059f,0.388f,0.737f,1.0f);
	public Color _color3 = new Color(0.549f,0.773f,0.847f,1.0f);
	public Color _color4 = new Color(0.706f,0.871f,0.925f,1.0f);
	public Color _color5 = new Color(0.0f,0.447f,0.549f,1.0f);
	public Material mat_leather;
	public Material mat_leather2;
	public Material mat_lidosMash;
	public Material mat_mash;
	public Material mat_snakeLeather;

	public Material mat_lace;
	public Material mat_lace2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetColorRChannel (){
		if (UIProgressBar.current == null)
			return;
		foreach (GameObject go in target) {
			Color tmpColor = go.GetComponent<Renderer> ().material.color;
			tmpColor.r = UIProgressBar.current.value;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void SetColorGChannel (){
		if (UIProgressBar.current == null)
			return;
		foreach (GameObject go in target) {
			Color tmpColor = go.GetComponent<Renderer> ().material.color;
			tmpColor.g = UIProgressBar.current.value;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void SetColorBChannel (){
		if (UIProgressBar.current == null)
			return;
		foreach (GameObject go in target) {
			Color tmpColor = go.GetComponent<Renderer> ().material.color;
			tmpColor.b = UIProgressBar.current.value;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void ColorWhite () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.9f,0.9f,0.9f,1.0f);
		}
	}

	public void ColorGrey () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.4f,0.4f,0.4f,1.0f);
		}
	}

	public void ColorBlack () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.2f,0.2f,0.2f,1.0f);
		}
	}

	public void ColorSkin () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.9f,0.7f,0.6f,1.0f);
		}
	}

	public void ColorBrown () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.5f,0.4f,0.3f,1.0f);
		}
	}

	public void ColorOrange () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(1.0f,0.6f,0.3f,1.0f);
		}
	}

	public void ColorRed () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.5f,0.1f,0.1f,1.0f);
		}
	}

	public void ColorDarkRed () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.2f,0.0f,0.0f,1.0f);
		}
	}

	public void ColorLimeGreen () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.6f,0.7f,0.5f,1.0f);
		}
	}

	public void ColorYellow () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.7f,0.6f,0.1f,1.0f);
		}
	}

	public void ColorGreen () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.1f,0.4f,0.0f,1.0f);
		}
	}

	public void ColorDarkGreen () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.3f,0.3f,0.1f,1.0f);
		}
	}

	public void ColorLightPurple () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.9f,0.7f,0.9f,1.0f);
		}
	}

	public void ColorPurple () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.6f,0.4f,0.8f,1.0f);
		}
	}

	public void ColorPeach () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.7f,0.3f,0.7f,1.0f);
		}
	}

	public void ColorPink () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.7f,0.6f,0.6f,1.0f);
		}
	}

	public void ColorDarkPurple () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.3f,0.1f,0.7f,1.0f);
		}
	}

	public void ColorBlueGreen () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.4f,1.0f,0.85f,1.0f);
		}
	}

	public void ColorDarkBlueGreen () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.2f,0.8f,0.8f,1.0f);
		}
	}

	public void ColorLightBlue () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.4f,0.9f,1.0f,1.0f);
		}
	}

	public void ColorBlue () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = new Color(0.0f,0.5f,1.0f,1.0f);
		}
	}

	public void Color1 () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = _color1;
		}
	}

	public void Color2 () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = _color2;
		}
	}

	public void Color3 () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = _color3;
		}
	}

	public void Color4 () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = _color4;
		}
	}

	public void Color5 () {
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material.color = _color5;
		}
	}

	public void TextureLeather () {
		Color tmpColor = target [0].GetComponent<Renderer> ().material.color;
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material = mat_leather;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void TextureLeather2 () {
		Color tmpColor = target [0].GetComponent<Renderer> ().material.color;
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material = mat_leather2;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void TextureMash () {
		Color tmpColor = target [0].GetComponent<Renderer> ().material.color;
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material = mat_mash;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void TextureLidosMash () {
		Color tmpColor = target [0].GetComponent<Renderer> ().material.color;
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material = mat_lidosMash;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void TextureSnakeLeather () {
		Color tmpColor = target [0].GetComponent<Renderer> ().material.color;
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material = mat_snakeLeather;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void TextureLace () {
		Color tmpColor = target [0].GetComponent<Renderer> ().material.color;
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material = mat_lace;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

	public void TextureLace2 () {
		Color tmpColor = target [0].GetComponent<Renderer> ().material.color;
		foreach (GameObject go in target) {
			go.GetComponent<Renderer> ().material = mat_lace2;
			go.GetComponent<Renderer> ().material.color = tmpColor;
		}
	}

}
