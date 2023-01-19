using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
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
        float yPosition = distance * Mathf.Sin(a);
        transform.localPosition = GameManager.Instance.TargetTransform.localPosition + new Vector3(xPosition, yPosition, zPosition);
       
        float angle = GameManager.Instance.GetTargetAngle(transform.localPosition);
        //Debug.Log("angle : " + angle);
        tailTransform.LookAt(GameManager.Instance.TargetTransform);
    }
}
