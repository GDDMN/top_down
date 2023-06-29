using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AssaultRifle))]
public class ShootingView : Editor
{
  void OnSceneGUI()
  {
    AssaultRifle sv = (AssaultRifle)target;
    Handles.color = Color.white;
    Handles.DrawWireArc(sv.bulletSpawn.position, sv.bulletSpawn.up, sv.bulletSpawn.forward, 360, sv.shootingRadius);
    Vector3 shootAngleA = sv.DirFromAngle(-sv.shootingAngle / 2, false);
    Vector3 shootAngleB = sv.DirFromAngle(sv.shootingAngle / 2, false);

    Vector3 angleA = new Vector3(sv.bulletSpawn.position.x + shootAngleA.x * sv.shootingRadius,
      (sv.bulletSpawn.position.z + shootAngleA.z * sv.shootingRadius) + sv.bulletSpawn.position.y);

    Vector3 angleB = new Vector3(sv.bulletSpawn.position.x + shootAngleB.x * sv.shootingRadius,
      (sv.bulletSpawn.position.z + shootAngleB.z * sv.shootingRadius) + sv.bulletSpawn.position.y);
    
    Handles.DrawLine(sv.bulletSpawn.position, angleA);
    Handles.DrawLine(sv.bulletSpawn.position, angleB);
  }

}

