using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftMovement : ICommand2
{
    public Transform _player;
    public float _speed;
    public MoveLeftMovement(Transform player, float speed)
    {
        this._player = player;
        this._speed = speed;
    }
    public void Execute()
    {
        _player.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    public void Undue()
    {
        _player.Translate(Vector3.right * _speed * Time.deltaTime);


    }
}
