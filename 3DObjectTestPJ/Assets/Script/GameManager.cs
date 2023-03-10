using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField]
    private Transform targetTransform;

    public Transform TargetTransform => targetTransform;

    [SerializeField]
    private Transform playerTransform;

    float a = 1;

    private void Awake()
    {
        Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;        
    }

    private void LateUpdate()
    {
        a += Time.deltaTime/3;
        float zPosition = 4 * Mathf.Sin(a);
        float xPosition = 4 * Mathf.Cos(a);
        targetTransform.localPosition = new Vector3(-xPosition, 0, -zPosition);
    }

    public float GetTargetAngle(Vector3 localPosition)
    {
        Vector3 v = targetTransform.localPosition - localPosition;
 
        return Mathf.Atan2(v.z, v.x) * Mathf.Rad2Deg;
    }
}
