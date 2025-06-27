using DevExpress.XtraEditors;

/// <summary>
/// Adds a grey placeholder that vanishes on focus/typing.
/// </summary>


public static class TextEditPlaceholderExtensions
{

    public static void SetPlaceholder(this TextEdit editor, string prompt)
    {
        var p = editor.Properties;
        p.NullValuePrompt = prompt;
        p.ShowNullValuePrompt = ShowNullValuePromptOptions.EmptyValue;
  
    }
}