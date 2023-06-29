using UnityEngine;

public class Pistol : Gun
{
  public override void Shoot()
  {
    Quaternion rotation = bulletSpawn.rotation;

    var newBullet = Instantiate(bullet, bulletSpawn.position, rotation);
    newBullet.Init(bulletSpawn, rotation);
  }

}
