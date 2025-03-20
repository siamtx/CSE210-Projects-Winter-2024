

using System.Drawing;
using System.Formats.Asn1;

public class Shape
{
    string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor()
    {
        Color = _color;
    }

    public virtual float GetArea()
    {
        return AsnReader;
    }
}