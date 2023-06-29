using UnityEngine;

public class Bullet : MonoBehaviour
{
  [SerializeField] private float speed;
  private Transform spawnPoint;

  public void Init(Transform point, Quaternion direction)
  {
    spawnPoint = point;
    Quaternion oldDir = spawnPoint.rotation;
    spawnPoint.rotation = direction;
    GetComponent<Rigidbody2D>().velocity = spawnPoint.forward * speed;
    spawnPoint.rotation = oldDir;
  }
}
