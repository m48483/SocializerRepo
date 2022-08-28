using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelpManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject btn;

    public Text txt;
    int day;

    static int count;

    // Start is called before the first frame update
    void Start()
    {
        day = GameObject.Find("Variables").GetComponent<Flowchart>().GetIntegerVariable("Day");
        Debug.Log(day);
        if (day == 1)
        {
            Debug.Log("1일차입니다");
            canvas.SetActive(true);
            count = 0;
            printHelp();
        }
    }
    void printHelp()
    {
        if (count == 0)
        {
            txt.text = " 급속한 발전에 따른 유입 인구 상승으로 최근 에버트 지역 내 강력범죄 발생은 급증 추세이며, " +
                "금년 살인사건 수는 작년 동기 대비 10.4% 증가하였고, 특히 최근 한 달 강도살인치사 경우 작년 동기간 대비 110% 증가하였다.\n\n" +
                "경제공황에 따른 경제난 가중으로 2 ‧ 3계층 서민들의 민생고가 가중되어 서민들의 범죄 가담이 증가하고 있다." +
                "에버트가 시메 최대의 마약성 약물 버디(Buddy) 공급처 역할을 해 온 바, 마약 중독자들이 살인 및 강도사건 발생의 원인이 되고 있다.";
        }
        else if (count == 1)
        {
            txt.text = "이에 정보부는 에버트 내 치안 유지 방안의 일환으로 특별 조사 위원회를 조직하여 서민(2‧3 계층)들을 교정이 필요한 자들을 색출한다.\n\n" +
                "- 2계층 서민의 교육 수준이 상승함에 따라 강압적인 방법은 정치 불안과 사회적 혼란을 야기할 수 있으므로 복지 혜택 제공을 위한 상담과 같이 무해한 접근으로 진행되어야 한다.\n";
        }
        else if (count == 2)
        {
            txt.text = "- 목적달성을 위해 도청, 고문 등이 필요한 경우 이를 허가하나, 은밀히 진행해야 한다.\n\n" +
                "색출된 교정 대상들은 교정시설로 구금하고 사회 복귀가 가능하도록 교화시킨다.\n" +
                "- 반정부 세력은 키람 정신 교정소로 무기한 구금한다.";
        }
        else if (count == 3)
        {
            txt.text = "o 주요 교정 대상\n" +
                "- 약물에 심히 중독되어 생산적 활동이 불가능한 자.\n" +
                "- 사이비 종교에 심취한 자.\n" +
                "- 현 사회와 정치 체제를 부정하는 자.\n" +
                "- 극도로 폭력적이거나, 염세적 비관론에 빠져 사회 분위기를 저해하는 자.\n" +
                "- 신원이 불분명한 자.\n" +
                "- 범죄조직에 가담한 자.";
        }
        else if (count > 3)
        {
            canvas.SetActive(false);
            GameObject.Find("FC").transform.Find("Day1").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Day1_Office_Before", 1);
            GameObject.Find("FC").transform.Find("Day1").GetComponent<Flowchart>().SetFloatVariable("Dylan_reliability",
                GameObject.Find("Variables").GetComponent<Flowchart>().GetFloatVariable("Dylan_reliability"));
        }
    }
    public void clickBtn()
    {
        count++;
        printHelp();
    }
}