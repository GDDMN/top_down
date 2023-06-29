using UnityEngine;

public class Bullet : MonoBehaviour
{
  [SerializeField] private float speed;
  private Transform spawnPoint; 

  public void Init(Transform point)
  {
    spawnPoint = point;
    Move();
  }

  private void Move()
  {
    GetComponent<Rigidbody2D>().velocity = spawnPoint.forward * speed;
  }
}
