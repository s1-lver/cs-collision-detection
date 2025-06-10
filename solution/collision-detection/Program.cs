using System.Windows.Forms.VisualStyles;
using Timer = System.Windows.Forms.Timer;

namespace collision_detection;

static class Program
{
    private static InputHandler _inputHandler = new();
    private static CollisionWindow _window = new CollisionWindow(_inputHandler);
    

    public static PlayerController Player = new(_inputHandler);
    
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Time.Start();
        Application.Run(_window);
    }

    public static void Update()
    {
        Player.Update();
        // window update should be last
        _window._Update();
    }
}