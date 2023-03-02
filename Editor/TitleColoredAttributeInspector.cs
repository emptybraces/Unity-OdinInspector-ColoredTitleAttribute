using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEngine;

public abstract class TitleColoredAttributeInspector<T> : OdinAttributeDrawer<T> where T : TitleColoredAttribute
{
	protected override void DrawPropertyLayout(GUIContent label)
	{
		GUILayout.Space(8);
		var bold_label = UnityEditor.EditorStyles.boldLabel;
		bold_label.fontSize = Attribute.Size;
		GUIHelper.PushColor(Attribute.Color);
		GUILayout.Label(Attribute.Title, bold_label);
		GUIHelper.PopColor();
		SirenixEditorGUI.HorizontalLineSeparator(Attribute.Color);
		this.CallNextDrawer(label);
	}
	protected override bool CanDrawAttributeProperty(InspectorProperty property)
	{
		return !property.UnityPropertyPath.Contains("Array");
	}
}
public sealed class TitleGreenAttributeInspector : TitleColoredAttributeInspector<TitleGreenAttribute> { }
public sealed class TitleRedAttributeInspector : TitleColoredAttributeInspector<TitleRedAttribute> { }
public sealed class TitleBlueAttributeInspector : TitleColoredAttributeInspector<TitleBlueAttribute> { }