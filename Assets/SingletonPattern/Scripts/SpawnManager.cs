using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoSingleton<SpawnManager>
{
    public string address;
    public void StartSpawn()
    {
        Debug.Log("Spawn started  ");
        address = "Shariful islam is trying  to do something here to develop a awesome game ";
        
        Debug.Log(address);
        UIManager.Instance.UpdateScore(457);
        
    }
}
