using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TakeToMenu());
    }

    // Update is called once per frame
     IEnumerator TakeToMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
    
}
