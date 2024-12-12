using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float move_speed = 0.001f;
    [SerializeField] float rotation_speed = 0.05f;
    void Start()
    {
        transform.Translate(0, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, move_speed, 0);
        transform.Rotate(0, 0, rotation_speed);
    }
}
