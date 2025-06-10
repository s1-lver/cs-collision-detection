using System.Numerics;

namespace collision_detection;

public class PlayerController
{
    private InputHandler _inputHandler;
    private HashSet<Keys> _keysPressed = new();
    
    public Vector2 Position = Vector2.Zero;
    public Vector2 MoveDirection = Vector2.Zero;
    public float MoveSpeed = 1.0f;

    public PlayerController(InputHandler inputHandler)
    {
        _inputHandler = inputHandler;
        _inputHandler.KeyDown += (s, e) =>
        {
            _keysPressed.Add(e.KeyCode);
        };
        _inputHandler.KeyUp += (s, e) =>
        {
            _keysPressed.Remove(e.KeyCode);
        };
    }

    public bool CheckInput(Keys keyCode)
    {
        return _keysPressed.Contains(keyCode);
    }

    public void Update()
    {
        if (CheckInput(Keys.Left))
        {
            MoveDirection.X = -1;
        } else if (CheckInput(Keys.Right))
        {
            MoveDirection.X = 1;
        }
        else
        {
            MoveDirection.X = 0;
        }

        if (CheckInput(Keys.Up))
        {
            MoveDirection.Y = -1;
        } else if (CheckInput(Keys.Down))
        {
            MoveDirection.Y = 1;
        }
        else
        {
            MoveDirection.Y = 0;
        }
        
        Position += MoveDirection * MoveSpeed * Time.DeltaTime;
        Console.WriteLine(Position);
    }
}