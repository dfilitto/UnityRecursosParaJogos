using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class InputMobile : MonoBehaviour
{
    UnityEngine.Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        rot = UnityEngine.Vector3.zero;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        GyroModifyCamera();
        //Quaternion qt = Input.gyro.attitude;
        //qt.y = 0;
        //transform.rotation = qt;

        //rot.z = Input.gyro.rotationRateUnbiased.z;
        //rot.x = Input.gyro.rotationRateUnbiased.x;
        //Debug.Log(Input.gyro.attitude);
        //transform.Rotate(rot);
    }

    void GyroModifyCamera()
    {
        transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.z, q.y, q.w);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Você Ganhou!!!!!");
        if (other.tag == "Ball")
        {
            Debug.Log("Você Ganhou!!!!!");
        }
    }
}
