using UnityEngine;

public class ActorMovements : MonoBehaviour
{
  [SerializeField] private float speed;

  public void Move(Vector2 direction)
  {
    float scaledMoveSpeed = speed * Time.deltaTime;
    Vector3 moveDirection = new Vector3(direction.x, direction.y, 0);
    transform.position += moveDirection * scaledMoveSpeed;
  }

  public void Shoot()
  {
  }
}
