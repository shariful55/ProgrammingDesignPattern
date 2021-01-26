using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
    public GameObject _cube;
    public Color _color;
    public Color previousColor;
    public ClickCommand(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }

    public void Execute()
    {
        previousColor = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    public void Undue()
    {
        _cube.GetComponent<MeshRenderer>().material.color= previousColor;
    }

}
