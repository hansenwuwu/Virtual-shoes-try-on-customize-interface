using UnityEngine;
using System.Collections;

public class ChangeViewport : MonoBehaviour {


	public GameObject Btn_side;
	public GameObject Btn_top;
	public GameObject Btn_bottom;
	public GameObject Shoes;

    public int ShoeNumber;

    private Vector3 SideLocalPosition;
    private Vector3 SideLocalEulerAngles;
    private Vector3 SideLocalScale;

    private Vector3 TopLocalPosition;
    private Vector3 TopLocalEulerAngles;
    private Vector3 TopLocalScale;

    private Vector3 BottomLocalPosition;
    private Vector3 BottomLocalEulerAngles;
    private Vector3 BottomLocalScale;

    // Use this for initialization
    void Start () {

        // define which shoes position
        if (ShoeNumber == 1)
        {
            SideLocalPosition = new Vector3(1.11f, 1.82f, 0.99f);
            SideLocalEulerAngles = new Vector3(-55.3504f, -130.1289f, 179.2657f);
            SideLocalScale = new Vector3(10f, 10f, 10f);

            TopLocalPosition = new Vector3(1.2f, 1f, 0f);
            TopLocalEulerAngles = new Vector3(0f, 180f, -90f);
            TopLocalScale = new Vector3(10f, 10f, 10f);

            BottomLocalPosition = new Vector3(1.2f, 1f, 0f);
            BottomLocalEulerAngles = new Vector3(0f, 0f, 90f);
            BottomLocalScale = new Vector3(10f, 10f, 10f);
        }
        else if (ShoeNumber == 2)
        {
            SideLocalPosition = new Vector3(0.007f, 0.777f, 0.384f);
            SideLocalEulerAngles = new Vector3(-42.66171f, -121.5313f, 86.57401f);
            SideLocalScale = new Vector3(0.0075f, 0.0075f, 0.0075f);

            TopLocalPosition = new Vector3(-0.357f, 1.03f, 0.214f);
            TopLocalEulerAngles = new Vector3(-1.664764f, -156.4535f, -179.4202f);
            TopLocalScale = new Vector3(0.0075f, 0.0075f, 0.0075f);

            BottomLocalPosition = new Vector3(-0.18f, 0.83f, 0.15f);
            BottomLocalEulerAngles = new Vector3(-4.975891f, -20.41605f, 2.018182f);
            BottomLocalScale = new Vector3(0.0075f, 0.0075f, 0.0075f);
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ViewSide(){
		Btn_side.GetComponent<UIButton> ().defaultColor = Color.white;
		Btn_top.GetComponent<UIButton> ().defaultColor = Color.gray;
		Btn_bottom.GetComponent<UIButton> ().defaultColor = Color.gray;
        Shoes.transform.localPosition = SideLocalPosition;
        Shoes.transform.localEulerAngles = SideLocalEulerAngles;
		Shoes.transform.localScale = SideLocalScale;
	}

	public void ViewTop(){
		Btn_side.GetComponent<UIButton> ().defaultColor = Color.gray;
		Btn_top.GetComponent<UIButton> ().defaultColor = Color.white;
		Btn_bottom.GetComponent<UIButton> ().defaultColor = Color.gray;
		Shoes.transform.localPosition = TopLocalPosition;
		Shoes.transform.localEulerAngles = TopLocalEulerAngles;
		Shoes.transform.localScale = TopLocalScale;
	}

	public void ViewBottom(){
		Btn_side.GetComponent<UIButton> ().defaultColor = Color.gray;
		Btn_top.GetComponent<UIButton> ().defaultColor = Color.gray;
		Btn_bottom.GetComponent<UIButton> ().defaultColor = Color.white;
		Shoes.transform.localPosition = BottomLocalPosition;
		Shoes.transform.localEulerAngles = BottomLocalEulerAngles;
		Shoes.transform.localScale = BottomLocalScale;
	}

}
