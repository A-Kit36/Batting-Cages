using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/BatterStats", order = 1)]
public class BatterStats : ScriptableObject
{
    public string BatterName;

    public float AtBats;
    public float Singles;
    public float Doubles;
    public float Triples;
    public float Homeruns;
    public float Walks;
    public float StrikeOuts;
    public float HitOut;
}