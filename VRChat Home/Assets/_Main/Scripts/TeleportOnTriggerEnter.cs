using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

public class TeleportOnTriggerEnter : UdonSharpBehaviour
{
    [SerializeField] private Transform teleportTarget;

    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        player.TeleportTo(teleportTarget.position, teleportTarget.rotation);
    }
}
