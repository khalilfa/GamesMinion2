using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEffect : MonoBehaviour {
    public int cantPoints = 10;

    public void ExecuteEfect(GameObject player)
    {
        player.gameObject.GetComponent<PlayerScore>().playerScore += cantPoints;
        Destroy(gameObject);
    }
}
