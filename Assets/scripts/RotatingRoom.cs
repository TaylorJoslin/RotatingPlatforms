using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingRoom : MonoBehaviour
{
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, speed);
    }
}
