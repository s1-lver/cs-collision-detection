using System.Windows.Forms.VisualStyles;
using Timer = System.Windows.Forms.Timer;

namespace collision_detection;

static class Program
{
    private static CollisionWindow _window = new CollisionWindow();
    
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Time.Start();
        Application.Run(_window);
    }

    public static void Update()
    {
        
        // window update should be last
        _window._Update();
    }
}