using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evidence : MonoBehaviour
{
    public string[] Saved_conversation = new string[3];
    public int size = 0;
    // 24개 
    public string[] _reactionaryNPC = new string[24];

    public int reactionaryNPCCount = 0;
    public void Start()
    {
        _reactionaryNPC[0] = "...(여러차례 말을 걸어보았지만 텅빈 눈으로 허공만 응시하고 있다.)";
        _reactionaryNPC[1] = "(여러차례 대화를 시도해보았지만 기분나쁜 웃음만을 흘리고 있다.)";
        _reactionaryNPC[2] = "주말에 무엇을 했냐고요?\n아침을 먹고 쇼핑을 간 후 친구와 점심 먹고 산책을 했어요.\n산책 후에는 카페에 있다가 영화관에 갔어요.\n(서류에 양식을 채울동안 너스레를 떨며 사적인 대화를 계속 했다.)\n영화관 가기 전에 뭐했냐고요? 산책했다니까요. 근데 이거 아까 물어보지 않았나요?";
        _reactionaryNPC[3] = "내 삶은 반짝반짝 황홀경 그 자체!! 시메 만세! 세상 만세!!! 어이, 내 얼굴에 벌레들을 세어봐.";
        _reactionaryNPC[4] = "이런 시시한 건 집어치우고 나랑 한 잔 하지 않을래?\n내 친구가 좋은 걸 가지고 있거든...\n근데 여긴 어디야?";
        //_reactionaryNPC[5] = "";
        //_reactionaryNPC[6] = "";
        _reactionaryNPC[7] = "당신 좀 높은 사람 맞죠? 나까지 위험해질까봐 말을 못하고 있었어요. 덩치 큰 남자가 삐쩍 마른 남자를 죽이고 있던 걸 내가 봤어요. 들킬까봐 숨까지 참고 있었는데 그 남자가 나를 어떻게 찾고 죽였을까요? 날 죽인 남자를 좀 찾아줘요.";
        _reactionaryNPC[8] = "불쌍한 나라의 종아. 쓸모없는 겉치레는 그만두고 선혈과 고통만이 가득한 곳으로 나를 보내라.\n더 큰 고통만이 연속된 죄의 굴레를 끊고 진정한 자유를 얻게한다.";
        _reactionaryNPC[9] = "진노한태양신께서우리를 부르신다.거짓으로뒤덮힌더러운왼눈을뽑아내어귀하신분을마주하라.그분께서타락한세상의파멸을원하시니온만상이불타올라잿더미가된다.최후의날에남는이는그분곁의사자들뿐이니.그분의사자가되기위해전부를내놓아라.배를갈라내장을꺼내심장을뜯어바쳐라.그렇게우리는속된연을끊고성스러운그의사자가되니우리에겐영원히태양이길을비춰줄것이다....\n(워낙 말이 빨라 적당히 알아 들을 수 있는 내용은 이것 뿐이다.)";
        _reactionaryNPC[10] = "교주께서는 전쟁통 썩어가는 시체밖에 없는 곳에서 몇날 며칠을 굶주림과 고통에 시달리며 생이 다하기 직전 그때 태양을 마주하였다. 기도 따위가 아니라 극한의 고통을 겪어야 그 분을 마주할 수 있는거다. 원래 태양에게 가까이 가기 위해선 몸이 타들어가는 고통을 감내해야하니...";
        _reactionaryNPC[11] = "신에게 용서받기 위해선 단 하나의 방법밖에 없어요. 육신을 그에게 바치는 것 밖에.";
        _reactionaryNPC[12] = "";
        _reactionaryNPC[13] = "떳떳하게 경쟁해서 위로 갈 자신감은 없나보지?";
        _reactionaryNPC[14] = "애초에 출발선이 다른데 평등하다니.";
        _reactionaryNPC[15] = "갑자기 이런 쇼를 하는 걸 보니 이 나라도 많이 급한가 보구만.";
        //_reactionaryNPC[16] = "";
        //_reactionaryNPC[17] = "";
        _reactionaryNPC[18] = "내가 그런 말을 했다고?\n그럴리가.\n...\n안했다고.";
        _reactionaryNPC[19] = "제가 그런 말을 했다고요?\n전 그런 말을 한 적이 없는데요. 착각하신 거 아닌가요?";
        _reactionaryNPC[20] = "친했던 친구가 사라졌어요. 가족까지 전부..\n그렇게 갑자기 사라질 사람이 아닌데..\n이곳저곳 물어봤지만 모두가 그들을 찾지 않아요. 그냥 없던 사람들인 것 처럼...";
        _reactionaryNPC[21] = "버디 특유의 냄새가 진동한다.";
        _reactionaryNPC[22] = "온 피부에 파먹은 듯한 상처가 가득하다.";
        _reactionaryNPC[23] = "평범하게 대화를 나누고 있지만 간간히 눈빛에서 적대감이 느껴진다.";

        for (int i = 0; i < 3; i++)
        {
            Saved_conversation[i] = " ";
        }
    }

    public void reactionaryNPCCheck()
    {
        for(int i = 0; i < 24; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if(Saved_conversation[j].Equals(_reactionaryNPC[i]))
                {
                    reactionaryNPCCount += 1;
                }
            }
        }
        Debug.Log("reactionaryNPCCount : "+ reactionaryNPCCount);
        if (reactionaryNPCCount != 3)
        {
            GameObject.Find("SayDialog").transform.Find("통과구속사살").transform.Find("ButtonGroup").transform.Find("OptionButton1").gameObject.SetActive(false);
        }
    }

    public void Evidence_ERROR()
    {

    }
    public void TextInitialization()
    {
        Saved_conversation[0] = " ";
        Saved_conversation[1] = " ";
        Saved_conversation[2] = " ";
    }
}
