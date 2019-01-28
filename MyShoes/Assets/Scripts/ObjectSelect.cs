using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSelect : MonoBehaviour {
    //	private Dictionary<GameObject,int> aa;
    //	private GameObject[] allObjects;/// = GameObject.FindGameObjectsWithTag ("UI Color");

    // Shoe 02
    public GameObject Shoe02MainColor;
    public GameObject Shoe02Part01Color;
    public GameObject Shoe02Part02Color;
    public GameObject Shoe02Part03Color;

    // Shoe 01
    public GameObject SkinColor;
	public GameObject SkinTexture;
	public GameObject LaceColor;
	public GameObject LaceTexture;

	public GameObject LabelColor;
	public GameObject MidsoleColor;
	public GameObject OutsoleColor;
	public GameObject RouteColor;
	public GameObject CurrentPartLabel;


    //	private string currentHighlight;
    // Use this for initialization
    void Start () {
		//allObjects = GameObject.FindGameObjectsWithTag ("UI Color");

//		int remaining = GameObject.FindGameObjectsWithTag("Shoes").Length;
//		GameObject[] allObjects = GameObject.FindGameObjectsWithTag ("Shoes");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			//Debug.Log("Mouse is down");

			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) 
			{

                // ----------------Shoe02----------------
                if (hitInfo.transform.gameObject.tag == "Shoe02_main")
                {
                    hideAll();
                    NGUITools.SetActive(Shoe02MainColor, true);
                    NGUITools.SetActive(CurrentPartLabel, true);
                    CurrentPartLabel.GetComponent<UILabel>().text = "main";
                }
                else if(hitInfo.transform.gameObject.tag == "Shoe02_part01")
                {
                    hideAll();
                    NGUITools.SetActive(Shoe02Part01Color, true);
                    NGUITools.SetActive(CurrentPartLabel, true);
                    CurrentPartLabel.GetComponent<UILabel>().text = "part01";
                }
                else if (hitInfo.transform.gameObject.tag == "Shoe02_part02")
                {
                    hideAll();
                    NGUITools.SetActive(Shoe02Part02Color, true);
                    NGUITools.SetActive(CurrentPartLabel, true);
                    CurrentPartLabel.GetComponent<UILabel>().text = "part02";
                }
                else if (hitInfo.transform.gameObject.tag == "Shoe02_part03")
                {
                    hideAll();
                    NGUITools.SetActive(Shoe02Part03Color, true);
                    NGUITools.SetActive(CurrentPartLabel, true);
                    CurrentPartLabel.GetComponent<UILabel>().text = "part03";
                }


                // ----------------Shoe01------------------
                //				Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "Lace") {
					hideAll ();         
					NGUITools.SetActive (LaceColor, true);
					NGUITools.SetActive (LaceTexture, true);
					enableHighlight ("Lace");
					NGUITools.SetActive (CurrentPartLabel, true);
					CurrentPartLabel.GetComponent<UILabel> ().text = "Lace";
				} else if (hitInfo.transform.gameObject.tag == "Skin") {
					hideAll ();
					NGUITools.SetActive (SkinColor, true);
					NGUITools.SetActive (SkinTexture, true);
					enableHighlight ("Skin");
					NGUITools.SetActive (CurrentPartLabel, true);
					CurrentPartLabel.GetComponent<UILabel> ().text = "Upper";
				} else if (hitInfo.transform.gameObject.tag == "Label") {
					hideAll ();
					NGUITools.SetActive (LabelColor, true);
					enableHighlight ("Label");
					NGUITools.SetActive (CurrentPartLabel, true);
					CurrentPartLabel.GetComponent<UILabel> ().text = "Pulltab";
				} else if (hitInfo.transform.gameObject.tag == "Midsole") {
					hideAll ();
					NGUITools.SetActive (MidsoleColor, true);
					enableHighlight ("Midsole");
					NGUITools.SetActive (CurrentPartLabel, true);
					CurrentPartLabel.GetComponent<UILabel> ().text = "Midsole";
				} else if (hitInfo.transform.gameObject.tag == "Outsole") {
					hideAll ();
					NGUITools.SetActive (OutsoleColor, true);
					enableHighlight ("Outsole");
					NGUITools.SetActive (CurrentPartLabel, true);
					CurrentPartLabel.GetComponent<UILabel> ().text = "Outsole";
				} else if (hitInfo.transform.gameObject.tag == "Routesole") {
					hideAll ();
					NGUITools.SetActive (RouteColor, true);
					enableHighlight ("Routesole");
					NGUITools.SetActive (CurrentPartLabel, true);
					CurrentPartLabel.GetComponent<UILabel> ().text = "Routesole";
				}  else if (hitInfo.transform.gameObject.tag == "NGUI") {
					// by pass
				} else {
					//Debug.Log ("nopz");
					//hideAll ();
				}
			} else {
				//Debug.Log("No hit");
			}
			//Debug.Log("Mouse is down");
		} 
	}

	void enableHighlight(string partName){
//		GameObject[] skinObjects = GameObject.FindGameObjectsWithTag (partName);
//		foreach (GameObject go in skinObjects) {
//			go.GetComponent<ObjectHighlight> ().showGlow = true;
//		}
//		currentHighlight = partName;
	}

	void disableHighlight(string partName){
		GameObject[] skinObjects = GameObject.FindGameObjectsWithTag (partName);
		foreach (GameObject go in skinObjects) {
			go.GetComponent<ObjectHighlight> ().showGlow = false;
		}
	}

	void hideAll () {
		NGUITools.SetActive(SkinColor,false);
		NGUITools.SetActive(SkinTexture,false);
		NGUITools.SetActive(LaceColor,false);
		NGUITools.SetActive(LaceTexture,false);
		NGUITools.SetActive(LabelColor,false);
		NGUITools.SetActive(MidsoleColor,false);
		NGUITools.SetActive(OutsoleColor,false);
		NGUITools.SetActive(RouteColor,false);
		NGUITools.SetActive(CurrentPartLabel,false);

        // Shoe02
        NGUITools.SetActive(Shoe02MainColor, false);
        NGUITools.SetActive(Shoe02Part01Color, false);
        NGUITools.SetActive(Shoe02Part02Color, false);
        NGUITools.SetActive(Shoe02Part03Color, false);

        //		if(currentHighlight != null)
        //			disableHighlight (currentHighlight);
    }
//	void HideChildren()
//	{
//		Renderer[] lChildRenderers=gameObject.GetComponentsInChildren<Renderer>();
//		foreach ( Renderer lRenderer in lChildRenderers)
//		{
//			lRenderer.enabled=false;
//		}
//	}

//	void showAll () {
//		foreach (GameObject go2 in allObjects) {
//			if (go2 != null)
//				go2.SetActive (true);
//		}
//	}
}
