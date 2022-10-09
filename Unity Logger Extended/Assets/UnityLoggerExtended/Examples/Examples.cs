using UnityEngine;
using System;
using Console = UnityEngine.Console;

public class Examples : MonoBehaviour
{
    private void Awake()
    {
        Console.Log("Hello World!");
        Console.LogFormat("Hell{0} W{1}rld!", 0, 0);

        Console.LogWarning("Hello World!");
        Console.LogWarningFormat("Hell{0} W{1}rld!", 0, 0);

        Console.LogError("Hello World!");
        Console.LogErrorFormat("Hell{0} W{1}rld!", 0, 0);

        Console.LogException(new NullReferenceException());
    }
}