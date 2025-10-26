using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class collectCoints : MonoBehaviour
{
    int score = 0;
    public int winScore;

    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            score++;

            if(score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}
