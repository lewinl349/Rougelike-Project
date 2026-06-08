using Godot;
using System;

public partial class PlayerController : CharacterBody2D
{
    // Responsible for anything player movement/input related

    float speed = 10;

    public void SetStats(float speed)
    {
        this.speed = speed;
    }

    public void GetInput()
    {
        Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
        Velocity = inputDirection * speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }
}
