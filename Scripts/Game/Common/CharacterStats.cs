using Godot;
using System;

public partial class CharacterStats : Node
{
    // Stores stats for all characters including player and enemies

    // Base Stats
    [Export]
    public float baseHealth { get; set; } = 10;
    [Export]
    public float baseDamage { get; set; } = 5;
    [Export]
    public float baseDefence { get; set; } = 5;
    [Export]
    public float baseSpeed { get; set; } = 100;

    // Current Stats
    float maxHealth;
    float health;
    float damage;
    float defence;
    float speed;

    public override void _Ready()
    {
        maxHealth = baseHealth;
        health = maxHealth;
        damage = baseDamage;
        defence = baseDefence;
        speed = baseSpeed;
    }

    public void TakeDamage(float damage)
    {
        this.health -= damage - 0.1f * defence;
    }
}
