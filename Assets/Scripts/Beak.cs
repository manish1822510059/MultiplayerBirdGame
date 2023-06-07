using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beak : MonoBehaviour
{

private void OnTriggerEnter(Collider other)
{
    Players players = other.gameObject.GetComponent<Players>();
    if(players)
    {
        int damage = 10;
        players.TakeDamage(damage);
        players.hpBarUi.Attack(damage);
    }
}

}
