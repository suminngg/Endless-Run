using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotation : MonoBehaviour
{
    float rotateData = 0.0f;

    void Update()
    {
        rotateData += Time.deltaTime;

        if (rotateData >= 360)
        {
            rotateData = 0.0f;
        }

        RenderSettings.skybox.SetFloat("_Rotation", rotateData);

    }
}
