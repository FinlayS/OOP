using System;

public abstract class Developer
{
    private string _mainDevLanguage;
    public Developer(string mainDevLanguage)
    {
        this._mainDevLanguage = mainDevLanguage;
    }

    public virtual void Code()
    {
        Console.WriteLine(string.Format("I'm developing with {0}", this._mainDevLanguage));
    }

    public virtual void Code(string extraDevLanguage)
    {
        Console.WriteLine(string.Format("I'm developing with {0} and additionally with {1}", this._mainDevLanguage, extraDevLanguage));
    }

    public virtual void Code(string firstExtraDevLanguage, string secondExtraDevLanguage)
    {
        Console.WriteLine(string.Format("I'm developing with {0} and additionally with {1} and {2}", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLanguage));
    }
}