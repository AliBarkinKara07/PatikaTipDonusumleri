// See https://aka.ms/new-console-template for more information


//// Implicit Conversion

byte a = 5;
sbyte b = 6;
short c = 7;
int d = a + b + c;
Console.WriteLine("d:" + d);
///////////


long h = d;
Console.WriteLine("h:" + h);
//////////


float i = h;
Console.WriteLine("i:" + i);
/////////

string s = "Ali Barkın KARA";
char f = 'k';
object o = s + f + i;
Console.WriteLine("o:" + o);
////////

////// Explicit Conversion


int x = 4;
byte y = (byte)x;
Console.WriteLine("y:" + y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("t:" + t);

float w = 10.3f;
byte m = (byte)w;
Console.WriteLine("m:" + m);

///To String

int xx = 5;
string yy = xx.ToString();
Console.WriteLine("yy:" + yy);

string yyy = 12.5f.ToString();
Console.WriteLine("yyy:" + yyy);

string s1 = "20", s2 = "23";
int sayi1, sayi2;
int Toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

Toplam = sayi1 + sayi2;
Console.WriteLine("Toplam:" + Toplam);









