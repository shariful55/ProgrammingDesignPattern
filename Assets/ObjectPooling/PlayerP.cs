using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerP : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = PoolManager.Instance.requestBullet();
            go.transform.position = Vector3.zero;
        }
        
    }
}
