using Timer = System.Windows.Forms.Timer;

namespace collision_detection;

public partial class CollisionWindow : Form
{
    private static InputHandler _inputHandler;
    public CollisionWindow(InputHandler inputHandler)
    {
        _inputHandler = inputHandler;
        InitializeComponent();
    }

    public void _Update()
    {
        Invalidate();
    }

    public void CollisionWindow_Paint(object s, PaintEventArgs e)
    {
        // rendering will go here
    }

    public void CollisionWindow_KeyDown(object s, KeyEventArgs e)
    {
        _inputHandler.OnKeyDown(e);
    }

    public void CollisionWindow_KeyUp(object s, KeyEventArgs e)
    {
        _inputHandler.OnKeyUp(e);
    }
}
