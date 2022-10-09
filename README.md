# Unity Logger Extended
A custom logger for Unity with custom categories and logs only available on Editor and Development Builds.

<p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
    <img alt="License" src="https://img.shields.io/github/license/JoanStinson/UnityLoggerExtended?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/JoanStinson/UnityLoggerExtended?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/JoanStinson/UnityLoggerExtended?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/JoanStinson/UnityLoggerExtended/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/JoanStinson/UnityLoggerExtended?include_prereleases&logo=Dropbox&color=yellow">
  </a>
</p>

<p align="center">
  <img src="https://github.com/JoanStinson/UnityLoggerExtended/blob/main/preview.PNG">
</p>

## 🖥️ How It Works
There's a Console class, which basically serves as a wrapper of Unity's Debug class for logs. Each log type (info, warning, error) has it's own custom color and you can decide to define a category for each one (which will appear in bold in front). 

Furthermore, this system lets you define custom categories on the fly, with no need to maintain any Enums or Scriptable Objects. Just pass in the category before the log message and whoala!

### Example Usage:
```csharp
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
```
The best approach for me, would be to have a static class with all your custom category const strings (to avoid harcoded strings!).

### Output:
<p align="center">
  <img src="https://github.com/JoanStinson/UnityLoggerExtended/blob/main/output.PNG">
</p>

### Fast Log Filtering:
<p align="center">
  <img src="https://github.com/JoanStinson/UnityLoggerExtended/blob/main/search.gif">
</p>

## 📵 How To Disable Logs on Release Builds
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

Alternatively, you can undefine the DEBUG symbol manually, by doing so:
```csharp
#undef DEBUG
```
