using UnityEngine;

namespace BlackOut.Utility
{
    public static class GameSpeedHelper
    {
        private static float _beforePauseTimeScale;
        public static bool IsPause => Time.timeScale == 0;
        public static void Pause()
        {
            if (IsPause) return;
            _beforePauseTimeScale = Time.timeScale;
            Time.timeScale = 0;
        }

        public static void Play()
        {
            if (!IsPause) return;
            Time.timeScale = _beforePauseTimeScale;
        }

        public static void TimeLeap(float targetTime)
        {
            if (IsPause) return;
            Time.timeScale = targetTime;
        }
    }
}
