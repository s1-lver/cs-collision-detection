using System.Linq.Expressions;
using Timer = System.Windows.Forms.Timer;

namespace collision_detection;

public static class Time
{
    private static Timer _timer;

    public static int FPS = 60;
    public static float DeltaTime;

    static Time()
    {
        _timer = new Timer();
    }

    public static void Start()
    {
        _timer.Interval = 1000 / FPS;
        _timer.Tick += (s, e) =>
        {
            DeltaTime = _timer.Interval / 1000f;
            Program.Update();
        };
        _timer.Start();
    }
}