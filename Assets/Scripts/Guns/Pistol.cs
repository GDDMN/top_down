public class Pistol : Gun
{
  public override void Shoot()
  {
    var newBullet = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
    newBullet.Init(bulletSpawn);
  }

}
