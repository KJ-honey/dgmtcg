using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

    public static List<Card> cardList = new List<Card> ();

    void Awake()
    {
        /*cardList.Add (new Card (0, "MissingNum", 0, 0, "None"));
        cardList.Add (new Card (1, "Agumon", 2, 350, "It is Agumon"));
        cardList.Add (new Card (2, "Piyomon", 2, 300, "어리광쟁이"));
        cardList.Add (new Card (3, "Greymon", 3, 470, "아구몬이 진화한 디지몬"));
        cardList.Add (new Card (4, "Budramon", 3, 400, "하늘을 지배하는 불꽃의 날개"));
        */
        cardList.Add (new Card ("MY", 0, "테스트testテスト", "WhiteOrBlack"));
        cardList.Add (new digitamaCard ("BT1",1,"표코몬","red","상대의 디지몬이 어택했을 때, 이 턴 동안 이 디지몬의 DP를 +1000한다."));
        cardList.Add (new digimonCard ("BT1",9,"모노드라몬","red",2,"-",0,"red",2,3,3000,"-"));
        cardList.Add (new tamerCard("BT1",85,"야가미 타이치","red",4,"메모리가 2이하일 때 3으로 한다.","이 카드를 코스트를 지불하지 않고 등장시킨다."));
        
        //Console.WriteLine(cardList[0].pack);
    }
}