using UnityEngine;

public enum CharTypes
{
    charac1,
    charac2,
    charac3,
    charac4,
}
public class CharData
{
    public string Id {get; set;}
    public string Name	{get; set;}
    public int Hp	{get; set;}
    public int Atk	{get; set;}
    public int Def	{get; set;}
    public int Speed	{get; set;}
    public string Icon {get; set;}
    public string StringName => DataTableManager.StringTable.Get(Name);
    
    public Sprite SpriteIcon => Resources.Load<Sprite>($"Icon/{Icon}");
}
