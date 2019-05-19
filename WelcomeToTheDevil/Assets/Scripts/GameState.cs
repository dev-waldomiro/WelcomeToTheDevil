using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    private float heatLeft;
    public float maxHeat = 8f;
    private float pointCount;
    public float speed = 1;
    public bool jumpToGo;

    public PlayerControl player;
    public Text text;
    public Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerControl>();
        text = GameObject.FindWithTag("points").GetComponent<Text>();
        heatLeft = 0;
        pointCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointCount += Time.deltaTime;
        jumpToGo = player.jumpToGo;

        string pointer = pointCount.ToString("00000");
        text.text = "Pontos: " + pointer;

        if(jumpToGo == true && heatLeft < 8) {
            heatLeft += Time.deltaTime;
            slider.value = heatLeft / maxHeat;
        }
        
        if(jumpToGo == false && heatLeft > 0) {
            heatLeft -= Time.deltaTime;
            slider.value = heatLeft / maxHeat;
        }
    }
}
