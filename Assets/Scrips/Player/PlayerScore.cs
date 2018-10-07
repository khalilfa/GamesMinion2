using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    public float timeLeft = 120;
    public int playerScore = 0;

	void Update ()
	{
	    timeLeft -= Time.deltaTime;
	    if (timeLeft < 0.1)
	    {
            SceneManager.LoadScene("Main");
	    }
	}
}
