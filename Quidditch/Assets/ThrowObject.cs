using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour {

    public SteamVR_TrackedObject trackedObject;
    public SteamVR_Controller.Device device;
    public float throwSpeed = 2.0f;
    public GameObject ball;
    public GameObject cam;

    // Use this for initialization
    void Start()
    {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        device = SteamVR_Controller.Input((int)trackedObject.index);
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            ball.GetComponent<Rigidbody>().isKinematic = false;
            ball.transform.SetParent(null);
            TossObject(ball.GetComponent<Rigidbody>());
        }
    }

    public void TossObject(Rigidbody rigidBody)
    {

        //add my speed 
        //transform.attachedRigidbody
        rigidBody.velocity = cam.GetComponent<Rigidbody>().velocity + device.velocity * throwSpeed;
        rigidBody.angularVelocity = cam.GetComponent<Rigidbody>().angularVelocity + device.angularVelocity;
    }

}
