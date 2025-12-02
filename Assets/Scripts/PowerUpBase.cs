using UnityEngine;

public abstract class PowerUpBase 
{
    public bool IsEffectActive = false;
    public abstract void ApplyEffect(Player player);
}
