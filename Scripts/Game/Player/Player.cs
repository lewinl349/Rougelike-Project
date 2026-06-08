using Godot;
using System;

public partial class Player : Node
{
    // Communicates between the player scripts

    CharacterStats stats;
    PlayerController controller;

    public override void _Ready()
    {
        stats = this.GetChildByType<CharacterStats>();
        controller = this.GetChildByType<PlayerController>();

        Setup();
    }

    void Setup()
    {
        // TODO: Add this to an event handler
        controller.SetStats(stats.baseSpeed);    
    }

    public void TakeDamage(float damage)
    {
        stats.TakeDamage(damage);
    }
}
