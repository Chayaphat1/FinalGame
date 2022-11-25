using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TakeToMenu());
    }

    // Update is called once per frame
     IEnumerator TakeToMenu()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
    
}
