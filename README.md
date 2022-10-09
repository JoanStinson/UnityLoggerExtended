# Unity Logger Extended
A custom logger for Unity with custom categories and logs only available on Editor and Development Builds.

## 🖥️ How To Disable Unity Logs on Builds
To disable Unity Logs on Release Builds and have them be available only on the Editor and Development Builds, you can do it this way:
```csharp
    private void Awake()
    {
#if DEBUG
        Debug.unityLogger.logEnabled = true;
#else
        Debug.unityLogger.logEnabled = false;
#endif
    }
```

By using Unity Logger Extended, this is automatically achieved via the Conditional Attributes located on top of each method:
```csharp
public static class Console
{
    [Conditional("DEBUG")]
    public static void Log(object message)
    {
        Debug.Log(message);
    }
}
```

Like this, none of your log calls will be executed without having to remove any code! I know, super useful right?
