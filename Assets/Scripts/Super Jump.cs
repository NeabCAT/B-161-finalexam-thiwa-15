using UnityEngine;

public class SuperJump : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (player == true)
        {
            player.SetSuperJump(10);
            Destroy(this);
        }
    }
}
