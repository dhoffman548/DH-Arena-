using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    Collision myCollision;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            myCollision = collision;
            Destroy(this.gameObject);
            Debug.Log("Item collected!");
            if (this.gameObject.name == "Cuba_Pickup")
            {
                collision.gameObject.GetComponent<PlayerBehavior>().moveSpeed *= 1.5f;
                collision.gameObject.GetComponent<PlayerBehavior>().Invoke("decreasedMovementSpeed", 3.0f);
            }
            if (this.gameObject.name == "Jamaica_Pickup")
            {
                collision.gameObject.GetComponent<Renderer>().material = Resources.Load("Enemy_Mat", typeof(Material)) as Material;
                collision.gameObject.GetComponent<PlayerBehavior>().Invoke("resetMaterial", 6.0f);
            }
        }

    }
    
}
