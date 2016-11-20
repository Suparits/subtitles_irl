using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cameraToImage : MonoBehaviour {
	public AudioSource audio = new AudioSource();
	public RawImage rawimage;
	void Start () 
	{
		WebCamTexture webcamTexture = new WebCamTexture();
		//webcamTexture.deviceName = "Kinect V2 Video Sensor";
		rawimage.texture = webcamTexture;
		rawimage.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}
}
