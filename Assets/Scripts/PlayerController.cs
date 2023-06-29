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
    
  }

  private void Update()
  {
    Vector2 direction = playerInput.Player.Move.ReadValue<Vector2>();
    actorMovements.Move(direction);
  }
}
