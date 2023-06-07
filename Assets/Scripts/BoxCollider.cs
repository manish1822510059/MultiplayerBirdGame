 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollider : MonoBehaviour
{

public HpBarUi hpBarUi;
    // Start is called before the first frame update
 private void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag =="Enemy"){
                hpBarUi.Attack(10);
                print("hit enemy");
    }
    
}

}
