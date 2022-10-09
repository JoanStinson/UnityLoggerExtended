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

## 🖥️ How To Disable Unity Logs on Release Builds
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

You can alternatively, undefine de DEBUG symbol manually, by doing so:
```csharp
#undef DEBUG
```
