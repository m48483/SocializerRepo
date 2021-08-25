using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class NickName : MonoBehaviour
{
    public NoticeMsg msg;
    public SceneChange _sceneChange;

    private void Start()
    {
        msg = FindObjectOfType<NoticeMsg>();
        _sceneChange = FindObjectOfType<SceneChange>();
        PlayerPrefs.DeleteAll();
        Debug.Log("prefs 초기화");
    }
    public InputField NickNameInput;

    // 한글, 영어, 숫자만 입력 가능하게
    public bool CheckNickname()
    {
        return Regex.IsMatch(NickNameInput.text, "^[0-9a-zA-Z가-힣ㄱ-ㅎ]*$");
    }
    //입력 체크
    public bool CheckInput()
    {
        return (PlayerPrefs.GetString("Name") == "");
    }
    //인풋 prefs에 저장
    public void Save()
    {
        PlayerPrefs.SetString("Name", NickNameInput.text);
    }

    public void OnClickCreateName()
    {   //입력이 있는지 체크
        if (CheckInput())
        {
            Debug.Log("이름을 입력하지 않음");
            msg.NotName();
        }
        else
        {
            Debug.Log("이름이 입력됨.");
            Debug.Log(string.Format("입력된 이름은 {0} 입니다.", PlayerPrefs.GetString("Name")));

            // 한글, 영어, 숫자로만 닉네임을 만들었는지 체크
            if (CheckNickname() == false)
            {
                Debug.Log("닉네임에 한글, 영어, 숫자를 제외한 문자를 입력함.");
                msg.ExMessage();
            }
            else
            {   //씬 전환
                _sceneChange.PopupChange();
            }
        }
        

    }
}
