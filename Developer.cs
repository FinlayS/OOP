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
}