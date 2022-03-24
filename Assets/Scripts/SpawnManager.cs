using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _NPC;
    [SerializeField] private bool _isGameOn = false;

    // Start is called before the first frame update
    void Start()
    {
        _isGameOn = true;
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner()
    {
        while(_isGameOn == true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(_NPC[Random.Range(0, _NPC.Length)], transform.position, Quaternion.identity);
        }
    }
}
