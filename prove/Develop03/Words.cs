public class Words
{
    private string _text;
    private bool _isHidden;

    public Words(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden => _isHidden;

    public void Hide()
    {
        _isHidden = true;
    }

    public void ShowPartialHint()
    {
        if (_isHidden)
        {
            _isHidden = false;
        }
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
