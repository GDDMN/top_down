using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private PlayerInput playerInput;
  private ActorMovements actorMovements;

  private void Awake()
  {
    playerInput = new PlayerInput();
    actorMovements = gameObject.GetComponent<ActorMovements>();
  }

  private void OnEnable()
  {
    playerInput.Enable();
  }

  private void OnDisable()
  {
    playerInput.Disable();
  }

  private void Start()
  {
    playerInput.Player.Shoot.started += context => actorMovements.Shoot();
    playerInput.Player.Shoot.canceled += context => actorMovements.StopShooting();
  }

  private void Update()
  {
    Vector2 direction = playerInput.Player.Move.ReadValue<Vector2>();
    Vector2 rotationDirection = playerInput.Player.Rotation.ReadValue<Vector2>();
    actorMovements.Move(direction);
    actorMovements.Rotation(rotationDirection);
  }
}
