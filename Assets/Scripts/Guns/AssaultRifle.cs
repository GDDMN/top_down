using UnityEngine;
using System.Collections;

public class AssaultRifle : Gun
{
  public float shootingRadius;
  [Range(0, 360)]
  public float shootingAngle;

  public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
  {
    if(!angleIsGlobal)
    {
      angleInDegrees += bulletSpawn.eulerAngles.y;
    }
    return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
  }

  public override void Shoot()
  {
    float angle = Random.Range(bulletSpawn.rotation.eulerAngles.x - shootingAngle/2,
                               bulletSpawn.rotation.eulerAngles.x + shootingAngle/2);

    Quaternion rotation = Quaternion.Euler(angle,
                                           bulletSpawn.rotation.eulerAngles.y,
                                           bulletSpawn.rotation.eulerAngles.z);

    var newBullet = Instantiate(bullet, bulletSpawn.position, rotation);
    newBullet.Init(bulletSpawn, rotation);
  }
}