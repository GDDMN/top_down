using System.Collections;
using UnityEngine;

public class Pistol : Gun
{
  [SerializeField] private float rateOfFire;
  private float time = 1f;
  private bool shooting = false;

  public override void Shoot()
  {
    shooting = true;
  }

  private void Update()
  {
    if (shooting)
      Shooting();
  }

  private void Shooting()
  {
    if (time < 1f)
    {
      time += rateOfFire * Time.deltaTime;
      return;
    }

    time = 0f;

    Quaternion rotation = bulletSpawn.rotation;

    var newBullet = Instantiate(bullet, bulletSpawn.position, rotation);
    newBullet.Init(bulletSpawn, rotation);
  }

  public override void StopShooting()
  {
    shooting = false;
    time = 1f;
  }
}
