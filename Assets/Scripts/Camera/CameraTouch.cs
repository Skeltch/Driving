using UnityEngine;
using System.Collections;

public class CameraTouch : MonoBehaviour
{

    Vector3 firstPoint;
    Vector3 secondPoint;
    float xAngTemp = 0.0f;
    float yAngTemp = 0.0f;
    float xAngle = 0.0f;
    float yAngle = 0.0f;
    // Use this for initialization
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            firstPoint = Input.GetTouch(0).position;
            xAngTemp = xAngle;
            yAngTemp = yAngle;
        }
        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            secondPoint = Input.GetTouch(0).position;
            xAngle = xAngTemp + (secondPoint.x - firstPoint.x) * 180.0f / Screen.width;
            yAngle = yAngTemp - (secondPoint.y - firstPoint.y) * 90.0f / Screen.height;
            this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
        }
    }
}
