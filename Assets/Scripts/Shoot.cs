using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
   public GameObject bulletPrefab;
   public float speedBullet;

   private GameObject spawnedBullet;
   
   void CanonShoot()
   {
      Transform canonTransform = transform;
      spawnedBullet = Instantiate(bulletPrefab, canonTransform.position, canonTransform.rotation);
      spawnedBullet.GetComponent<Rigidbody>().AddForce(spawnedBullet.transform.forward * speedBullet, ForceMode.Impulse);
   }
   
   public void HandleShoot(InputAction.CallbackContext context)
   {
      Debug.Log("Shoot !");
      
      if (context.phase == InputActionPhase.Performed)
      {
         CanonShoot();
      }
   }
}