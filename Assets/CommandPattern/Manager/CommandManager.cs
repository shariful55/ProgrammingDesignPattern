using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoBehaviour
{
    private static CommandManager _instance;
    public static CommandManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The CommandManager is NUll");
            return _instance;
        }
    }

    public List<ICommand> _commandBuffer = new List<ICommand>();

    void Awake()
    {
        _instance = this;
    }

    //Create a method to add click to the commandBuffer 
    public void AddCommand(ICommand command)
    {
        _commandBuffer.Add(command);
    }
    // create a lay routine triggered by a play method that's going to play back all the commands 1 second delay
    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }

    IEnumerator PlayRoutine()
    {
        Debug.Log("Playing Started.......");
        foreach(var command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForSeconds(1.0f);
        }
    }
    // create a rewsing routine trigggered by rewind method that's going play in reverse, with a 1 second delay
    public void Rewind()
    {
        StartCoroutine(RewindRountine());
    }

    IEnumerator RewindRountine()
    {
        foreach(var command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undue();
            yield return new WaitForSeconds(1.0f);
        }
    }
    //Done=Finished with changing colors. Turn them all white
    public void Done()
    {
        var cubes = GameObject.FindGameObjectsWithTag("cube");
        foreach(var cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
    // Reset- Clear the command buffer
    public void Reset()
    {
        _commandBuffer.Clear();
    }



}
