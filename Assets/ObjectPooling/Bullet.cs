using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnEnable()
    {
        Invoke("Hide", 1f);
    }

    void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
