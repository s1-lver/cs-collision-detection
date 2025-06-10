namespace collision_detection;

public class InputHandler
{
    public event EventHandler<KeyEventArgs> KeyPressed;
    public event EventHandler<KeyEventArgs> KeyDown;
    public event EventHandler<KeyEventArgs> KeyUp;

    public void OnKeyPressed(KeyEventArgs e)
    {
        KeyPressed.Invoke(this, e);
    }

    public void OnKeyDown(KeyEventArgs e)
    {
        KeyDown.Invoke(this, e);
    }

    public void OnKeyUp(KeyEventArgs e)
    {
        KeyUp.Invoke(this, e);
    }
}