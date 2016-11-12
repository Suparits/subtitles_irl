using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class micInput : MonoBehaviour {
	void Start() {
		AudioSource aud = gameObject.AddComponent <AudioSource>();
		aud.clip = Microphone.Start("Built-in Microphone", true, 3, 44100);
		aud.loop = true;
		while (!(Microphone.GetPosition(null) > 0)){};
		aud.Play();
	}
}
