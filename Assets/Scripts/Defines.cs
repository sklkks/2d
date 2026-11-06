using System.Runtime.CompilerServices;

public enum Languages
{
    Korean,
    English,
    Japanese,
}

public static class DataTableIds
{
    public static readonly string[] StringTableIds =
    {
        "StringTableKr",
        "StringTableEn",
        "StringTableJp",
    };

    public static string String => StringTableIds[(int)Variables.Language];
    public static readonly string Item = "ItemTable";
    public static readonly string Charac = "CharacterTable";
    
}
public static class Variables
{
    public static event System.Action OnLanuageChanged;

    private static Languages language = Languages.English;

    public static Languages Language
    {
        get => language;
        set
        {
            if(language == value)
            {
                return;
            }
            language = value;

            DataTableManager.ChangedLanguage(language);
            OnLanuageChanged?.Invoke();
        }
    }
}