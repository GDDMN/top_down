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

  public void Rotation(Vector2 position)
  {
    Vector2 mousePosition = position;
    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

    Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
    transform.up = direction;
  }

  public void Shoot()
  {
  }
}
