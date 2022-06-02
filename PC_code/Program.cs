using System.Collections.Generic;
using PC_code;

Draw();

List<char> _lowlet = new List<char>();
_lowlet.AddRange("abcdefghijklmnopqrstuvwxyz");

List<char> _caplet = new List<char>();
_caplet.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

List<char> _sign = new List<char>();
_sign.AddRange("-'^*~@/!#$%&");

List<char> _numbers = new List<char>();
_numbers.AddRange("1234567890");

void Draw()
{
    //Console.SetWindowSize(1000, 1000);
    Hentai.PictureOne();
    Hentai.PictureTwo();
}