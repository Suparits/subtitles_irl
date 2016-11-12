using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class AzureHoopla : MonoBehaviour {
	WWWForm form = new WWWForm();

	//Create and attach headers
	Hashtable headers = form.headers;
	byte[] rawData = form.data;
	string url = "https://api.cognitive.microsoft.com/sts/v1.0";


	headers["Ocp-Apim-Subscription-Key"] = "999999999xxxxxxxxxyourkeygoeshere";
	headers ["Content-Type"] = "application/octet-stream";



}
