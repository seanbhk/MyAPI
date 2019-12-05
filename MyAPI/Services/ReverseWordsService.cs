using System;
namespace MyAPI.Services
{
    public class ReverseWordsService
    {
        private string _sentence = "";
        public ReverseWordsService(string s)
        {
            _sentence = s;
        }

        public string reverse()
        {
            if(_sentence.Length > 2)
            {
                return _sentence;
            }
            else
            {
                char[] sArray = _sentence.ToCharArray();
                Array.Reverse(sArray);
                return new string(sArray);
            }
        }
    }
}
