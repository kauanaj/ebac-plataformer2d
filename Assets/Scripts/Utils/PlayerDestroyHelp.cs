using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyHelp : MonoBehaviour
{
    public Player player;

    public void KillPlayer()
    {
        player.DestroyMe();
    }
}
