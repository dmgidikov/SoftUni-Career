﻿// Axe durability drop with 5 
public class Axe
{
    private int attackPoints;
    private int durabilityPoints;

    public Axe(int attack, int durability)
    {
        this.attackPoints = attack;
        this.durabilityPoints = durability;
    }

    public int AttackPoints
    {
        get => this.attackPoints;
        set => this.attackPoints = value;
    }

    public int DurabilityPoints
    {
        get => this.durabilityPoints;
        set => this.durabilityPoints = value;
    }

    public void Attack(Dummy target)
    {
        if (this.durabilityPoints <= 0)
        {
            throw new InvalidOperationException("Axe is broken.");
        }

        target.TakeAttack(this.attackPoints);
        this.durabilityPoints -= 1;
    }
}