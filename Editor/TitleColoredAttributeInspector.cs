using Sirenix.Utilities.Editor;
using UnityEngine;

namespace Sirenix.OdinInspector.Editor
{
	public abstract class TitleColoredAttributeInspector<T> : OdinAttributeDrawer<T> where T : TitleColoredAttribute
	{
		protected override void DrawPropertyLayout(GUIContent label)
		{
			GUILayout.Space(8);
			var bold_label = SirenixGUIStyles.BoldTitle;
			var size = bold_label.fontSize;
			bold_label.fontSize = Attribute.Size;
			GUIHelper.PushColor(Attribute.Color);
			// SirenixEditorGUI.Title(Attribute.Title, "", TextAlignment.Left, true, true);
			GUILayout.Label(Attribute.Title,  bold_label);
			GUIHelper.PopColor();
			SirenixEditorGUI.HorizontalLineSeparator(Attribute.Color);
			bold_label.fontSize = size;
			this.CallNextDrawer(label);
		}
	}
	[DrawerPriority(2, 0, 0)]
	public sealed class TitleGreenAttributeInspector : TitleColoredAttributeInspector<TitleGreenAttribute> { }
	[DrawerPriority(2, 0, 0)]
	public sealed class TitleRedAttributeInspector : TitleColoredAttributeInspector<TitleRedAttribute> { }
	[DrawerPriority(2, 0, 0)]
	public sealed class TitleBlueAttributeInspector : TitleColoredAttributeInspector<TitleBlueAttribute> { }
}