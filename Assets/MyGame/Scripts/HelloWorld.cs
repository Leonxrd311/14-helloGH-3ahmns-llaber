using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("HelloWorld");
        Debug.Log(Random.Range(1, 3));
        Debug.Log("Hallo Zufall, gib mir eine Zahl zwischen 1 und 2: ");
    }  

 
    // Update is called once per frame
    void Update()
    {
        
    }
}
