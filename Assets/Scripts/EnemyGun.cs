using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBullet;

    //initialization
    void Start()
    {
        Invoke("FireEnemyBullet", 1f);
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
        if (playerShip != null)
        {
            GameObject bullet = (GameObject)Instantiate(EnemyBullet);

            bullet.transform.position = transform.position;

            Vector3 Direction = playerShip.transform.position - bullet.transform.position;

            bullet.GetComponent<EnemyBullet>().SetDirection(Direction);
        }
    }


}
