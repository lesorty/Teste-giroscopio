using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyro_script : MonoBehaviour
{
    Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        rot = Vector3.zero;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        rot.y = Input.gyro.rotationRateUnbiased.x;
        transform.Rotate(rot);  
    }
}
