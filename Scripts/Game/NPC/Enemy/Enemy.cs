using Godot;
using System;

public partial class Enemy : Node
{
    // Communicates between the enemy scripts

    CharacterStats stats;

    public override void _Ready()
    {
        stats = this.GetChildByType<CharacterStats>();

        Setup();
    }

    void Setup()
    {
        return;
    }

    public void TakeDamage(float damage)
    {
        stats.TakeDamage(damage);
    }
}
