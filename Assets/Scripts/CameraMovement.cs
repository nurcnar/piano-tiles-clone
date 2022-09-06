using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float velocity;
    float acceleration=.5f;
    public static CameraMovement instance;
    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        transform.position += new Vector3(0, 1,0)*Time.deltaTime*velocity;
        velocity += Time.deltaTime * acceleration;
        acceleration -= Time.deltaTime*0.01f;
        acceleration = Mathf.Clamp(acceleration,0, 1);
    }
}
