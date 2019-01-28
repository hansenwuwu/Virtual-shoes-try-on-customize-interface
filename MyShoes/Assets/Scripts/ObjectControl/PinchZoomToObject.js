/*
Take note that the effect of zooming in and out using this code is using the field of view and not changing the position of the camera itself.
Your camera's projection has to be set to PERSPECTIVE from the unity inspector for the zoom function to work.
*/

#pragma strict
private var minPinchSpeed:float = 5.0F;
private var minDistance:float = 5.0F;
private var touchDelta:float;
private var previousDistance:Vector2;
private var currentDistance:Vector2;
private var speedTouch0:float;
private var speedTouch1:float;

// change the zooming speed.
// when using mouse, the greater this variable, the lesser you have to scroll to zoom in or out.
// on touch devices, this will affect the sensitivity of pinching action.
// in principle, the larger the device, the greater this variable should be.
var speed:int = 3;

// variables to adjust the maximun and minimum camera distance.
// the higher the number means the camera is set farther from the object.
// the lower the number means the camera is set nearer to the object.
var maxOut:int = 40;
var maxIn:int = 15;


function Update () {
	// For NGUI

		if(Input.mousePosition.x<200 || Input.mousePosition.x+200>Screen.width)
		{
			//print(Input.mousePosition.x);
			return;
		}

		//
	// this part of the script is for touch enabled devices (mobile phone / tablet).
	if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved) 
	{
		currentDistance = Input.GetTouch(0).position - Input.GetTouch(1).position;
		previousDistance = ((Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition) - (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition));
		touchDelta = currentDistance.magnitude - previousDistance.magnitude;
		speedTouch0 = Input.GetTouch(0).deltaPosition.magnitude / Input.GetTouch(0).deltaTime;
		speedTouch1 = Input.GetTouch(1).deltaPosition.magnitude / Input.GetTouch(1).deltaTime;
		
		if ((touchDelta + minDistance <= 5) && (speedTouch0 > minPinchSpeed) && (speedTouch1 > minPinchSpeed))
		{
			this.GetComponent.<Camera>().fieldOfView = Mathf.Clamp(this.GetComponent.<Camera>().fieldOfView + (1 * speed),maxIn,maxOut);
		}

		if ((touchDelta + minDistance > 5) && (speedTouch0 > minPinchSpeed) && (speedTouch1 > minPinchSpeed))
		{
			this.GetComponent.<Camera>().fieldOfView = Mathf.Clamp(this.GetComponent.<Camera>().fieldOfView - (1 * speed),maxIn,maxOut);
		}
	}
	
	// this part of the script is for non-touch enabled devices (mac/windows/web).
	// the zoom effect is achieved by using mouse scroll wheel.
	if( Input.GetAxis("Mouse ScrollWheel") < 0) {
		this.GetComponent.<Camera>().fieldOfView = Mathf.Clamp(this.GetComponent.<Camera>().fieldOfView + (1 * speed),maxIn,maxOut);
		
	} else if( Input.GetAxis("Mouse ScrollWheel") > 0){
		this.GetComponent.<Camera>().fieldOfView = Mathf.Clamp(this.GetComponent.<Camera>().fieldOfView - (1 * speed),maxIn,maxOut);
		
	}
}
