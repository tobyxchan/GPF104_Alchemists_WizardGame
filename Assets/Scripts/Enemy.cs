using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int enemyHealth = 9; //enemy health

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;
        Debug.Log("enemy took damage");

        if(enemyHealth <=0)
        {
            Die();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
