using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;
    public GameObject cam;
    public Rigidbody camRigid;
    public float rotationRate = 100.0f;
    public float moveRate = 100.0f;

    void Start()
    {
       // var a = GetComponent<SteamVR_TrackedController>();
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        device = SteamVR_Controller.Input((int)this.trackedObj.index);
        device.TriggerHapticPulse((ushort)3999, Valve.VR.EVRButtonId.k_EButton_Axis0);

    }
    void Update()
    {
        if (SteamVR_Controller.Input((int)trackedObj.index).GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            //var x = SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x;
            //var y = SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y;

            //Vector3 charDirection = new Vector3(x, y, 0);
            //float charSpeed = 100.0f;
            /*
            if (Input.GetButton("moveRightKB"))
            {
                charDirection.x += 1;
            }
            if (Input.GetButton("moveLeftKB"))
            {
                charDirection.x -= 1;
            }
            if (Input.GetButton("moveUpKB"))
            {
                charDirection.y += 1;
            }
            if (Input.GetButton("moveDownKB"))
            {
                charDirection.y -= 1;
            }
            */
            //charDirection.Normalize();
            //camRigid.AddForce(new Vector3(charDirection.x * charSpeed * Time.deltaTime,
            //charDirection.y * charSpeed * Time.deltaTime,
            //0));
            camRigid.AddForce(trackedObj.transform.forward * Time.deltaTime * moveRate);

        }
        if (SteamVR_Controller.Input((int)trackedObj.index).GetPress(SteamVR_Controller.ButtonMask.Axis1))
        {
            Debug.Log("Trigger Axis 1 " + SteamVR_Controller.ButtonMask.Axis1);
            camRigid.AddForce(new Vector3(0, 10, 0));
        }

        cam.transform.rotation = trackedObj.transform.localRotation;
        //camRigid.AddTorque(trackedObj.transform.forward * Time.deltaTime * rotationRate);

        /*
        if (SteamVR_Controller.Input((int)trackedObj.index).GetPressDown(SteamVR_Controller.ButtonMask.Axis0))
            {
                Debug.Log("Touch Pad Click Axis 0 " + SteamVR_Controller.ButtonMask.Axis0);
            }

        // Check for Trigger pull
        if (SteamVR_Controller.Input((int)trackedObj.index).GetPressDown(SteamVR_Controller.ButtonMask.Axis1))
            {
                Debug.Log("Trigger Axis 1 " + SteamVR_Controller.ButtonMask.Axis1);
            }

        // Checks for Top Left Touchpad click
        if (SteamVR_Controller.Input((int)trackedObj.index).GetPressDown(SteamVR_Controller.ButtonMask.Touchpad)
    && SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x < 0.0f && SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y > 0.0f)
            {
            Debug.Log("Touchpad Top Left" + SteamVR_Controller.Input((int)trackedObj.index).GetAxis());
            camRigid.AddForce(new Vector3(SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x*100, SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y*100, 0));

            }

        // Checks for Bottom Left Touchpad click
        if (SteamVR_Controller.Input((int)trackedObj.index).GetPressDown(SteamVR_Controller.ButtonMask.Touchpad)
    && SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x < 0.0f && SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y < 0.0f)
            {
                Debug.Log("Touchpad Bottom Left" + SteamVR_Controller.Input((int)trackedObj.index).GetAxis());
            camRigid.AddForce(new Vector3(SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x * 100, SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y * 100, 0));

        }

        // Checks for Bottom Right Touchpad click
        if (SteamVR_Controller.Input((int)trackedObj.index).GetPressDown(SteamVR_Controller.ButtonMask.Touchpad)
    && SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x > 0.0f && SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y < 0.0f)
            {
                Debug.Log("Touchpad Bottom Right" + SteamVR_Controller.Input((int)trackedObj.index).GetAxis());
            camRigid.AddForce(new Vector3(SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x * 100, SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y * 100, 0));

        }

        // Checks for Top Right Touchpad click
        if (SteamVR_Controller.Input((int)trackedObj.index).GetPressDown(SteamVR_Controller.ButtonMask.Touchpad)
    && SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x > 0.0f && SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y > 0.0f)
            {
                Debug.Log("Touchpad Top Right" + SteamVR_Controller.Input((int)trackedObj.index).GetAxis());
            camRigid.AddForce(new Vector3(SteamVR_Controller.Input((int)trackedObj.index).GetAxis().x * 100, SteamVR_Controller.Input((int)trackedObj.index).GetAxis().y * 100, 0));

        }
        */
    }

}

