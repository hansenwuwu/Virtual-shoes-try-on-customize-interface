using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	public GameObject[] color1; 
	public GameObject[] color2; 
	public GameObject[] color3; 
	public GameObject[] color4; 
	public GameObject[] color5; 
	public GameObject[] part; 
	// Use this for initialization
	void Start () {
//		changeColor1 ("#FAAAAA");
//		changeColor2 ("#2344FF");
//		changeColor3 ("#F2222F");
//		changeColor4 ("#FF2222");
//		changeColor5 ("#F53211");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static Color hexToColor(string hex)
	{
		hex = hex.Replace ("0x", "");//in case the string is formatted 0xFFFFFF
		hex = hex.Replace ("#", "");//in case the string is formatted #FFFFFF
		byte a = 255;//assume fully visible unless specified in hex
		byte r = byte.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber);
		byte g = byte.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber);
		byte b = byte.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
		//Only use alpha if the string has enough characters
		if(hex.Length == 8){
			a = byte.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber);
		}
		return new Color32(r,g,b,a);
	}

	public void changeColor1(string colorStr){
		Color newColor = hexToColor (colorStr);
		Color newHover = newColor;
		newHover.a = 0.5f;
		foreach (GameObject go in color1) {
			go.GetComponent<UISprite> ().color = newColor;
			go.GetComponent<UIButton> ().hover = newHover;
		}
		foreach (GameObject go in part) {
			go.GetComponent<ChangeMaterial> ()._color1 = newColor;
		}
	}

	public void changeColor2(string colorStr){
		Color newColor = hexToColor (colorStr);
		Color newHover = newColor;
		newHover.a = 0.5f;
		foreach (GameObject go in color2) {
			go.GetComponent<UISprite> ().color = newColor;
			go.GetComponent<UIButton> ().hover = newHover;
		}
		foreach (GameObject go in part) {
			go.GetComponent<ChangeMaterial> ()._color2 = newColor;
		}
	}

	public void changeColor3(string colorStr){
		Color newColor = hexToColor (colorStr);
		Color newHover = newColor;
		newHover.a = 0.5f;
		foreach (GameObject go in color3) {
			go.GetComponent<UISprite> ().color = newColor;
			go.GetComponent<UIButton> ().hover = newHover;
		}
		foreach (GameObject go in part) {
			go.GetComponent<ChangeMaterial> ()._color3 = newColor;
		}
	}

	public void changeColor4(string colorStr){
		Color newColor = hexToColor (colorStr);
		Color newHover = newColor;
		newHover.a = 0.5f;
		foreach (GameObject go in color4) {
			go.GetComponent<UISprite> ().color = newColor;
			go.GetComponent<UIButton> ().hover = newHover;
		}
		foreach (GameObject go in part) {
			go.GetComponent<ChangeMaterial> ()._color4 = newColor;
		}
	}

	public void changeColor5(string colorStr){
		Color newColor = hexToColor (colorStr);
		Color newHover = newColor;
		newHover.a = 0.5f;
		foreach (GameObject go in color5) {
			go.GetComponent<UISprite> ().color = newColor;
			go.GetComponent<UIButton> ().hover = newHover;
		}
		foreach (GameObject go in part) {
			go.GetComponent<ChangeMaterial> ()._color5 = newColor;
		}
	}
}
