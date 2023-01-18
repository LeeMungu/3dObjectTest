using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int distance = 1;

    [SerializeField]
    private Transform tailTransform;
 
    private float a = 1;

    void OnEnable()
    {
        a = 1;
    }

    void Update () 
    {
        //float x += Time.deltaTime * 10;
        //transform.rotation = Quaternion.Euler(x,0,0);

        a += Time.deltaTime;
        float zPosition = distance * Mathf.Sin(a);
        float xPosition = distance * Mathf.Cos(a);
        transform.localPosition = new Vector3(xPosition, 0, zPosition);
       
        float angle = GameManager.Instance.GetTargetAngle();
        Debug.Log("angle : " + angle);

        if (angle < 90 && angle > -90)
        {
            tailTransform.LookAt(GameManager.Instance.TargetTransform);
        }
    }
}
