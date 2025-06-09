using Timer = System.Windows.Forms.Timer;

namespace collision_detection;

public partial class CollisionWindow : Form
{
    public CollisionWindow()
    {
        InitializeComponent();
    }

    public void _Update()
    {
        Invalidate();
        Console.WriteLine(Time.DeltaTime);
    }

    public void CollisionWindow_Paint(object s, PaintEventArgs e)
    {
        // rendering will go here
    }
}
