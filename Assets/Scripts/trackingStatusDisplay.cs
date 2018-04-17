using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.iOS;

[RequireComponent(typeof(Text))]
public class trackingStatusDisplay : MonoBehaviour {

    private string _trackingState;
    private Text _text;

	// Use this for initialization
	void Start () {
        UnityARSessionNativeInterface.ARFrameUpdatedEvent += ARFrameUpdated;
        _text = gameObject.GetComponent<Text>();
	}

    void ARFrameUpdated(UnityARCamera unityArCamera)
    {
        _trackingState = string.Format("TrackingState: {0}\n TrackingReason: {1}", unityArCamera.trackingState, unityArCamera.trackingReason);
    }
	
	// Update is called once per frame
	void Update () {
        _text.text = _trackingState;
	}
}
