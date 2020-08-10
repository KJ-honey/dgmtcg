using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public string pack;
    public int id;
    public string cardName;

    public string color;
    public Card(string Pack, int Id, string CardName, string Color)
    {
        pack = Pack;
        id = Id;
        cardName = CardName;
        color = Color;
    }

}
public class digitamaCard : Card
{
    public string evolutionEffect;
    public digitamaCard(string Pack, int Id, string CardName, string Color, string EvolutionEffect) : base(Pack,Id,CardName,Color)
    {
        evolutionEffect = EvolutionEffect;
    }
}
public class notDigitamaCard : Card
{
    public int appearCost;
    public string effect;
    public notDigitamaCard(string Pack, int Id, string cardName, string Color, int AppearCost, string Effect) : base(Pack,Id,cardName,Color)
    {
        appearCost = AppearCost;
        effect = Effect;
    }
}
public class notDigimonCard : notDigitamaCard
{
    public string securityEffect;
    public notDigimonCard (string Pack,
                           int Id,
                           string cardName,
                           string Color,
                           int AppearCost,
                           string Effect,
                           string SecurityEffect) : base(Pack,Id,cardName,Color,AppearCost,Effect)
    {
        securityEffect = SecurityEffect;
    }

}

public class digimonCard : notDigitamaCard
{
    public int evolutionCost;
    public string evolutionColor;
    public int evolutionLv;
    public int lv;
    public int dp;
    public string evolutionEffect;    
    public digimonCard (string Pack,
                        int Id,
                        string cardName,
                        string Color,
                        int AppearCost,
                        string Effect,
                        int EvolutionCost,
                        string EvolutionColor,
                        int EvolutionLv,
                        int Lv,
                        int Dp,
                        string EvolutionEffect) : base(Pack,Id,cardName,Color,AppearCost,Effect)
    {
        evolutionCost = EvolutionCost;
        evolutionColor = EvolutionColor;
        evolutionLv = EvolutionLv;
        lv = Lv;
        dp = Dp;
        evolutionEffect = EvolutionEffect;
    }

}

public class tamerCard : notDigimonCard
{
    public tamerCard (string Pack,
                           int Id,
                           string cardName,
                           string Color,
                           int AppearCost,
                           string Effect,
                           string SecurityEffect) : base(Pack,Id,cardName,Color,AppearCost,Effect,SecurityEffect)
    {

    }
}

public class optionCard : notDigimonCard
{
    public optionCard (string Pack,
                           int Id,
                           string cardName,
                           string Color,
                           int AppearCost,
                           string Effect,
                           string SecurityEffect) : base(Pack,Id,cardName,Color,AppearCost,Effect,SecurityEffect)
    {

    }
}