using System;
class Programm
{
    static void Main()
    {
        char[] symb = { 'Я', 'з', 'ы', 'к', ' ', 'С', '#' };
        Console.WriteLine("Символьный массив:");
        Console.WriteLine(symb);
        String A = new String(symb);
        Console.WriteLine("A: \"{0}\"", A);
        String B = new String(symb, 1, 5);//нужно взять 5 символов, начиная с [1] индекса символьного массива
        Console.WriteLine("B: \"{0}\"", B);
        String C = new String('s', 7);//текст будет сформирован из 7 символов 's'
        Console.WriteLine("C: \"{0}\"", C);
        A = getText('A', 'H');
        Console.WriteLine("A: \"{0}\"", A);
        B = getText('H', 'A');
        Console.WriteLine("B: \"{0}\"", B);
        C = getText(symb);
        Console.WriteLine("C: \"{0}\"", C);
        string str = "Qwerty";
        String E = String.Copy(str);//статический метод создает копию текстового объетка
        Console.WriteLine("E: \"{0}\"", E);
        E = String.Copy("123");
        Console.WriteLine("E: \"{0}\"", E);
        char[] symbs = {'q','w','e','r','t','y'};
        Console.WriteLine(symbs);
        Console.WriteLine(""+symbs);
        Console.WriteLine("{0}", symbs);
    }
    static String getText(char[] symb)
    {
        String txt = "";
        for (int i = 0; i < symb.Length; i++)
        {
            txt += symb[i];
        }
        return txt;
    }
    static String getText(char a, char b)
    {
        String txt = "";
        char s = a;
        while (s <= b)
        {
            txt += s;
            s++;
        }
        return txt;
    }
}
