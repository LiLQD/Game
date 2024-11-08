namespace BTVN;

public class Bai2
{
    public static bool kiemTra(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;
        int ngoacTron = 0;
        int ngoacVuong = 0;
        int ngoacNhon = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '(') ngoacTron++;
            
            else if (c == ')')
            {
                ngoacTron--;
                if (ngoacTron < 0) return false;
            }
            
            else if (c == '[')
                ngoacVuong++;
            else if (c == ']')
            {
                ngoacVuong--;
                if (ngoacVuong < 0) return false;
            }
            
            else if (c == '{') ngoacNhon++;
            else if (c == '}')
            {
                ngoacNhon--;
                if (ngoacNhon < 0) return false;
            }
        }
        return ngoacTron == 0 && ngoacVuong == 0 && ngoacNhon == 0;
    }
}