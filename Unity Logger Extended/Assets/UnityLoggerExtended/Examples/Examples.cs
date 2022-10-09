using UnityEngine;
using System;
using Console = UnityEngine.Console;

public class Examples : MonoBehaviour
{
    private void Awake()
    {
        Console.Log("Hello World!");
        Console.LogFormat("Hell{0} W{1}rld!", 0, 0);
        Console.Log("UI", "Hello World!");
        Console.LogFormat("UI", "Hell{0} W{1}rld!", 0, 0);

        Console.LogWarning("Hello World!");
        Console.LogWarningFormat("Hell{0} W{1}rld!", 0, 0);
        Console.LogWarning("Audio", "Hello World!");
        Console.LogWarningFormat("Audio", "Hell{0} W{1}rld!", 0, 0);

        Console.LogError("Hello World!");
        Console.LogErrorFormat("Hell{0} W{1}rld!", 0, 0);
        Console.LogError("Physics", "Hello World!");
        Console.LogErrorFormat("Physics", "Hell{0} W{1}rld!", 0, 0);

        Console.LogException(new NullReferenceException());
        Console.LogException("Analytics", new NullReferenceException());
    }
}