using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class DataController : MonoBehaviour
{
    public int level;
    public int coin;
    public int fame;

    public float energy;
    public float hungry;
    public float muscleLoss;

    public Text LevelText;
    public Text CoinText;
    public Text FameText;

    public Text EnergyText;
    public Text HungryText;
    public Text MuscleText;

    public Image energy_bar;
    public Image hungry_bar;
    public Image muscle_bar;

    public float speed;

    public bool flag;

    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        speed = 1;
        LevelText.text = "";
        CoinText.text = "";
        FameText.text = "";

        EnergyText.text = "";
        HungryText.text = "";
        MuscleText.text = "";

        level = GameObject.Find("Player").GetComponent<PlayerData>().playerData._level;
        coin = GameObject.Find("Player").GetComponent<PlayerData>().playerData._coin;
        fame = GameObject.Find("Player").GetComponent<PlayerData>().playerData._fame;

        energy = GameObject.Find("Player").GetComponent<PlayerData>().playerData._energy;
        hungry = GameObject.Find("Player").GetComponent<PlayerData>().playerData._hungry;
        muscleLoss = GameObject.Find("Player").GetComponent<PlayerData>().playerData._muscleLoss;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            energy -= speed * Time.deltaTime;
            hungry -= speed * Time.deltaTime;
            muscleLoss += speed * Time.deltaTime;
            LevelText.text = "Level : " + level.ToString();
            CoinText.text = "Coin : " + coin.ToString();
            FameText.text = "Fame : " + fame.ToString();

            EnergyText.text = "Energy : " + ((int)energy).ToString();
            HungryText.text = "Hungry : " + ((int)hungry).ToString();
            MuscleText.text = "MuscleLoss : " + ((int)muscleLoss).ToString();

            energy_bar.fillAmount = energy / 100;
            hungry_bar.fillAmount = hungry / 100;
            muscle_bar.fillAmount = muscleLoss / 100;
        }
        else
        {
            goToHome();
        }

        if ((int)energy == 0)
        {
            EnergyText.text = isDown();
            flag = false;
        }

        if ((int)hungry == 0)
        {
            HungryText.text = isDown();
            flag = false;
        }
        if ((int)muscleLoss == 100)
        {
            MuscleText.text = isDown();
            flag = false;
        }


    }

    string isDown()
    {
        goToHome();
        return "DOWN!";
    }

    public void goToHome()
    {
        GameObject.Find("Player").transform.localPosition = new Vector3(-10, -10, 0); //���⿡ �ʿ��� ��ǥ �� �����ؼ� �����ø� �˴ϴ�.
    }
}
