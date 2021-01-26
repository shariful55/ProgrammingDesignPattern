using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    public void UpdateScore(int score)
    {
        Debug.Log("Score  " + score);
        Debug.Log("Notifying the GameManager that is ");
        GameManager.Instance.DisplayName();
        
    }

}
