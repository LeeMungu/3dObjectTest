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

    private void Awake()
    {
        Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;        
    }

    private void Update()
    {

    }

    public float GetTargetAngle()
    {
        Vector3 v = targetTransform.position - playerTransform.position;
 
        return Mathf.Atan2(v.z, v.x) * Mathf.Rad2Deg;
    }
}
