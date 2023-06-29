using System.Collections;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
  public Bullet bullet;
  public Transform bulletSpawn;

  public abstract void Shoot();
  public abstract void StopShooting();
}
