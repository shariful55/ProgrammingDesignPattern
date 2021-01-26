using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray originRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(originRay, out RaycastHit HitInfo))
            {
                if (HitInfo.collider.tag == "cube")
                {
                    ICommand click = new ClickCommand(HitInfo.collider.gameObject,new Color(Random.value,Random.value,Random.value));
                    click.Execute();
                    CommandManager.Instance.AddCommand(click);


                }
            }
        }
        
    }
}
