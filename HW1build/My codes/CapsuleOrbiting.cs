using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleOrbiting : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0.05f, 0f * Time.deltaTime);
    }
}