using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class arfile : MonoBehaviour
{
    public ARRaycastManager aRRaycastManager;
    public GameObject platFormObject;
    void Start()
    {

    }

    void Update()
    {
        List<ARRaycastHit> _arRaycast = new List<ARRaycastHit>();
        aRRaycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), _arRaycast);

        if (_arRaycast.Count > 0)
        {
            platFormObject.transform.position = _arRaycast[0].pose.position;
            platFormObject.transform.rotation = _arRaycast[0].pose.rotation;
        }
    }
}