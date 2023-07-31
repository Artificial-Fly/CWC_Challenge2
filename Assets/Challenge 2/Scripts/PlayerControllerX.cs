using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool dogAvailable = true;
    /// Start is called on the frame when a script is enabled just before
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&&dogAvailable)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogAvailable = false;
            StartCoroutine(DogSpawn());
        }
        
    }

    IEnumerator DogSpawn(){
        yield return new WaitForSeconds(2.5f);
        dogAvailable = true;
    }
}
