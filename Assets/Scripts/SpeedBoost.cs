using UnityEngine;

public class SpeedBoost : PowerUpBase
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
