
using System.Text.RegularExpressions;
using System.Windows.Forms;

class Util
{

    public static string title = "Video Place";

    public static string removeSpaces(string data)
    {
        data = data.Trim();
        data = Regex.Replace(data, @"\s+", " ");
        return data;

    }
    public static void cleanfields(ref TextBox text, ref TextBox text2, ref TextBox text3)
    {
        text.Clear();
        text2.Clear();
        text3.Clear();
    }
    public static void cleanfields(ref TextBox text, ref ComboBox cb1, ref TextBox text3, ref TextBox text4, ref TextBox text5)
    {
        text.Clear();
        cb1.SelectedIndex = 25;
        text3.Clear();
        text4.Clear();
        text5.Clear();
    }
    public static void cleanfields1(ref TextBox text, ref ComboBox cb1, ref TextBox text3, ref TextBox text4, ref TextBox text5)
    {
        text.Clear();
        cb1.Text = "";
        text3.Clear();
        text4.Clear();
        text5.Clear();
    }






}

