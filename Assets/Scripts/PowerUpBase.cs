using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    public bool IsEffectActive = false;
    public abstract void ApplyEffect(Player player);
}
