using UnityEngine;
using System.Collections;

public class EnemyGun:MonoBehaviour
{
    public GameObject EnemyBulletGO;

    //initialization
    void Start()
    {
        Invoke("FireEnemyBullet",1f);
    }
    //Update once per frame
    void Update()
    {

    }


    //function to fire a bullet
    void FireEnemyBullet()
    {
        //Get a refrence to player ship
        GameObject playerShip = GameObject.Find("player_ship");
        if(playerShip !=null)
        {
            GameObject bullet = (GameObject)Instantiate(EnemyBulletGO);

            bullet.transform.position = transform.position;

            Vector2 Direction = playerShip.transform.position - bullet.transform.position;

            bullet.GetComponent<EnemyBullet>().SetDirection(direction );
        }
    }


}
