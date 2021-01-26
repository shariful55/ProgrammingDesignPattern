using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownMovement : ICommand2
{
    public Transform _player;
    public float _speed;
    public MoveDownMovement(Transform player, float speed)
    {
        this._player = player;
        this._speed = speed;
    }
    public void Execute()
    {
        _player.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    public void Undue()
    {
        _player.Translate(Vector3.up * _speed * Time.deltaTime);


    }
}
