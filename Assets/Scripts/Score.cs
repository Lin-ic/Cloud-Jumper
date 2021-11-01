using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;

    public Text scoreText;

    // The text (Score) will display the targets position on the y axis
    void Update()
    {
             scoreText.text = player.position.y.ToString("0");
    }
}
