using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (player == true)
        {
            player.SetMoveSpeed(20);
            Destroy(this);
        }
    }
}
