using UnityEngine;

public class RotateInCamera : MonoBehaviour
{

    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}