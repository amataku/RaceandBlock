using UnityEngine;
using System.Collections;

public class createScript : MonoBehaviour {
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;

    public GameObject Green1;
    public GameObject Green2;

    int x, y, z;


    int border = 1000;
    int enemyBorder = 80;


    void Update()
    {
        if (transform.position.z > border)
        {
            CreateMap();
        }
        if (transform.position.z > enemyBorder)
        {
            CreateEnemy();
        }
    }

    void CreateMap()
    {
        if (Green1.transform.position.z < border)
        {
            border += 2000;
            Vector3 temp = new Vector3(0, 0.05f, border);
            Green1.transform.position = temp;
        }
        else if (Green2.transform.position.z < border)
        {
            border += 2000;
            Vector3 temp = new Vector3(0, 0.05f, border);
            Green2.transform.position = temp;
        }
    }

    void CreateEnemy()
    {
        if (Random.Range(0, 3) == 0)
        {
            Instantiate(enemy1, new Vector3(-5f, 0f, enemyBorder + 250f), enemy1.transform.rotation);
            x = 1;
        }
        if (Random.Range(0, 3) == 0)
        {
            Instantiate(enemy2, new Vector3(-1.8f, 0f, enemyBorder + 250f), enemy2.transform.rotation);
            y = 1;
        }
        if (Random.Range(0, 3) == 0)
        {
            Instantiate(enemy3, new Vector3(1.8f, 0f, enemyBorder + 250f), enemy3.transform.rotation);
            z = 1;

        }
        if (Random.Range(0, 3) == 0)
        {
            if (x == 0 || y == 0 || z == 0)
            {
                Instantiate(enemy4, new Vector3(5f, 0f, enemyBorder + 250f), enemy4.transform.rotation);
            }
        }

        if (enemyBorder == 20000)
        {
            Instantiate(enemy5, new Vector3(3.75f, 0f, enemyBorder + 250f), enemy5.transform.rotation);
            Instantiate(enemy5, new Vector3(10.5f, 0f, enemyBorder + 250f), enemy5.transform.rotation);
            Instantiate(enemy5, new Vector3(13.5f, 0f, enemyBorder + 250f), enemy5.transform.rotation);
            Instantiate(enemy5, new Vector3(7f, 0f, enemyBorder + 250f), enemy5.transform.rotation);
        }

        enemyBorder += 80;
        x = 0;
        y = 0;
        z = 0;
    }
}
