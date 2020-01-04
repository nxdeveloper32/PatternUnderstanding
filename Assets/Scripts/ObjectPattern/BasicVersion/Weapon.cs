﻿using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public void Attack(Target target)
    {
        DoAttack(target);
    }
    protected abstract void DoAttack(Target target);
    protected virtual string DamageMessage() { return "Hit"; }
}
