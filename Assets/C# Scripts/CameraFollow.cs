using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform catPos;

    void Update()
    {
        if (catPos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, catPos.position.y, transform.position.z);
        }
    }
}
