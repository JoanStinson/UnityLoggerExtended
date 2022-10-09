using System;
using System.Diagnostics;

namespace UnityEngine
{
    public static class Console
    {
        private const string infoColor = nameof(Color.white);
        private const string warningColor = nameof(Color.yellow);
        private const string errorColor = nameof(Color.red);

        private static string FormatMessage(string color, object message)
        {
            return $"<color={color}>{message}</color>";
        }

        private static string FormatMessageWithCategory(string color, string category, object message)
        {
            return $"<color={color}><b>[{category}]</b> {message}</color>";
        }

        [Conditional("DEBUG")]
        public static void Log(object message)
        {
            string messageToDisplay = $"<color=white>{message}</color>";
            Debug.Log(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void Log(string category, object message)
        {
            string messageToDisplay = $"<color=white><b>[{category}]</b> {message}</color>";
            Debug.Log(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogFormat(string format, params object[] args)
        {
            string messageToDisplay = $"<color=white>{string.Format(format, args)}</color>";
            Debug.Log(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogFormat(string category, string format, params object[] args)
        {
            string messageToDisplay = $"<color=white><b>[{category}]</b> {string.Format(format, args)}</color>";
            Debug.Log(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogWarning(object message)
        {
            string messageToDisplay = $"<color=yellow>{message}</color>";
            Debug.LogWarning(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogWarning(string category, object message)
        {
            string messageToDisplay = $"<color=yellow><b>[{category}]</b> {message}</color>";
            Debug.LogWarning(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogWarningFormat(string format, params object[] args)
        {
            string messageToDisplay = $"<color=yellow>{string.Format(format, args)}</color>";
            Debug.LogWarningFormat(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogWarningFormat(string category, string format, params object[] args)
        {
            string messageToDisplay = $"<color=yellow><b>[{category}]</b> {string.Format(format, args)}</color>";
            Debug.LogWarningFormat(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogError(object message)
        {
            string messageToDisplay = $"<color=red>{message}</color>";
            Debug.LogError(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogError(string category, object message)
        {
            string messageToDisplay = $"<color=red><b>[{category}]</b> {message}</color>";
            Debug.LogError(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogErrorFormat(string format, params object[] args)
        {
            string messageToDisplay = $"<color=red>{string.Format(format, args)}</color>";
            Debug.LogErrorFormat(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogErrorFormat(string category, string format, params object[] args)
        {
            string messageToDisplay = $"<color=red><b>[{category}]</b> {string.Format(format, args)}</color>";
            Debug.LogErrorFormat(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogException(Exception exception)
        {
            string messageToDisplay = $"<color=red>{exception.Message}</color>";
            Debug.LogError(messageToDisplay);
        }

        [Conditional("DEBUG")]
        public static void LogException(string category, Exception exception)
        {
            string messageToDisplay = $"<color=red><b>[{category}]</b> {exception.Message}</color>";
            Debug.LogError(messageToDisplay);
        }
    }
}