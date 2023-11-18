using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("Follow Object")]
    [Tooltip("Drag and drop the player object on the following variable to set it on the center of the camera, this script avoid the camera to rotate if the player object does it.")]
    [SerializeField] public GameObject objectTarget = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(objectTarget.transform.position.x, objectTarget.transform.position.y, transform.position.z);
    }
}
