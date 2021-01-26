using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    //turn this class into a singleton for easy accessibility
    private static PoolManager _instance;
    public static PoolManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The PoolManager is Null");
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
    }
    [SerializeField]
    private GameObject _bulletContainer;
    [SerializeField]
    private GameObject playerPrefab;
    [SerializeField]
    private List<GameObject> bulletPool;
    void Start()
    {
       bulletPool= generateBullets(5);
    }

    

    // pregenerate a list of bullets gameobjects
    List<GameObject> generateBullets(int amountOfBullets)
    {
        for (int i = 0; i < amountOfBullets; i++)
        {
            GameObject bullet = Instantiate(playerPrefab);
            bullet.transform.parent = _bulletContainer.transform;
            bullet.SetActive(false);
            bulletPool.Add(bullet);
        }
        
        return bulletPool;
    }

    public GameObject requestBullet()
    {
       foreach(var bullet in bulletPool)
        {
            if (bullet.activeInHierarchy == false)
            {
                bullet.SetActive(true);
                return bullet;
            }
       }

        GameObject newBullet = Instantiate(playerPrefab);
        newBullet.transform.parent = _bulletContainer.transform;
        newBullet.SetActive(false);
        bulletPool.Add(newBullet);
        return newBullet;
    }

}
