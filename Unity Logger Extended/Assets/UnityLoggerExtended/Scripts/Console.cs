using System;
using System.Diagnostics;

namespace UnityEngine
{
    public static class Console
    {
        [Conditional("DEBUG")]
        public static void Log(object message)
        {
            Debug.Log(message);
        }

        [Conditional("DEBUG")]
        public static void LogFormat(string format, params object[] args)
        {
            Debug.LogFormat(format, args);
        }

        [Conditional("DEBUG")]
        public static void LogWarning(object message)
        {
            Debug.LogWarning(message);
        }

        [Conditional("DEBUG")]
        public static void LogWarningFormat(string format, params object[] args)
        {
            Debug.LogWarningFormat(format, args);
        }

        [Conditional("DEBUG")]
        public static void LogError(object message)
        {
            Debug.LogError(message);
        }

        [Conditional("DEBUG")]
        public static void LogErrorFormat(string format, params object[] args)
        {
            Debug.LogErrorFormat(format, args);
        }

        [Conditional("DEBUG")]
        public static void LogException(Exception exception)
        {
            Debug.LogException(exception);
        }
    }
}