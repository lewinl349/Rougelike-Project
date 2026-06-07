using Godot;
using System;

public partial class PlayerController : CharacterBody2D
{
    [Export]
    public int Speed { get; set; } = 150;

    public void GetInput()
    {
        Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
        Velocity = inputDirection * Speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }
}
