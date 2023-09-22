using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        // tanimlama ( explanation)
        var arrayList = new ArrayList() {
            10,"BTK Academy", true, 'e'
        };

        // ekleme - add
        //arrayList.Add(10); //boxing
        //arrayList.Add("BTK Academy");
        //arrayList.Add(true);
        //arrayList.Add('e');



        //dolasma 
        foreach (var e in arrayList)
        {
            Console.Write($"{e} ");
        }


        int[] numbers = new int[] { 23, 44, 55 };
        arrayList.AddRange( numbers );

        //dolasma
        Console.WriteLine();
        foreach (var e in arrayList)
        {
            Console.Write($"{e} ");
        }


        // eger bu sekilde sadece cw yazarsak bir satır altina tekrarlanan sayiyi cikti alacaktir
        // elemana erisme
        Console.WriteLine();
        Console.WriteLine(arrayList[4]);


        // elemana erisme - atama
        var x = (int)arrayList[4]; // unboxing
        Console.WriteLine(x+10);

        // eleman silme
        //arrayList.Remove(10);
        //arrayList.RemoveAt(1);
        arrayList.RemoveRange(3,3);

        //dolasma
        Console.WriteLine();
        foreach (var e in arrayList)
        {
            Console.Write($"{e} ");
        }

        Console.ReadKey();
    }
}