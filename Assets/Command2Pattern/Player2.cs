using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    ICommand2 moveUp, moveDown, moveLeft, moveRight;
    [SerializeField]
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveUp = new MoveUpMovement(this.transform, speed);
            moveUp.Execute();
            CommandManager2.Instance.AddCommand(moveUp);
        } else if (Input.GetKey(KeyCode.S))
        {
            moveDown = new MoveDownMovement(this.transform, speed);
            moveDown.Execute();
            CommandManager2.Instance.AddCommand(moveDown);

        } else if (Input.GetKey(KeyCode.A))
        {
            moveLeft = new MoveLeftMovement(this.transform, speed);
            moveLeft.Execute();
            CommandManager2.Instance.AddCommand(moveLeft);

        } else if (Input.GetKey(KeyCode.D))
        {
            moveRight = new MoveRightMovement(this.transform, speed);
            moveRight.Execute();
            CommandManager2.Instance.AddCommand(moveRight);
        } 

    }
}
