using System;
using System.Diagnostics;

namespace UnityEngine
{
    public static class Console
    {
        private const string infoColor = nameof(Color.white);
        private const string warningColor = nameof(Color.yellow);
        private const string errorColor = nameof(Color.red);

        [Conditional("DEBUG")]
        public static void Log(object message)
        {
            Debug.Log(FormatMessage(infoColor, message));
        }

        [Conditional("DEBUG")]
        public static void Log(string category, object message)
        {
            Debug.Log(FormatMessageWithCategory(infoColor, category, message));
        }

        [Conditional("DEBUG")]
        public static void LogFormat(string format, params object[] args)
        {
            Debug.Log(FormatMessage(infoColor, string.Format(format, args)));
        }

        [Conditional("DEBUG")]
        public static void LogFormat(string category, string format, params object[] args)
        {
            Debug.Log(FormatMessageWithCategory(infoColor, category, string.Format(format, args)));
        }

        [Conditional("DEBUG")]
        public static void LogWarning(object message)
        {
            Debug.LogWarning(FormatMessage(warningColor, message));
        }

        [Conditional("DEBUG")]
        public static void LogWarning(string category, object message)
        {
            Debug.LogWarning(FormatMessageWithCategory(warningColor, category, message));
        }

        [Conditional("DEBUG")]
        public static void LogWarningFormat(string format, params object[] args)
        {
            Debug.LogWarningFormat(FormatMessage(warningColor, string.Format(format, args)));
        }

        [Conditional("DEBUG")]
        public static void LogWarningFormat(string category, string format, params object[] args)
        {
            Debug.LogWarningFormat(FormatMessageWithCategory(warningColor, category, string.Format(format, args)));
        }

        [Conditional("DEBUG")]
        public static void LogError(object message)
        {
            Debug.LogError(FormatMessage(errorColor, message));
        }

        [Conditional("DEBUG")]
        public static void LogError(string category, object message)
        {
            Debug.LogError(FormatMessageWithCategory(errorColor, category, message));
        }

        [Conditional("DEBUG")]
        public static void LogErrorFormat(string format, params object[] args)
        {
            Debug.LogErrorFormat(FormatMessage(errorColor, string.Format(format, args)));
        }

        [Conditional("DEBUG")]
        public static void LogErrorFormat(string category, string format, params object[] args)
        {
            Debug.LogErrorFormat(FormatMessageWithCategory(errorColor, category, string.Format(format, args)));
        }

        [Conditional("DEBUG")]
        public static void LogException(Exception exception)
        {
            Debug.LogError(FormatMessage(errorColor, exception.Message));
        }

        [Conditional("DEBUG")]
        public static void LogException(string category, Exception exception)
        {
            Debug.LogError(FormatMessageWithCategory(errorColor, category, exception.Message));
        }

        private static string FormatMessage(string color, object message)
        {
            return $"<color={color}>{message}</color>";
        }

        private static string FormatMessageWithCategory(string color, string category, object message)
        {
            return $"<color={color}><b>[{category}]</b> {message}</color>";
        }
    }
}