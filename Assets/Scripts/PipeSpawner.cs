using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float delay = 2;

    private float timeControl = 0;
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.IsEndGame()) return;
        // Neu vuot qua 2 giay => sinh ra pipe
        timeControl += Time.deltaTime;
        if (timeControl >= delay)
        {
            timeControl = 0;
            SpawnPipe();
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = Instantiate(pipePrefab);
        pipe.transform.position += new Vector3(0, Random.Range(-2f, 2f), 0);
    }
}
