using System;
using UnityEngine;
[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
public class TitleColoredAttribute : Attribute
{
	public string Title;
	public Color Color;
	public int Size;
	public TitleColoredAttribute(string title, Color color, int size = 12)
	{
		Title = title;
		Color = color;
		Size = size;
	}
}
public class TitleRedAttribute : TitleColoredAttribute
{
	public TitleRedAttribute(string title, int size = 12) : base(title, Color.HSVToRGB(0 / 255f, 0.15f, 1f), size) { }
}
public class TitleGreenAttribute : TitleColoredAttribute
{
	public TitleGreenAttribute(string title, int size = 12) : base(title, Color.HSVToRGB(0.3f, 0.15f, 1f), size) { }
}
public class TitleBlueAttribute : TitleColoredAttribute
{
	public TitleBlueAttribute(string title, int size = 12) : base(title, Color.HSVToRGB(0.6f, 0.15f, 1f), size) { }
}
