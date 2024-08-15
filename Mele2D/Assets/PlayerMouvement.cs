using Fusion;
using UnityEngine;

public class PlayerMouvement : NetworkBehaviour
{
    [SerializeField] CharacterController ch;
    public float playerSpeed;

    public override void FixedUpdateNetwork()
    {
        if (HasStateAuthority == false)
        {
            return;
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * playerSpeed * Runner.DeltaTime;

        ch.Move(movement);
    }
}
