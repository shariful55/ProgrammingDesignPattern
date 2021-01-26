using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager2 : MonoBehaviour
{
    private static CommandManager2 _instance;
    public static CommandManager2 Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The CommandManager2 is Null");
            return _instance;
        }
    }
    void Awake()
    {
        _instance = this;
    }
    public List<ICommand2> _commandBuffers = new List<ICommand2>();

    public void AddCommand(ICommand2 command)
    {
        _commandBuffers.Add(command);
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }
    IEnumerator PlayRoutine()
    {
        Debug.Log("Playing start.....");
        foreach (var command in _commandBuffers)
        {
            command.Execute();
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("Playroutine finished");
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }
    IEnumerator RewindRoutine()
    {
        Debug.Log("Rewind start..");

        foreach(var command in Enumerable.Reverse(_commandBuffers))
        {
            command.Undue();
            yield return new WaitForEndOfFrame();
        }
    }

    public void Reset()
    {
        
    }



}
