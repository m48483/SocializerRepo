using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Text endingTxt;
    public Text explainTxt;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Ending1")
        {
            endingTxt.text = "쓸모없는 부품";
            explainTxt.text = "GAMEOVER\n주인공은 사회에 혼란을 일으키는 것에 일조했습니다.\n주인공은 구속당하고 아이는 3계층으로 내려갔습니다.";

            Debug.Log("쓸모없는 부품");
            Debug.Log("주인공은 사회에 혼란을 일으키는 것에 일조했습니다.\n주인공은 구속당하고 아이는 3계층으로 내려갔습니다.");
            Debug.Log("게임오버");
        }
        if (SceneManager.GetActiveScene().name == "Ending2")
        {
            endingTxt.text = "사회의 일원";
            explainTxt.text = "주인공은 평범한 시민입니다.\n주인공과 아이 모두 2계급에 머뭅니다.";

            Debug.Log("사회의 일원");
            Debug.Log("주인공은 평범한 시민입니다. 주인공과 아이 모두 2계급에 머뭅니다.");
        }
        if (SceneManager.GetActiveScene().name == "Ending3")
        {
            endingTxt.text = "매뉴얼";
            explainTxt.text = "사내의 귀감이 되는 인재입니다.\n정보부원 모두 당신을 우러러봅니다.\n주인공과 아이 모두 1계층으로 올라갔습니다.";

            Debug.Log("매뉴얼");
            Debug.Log("사내의 귀감이 되는 인재입니다. 정보부원 모두 당신을 우러러봅니다. 주인공과 아이 모두 1계층으로 올라갔습니다.");
        }
        if (SceneManager.GetActiveScene().name == "Ending4")
        {
            endingTxt.text = "목이 졸리는 자는 비명를 지를 수 없다.";
            explainTxt.text = "현실적으로 어쩔 수 없는 일이었습니다.\n2계층에서 안정적으로 살 수 있게 되었습니다.";

            Debug.Log("목이 졸리는 자는 비명를 지를 수 없다.");
            Debug.Log("현실적으로 어쩔 수 없는 일이었습니다. 2계층에서 안정적으로 살 수 있게 되었습니다.");
        }
        if (SceneManager.GetActiveScene().name == "Ending5")
        {
            endingTxt.text = "멋진 신세계";
            explainTxt.text = "반역조직의 위치를 알린 공로를 인정받아 주인공과 아이 모두 1계층으로 올라갔습니다.";

            Debug.Log("멋진 신세계");
            Debug.Log("반역조직의 위치를 알린 공로를 인정받아 주인공과 아이 모두 1계층으로 올라갔습니다.");
        }
        if (SceneManager.GetActiveScene().name == "Ending6")
        {
            endingTxt.text = "소년이 온다.";
            explainTxt.text = "주인공이 준 정보로 혁명이 시작되었지만 주인공은 사살당했습니다.\n아이는 혼자 AM에남겨졌습니다.";

            Debug.Log("소년이 온다.");
            Debug.Log("주인공이 준 정보로 혁명이 시작되었지만 주인공은 사살당했습니다. 아이는 혼자 AM에남겨졌습니다.");
        }
        if (SceneManager.GetActiveScene().name == "Ending7")
        {
            endingTxt.text = "최후의 1인까지 █ █하라!";
            explainTxt.text = "부족한 정보로 혁명은 실패했습니다.\n주인공은 사살당했습니다.\n탄압이 더욱 심해집니다.";

            Debug.Log("최후의 1인까지 █ █하라!");
            Debug.Log("부족한 정보로 혁명은 실패했습니다. 주인공은 사살당했습니다. 탄압이 더욱 심해집니다.");
        }
    }
}
