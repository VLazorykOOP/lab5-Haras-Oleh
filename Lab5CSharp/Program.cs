using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//перше завдання
namespace laboratorna_robota5
{
public class Detal
{protected string vurobnik { get; set; }
public Detal(string vurobnik)
{
this.vurobnik = vurobnik;
}
public void Show()
{
Console.WriteLine("Функцiя Show:");
Console.WriteLine($"Деталь: {vurobnik}");
}
}
public class Mehanizm : Detal
{
protected string skladnist { get; set; }
protected string kraina { get; set; }
public Mehanizm(string vurobnik, string skladnist, string kraina) : base(vurobnik)
{
this.vurobnik = vurobnik;
this.skladnist = skladnist;
this.kraina = kraina;
}
public void Show()
{
Console.WriteLine("Функцiя Show:");
Console.WriteLine($"Виробник: {this.vurobnik}");
Console.WriteLine($"Складність: {this.skladnist}");
Console.WriteLine($"Країна: {this.kraina}");
}
}
public class Vurib : Mehanizm
{
protected int riven { get; set; }
public Vurib(string vurobnik, string skladnist, string kraina, int riven) : base(vurobnik, skladnist, kraina)
{
this.riven = riven;
this.vurobnik = vurobnik;
this.skladnist = skladnist;
this.kraina = kraina;
}
public void Show()
{ Console.WriteLine("Функцiя Show:");
Console.WriteLine($"Виробник: {this.vurobnik}");
Console.WriteLine($"Складність: {this.skladnist}");
Console.WriteLine($"Країна: {this.kraina}");
Console.WriteLine($"Рівень: {this.riven}");
}
}
public class Vuzol : Mehanizm
{
protected string stupin { get; set; }
 public Vuzol(string vurobnik, string skladnist, string kraina, string stupin) : base(vurobnik, skladnist, kraina)
{
this.stupin = stupin;
this.vurobnik = vurobnik;
this.skladnist = skladnist;
this.kraina = kraina;
}
public void Show()
{
Console.WriteLine("Функцiя Show:");
Console.WriteLine($"Виробник: {this.vurobnik}");
Console.WriteLine($"Складність: {this.skladnist}");
Console.WriteLine($"Країна: {this.kraina}");
Console.WriteLine($"Ступінь: {this.stupin}");
}
}
}

//друге завдання
namespace laboratorna_robota5
{public class Detal2
{protected string vurobnik { get; set; }
~Detal2()
{
Console.WriteLine("ДЕСТРУКЦІЯ!!!");
}
public Detal2(string vurobnik)
{
this.vurobnik = vurobnik;
}
public Detal2()
{
this.vurobnik = "пустота..";
}
public Detal2(int a)
{
this.vurobnik = a.ToString();
}       
public void Show()
{
Console.WriteLine("Функцiя 'Show':");
Console.WriteLine($"Виробник: {vurobnik}");
}
}
 public class Mehanizm2 : Detal2
{protected string skladnist { get; set; }
protected string kraina { get; set; }
~Mehanizm2()
{
Console.WriteLine("ДЕСТРУКЦІЯ!!!");
}
public Mehanizm2(string vurobnik, string skladnist, string kraina) : base(vurobnik)
{
this.vurobnik = vurobnik;
this.skladnist = skladnist;
this.kraina = kraina;
}
public Mehanizm2(string vurobnik) : base(vurobnik)
{
this.vurobnik = vurobnik;
this.skladnist = "пустота...";
this.skladnist = "пустота...";
}
public Mehanizm2(string skladnist, string kraina)
{
this.vurobnik = "пустота...";
this.skladnist = skladnist;
this.kraina = kraina;
}
public void Show()
{
Console.WriteLine("Функцiя 'Show':");
Console.WriteLine($"Виробник: {this.vurobnik}");
Console.WriteLine($"Складнiсть: {this.skladnist}");
Console.WriteLine($"Країна: {this.kraina}");
}
}

public class Vurib2 : Mehanizm2
{
protected int riven { get; set; }
~Vurib2()
{
Console.WriteLine("ДЕСТРУКЦІЯ!!!");
}
public Vurib2(string vurobnik, string skladnist, string kraina, int riven) : base(vurobnik, skladnist, kraina)
{
this.riven = riven;
this.vurobnik = vurobnik;
this.skladnist = skladnist;
this.kraina = kraina;
}
public Vurib2(string vurobnik) : base(vurobnik)
{
this.vurobnik = vurobnik;
this.riven = -1;
this.skladnist = "пустота...";
this.kraina = "пустота...";
}
public Vurib2(string skladnist, string kraina) : base(skladnist, kraina)
{
this.vurobnik = "пустота...";
this.skladnist = skladnist;
this.kraina = kraina;
this.riven = 3;
}
public void Show()
{
Console.WriteLine("Функцiя 'Show':");
Console.WriteLine($"Виробник: {this.vurobnik}");
Console.WriteLine($"Складнiсть: {this.skladnist}");
Console.WriteLine($"Країна: {this.kraina}");
Console.WriteLine($"Рiвень: {this.riven}");
}
}

public class Vuzol2 : Mehanizm2
{
protected string stupin { get; set; }
~Vuzol2()
{
Console.WriteLine("ДЕСТРУКЦІЯ!!!");
}
public Vuzol2(string vurobnik, string skladnist, string kraina, string stupin) : base(vurobnik, skladnist, kraina)
{
this.stupin = stupin;
this.vurobnik = vurobnik;
this.skladnist = skladnist;
this.kraina = kraina;
}
public Vuzol2(string vurobnik) : base(vurobnik)
{
this.vurobnik = vurobnik;
this.stupin = "пустота...";
this.skladnist = "пустота...";
this.kraina = "пустота...";
}

public Vuzol2(string skladnist, string kraina) : base(skladnist, kraina)
{
this.vurobnik = "пустота...";
this.skladnist = skladnist;
this.kraina = kraina;
this.stupin = "пустота...";
}
public void Show()
{
Console.WriteLine("Функцiя Show:");
Console.WriteLine($"Виробник: {this.vurobnik}");
Console.WriteLine($"Складнiсть: {this.skladnist}");
Console.WriteLine($"Країна: {this.kraina}");
Console.WriteLine($"Ступiнь: {this.stupin}");
}
}
}

//третє завдання
namespace laboratorna_robota5
{abstract class Trans
{
public string marka_transportu;
public string nomer_transportu;
public Trans(string marka, string nomer)
{
marka_transportu = marka;
nomer_transportu = nomer;
}
public abstract void GetInformazia_pro_Transport();
}
class Lehkove_avto : Trans
 {
public int znachennia_shvidkosti;
public int vantazhopidjomnist;
public Lehkove_avto(string marka, string nomer, int shvidkist, int Vantazhopidjomnist) : base(marka, nomer)
{
znachennia_shvidkosti = shvidkist;
vantazhopidjomnist = Vantazhopidjomnist;
 }
public override void GetInformazia_pro_Transport()
{
Console.WriteLine("Iнформацiя про легкове авто : {0},{1},{2},{3}", marka_transportu, nomer_transportu, znachennia_shvidkosti, vantazhopidjomnist);
}
}
    class Motozikl : Trans
    {
        public int vantazhopidjomnist_motozikla;
        public string naiavnist_koliaski;
        public Motozikl(string marka, string nomer, string Naiavnist_koliaski, int Vantazhopidjomnist_motozikla) : base(marka, nomer)
        {
            vantazhopidjomnist_motozikla = Vantazhopidjomnist_motozikla;
            naiavnist_koliaski = Naiavnist_koliaski;
            if (naiavnist_koliaski == null) vantazhopidjomnist_motozikla = 0;
        }
        public override void GetInformazia_pro_Transport()
        {
            Console.WriteLine("Iнформацiя про мотоцикл:{0},{1},{2},{3}", marka_transportu, nomer_transportu, naiavnist_koliaski, vantazhopidjomnist_motozikla);
        }
    }
class Vantazhivka : Trans
{
        public int Vantazhopidjomnist_vantazhivku;
        public string Naiavnist_prichepu;
        public Vantazhivka(string marka, string nomer, int vantazhopidjomnist_vantazhivku, string naiavnist_prichepu) : base(marka, nomer)
        {
           Vantazhopidjomnist_vantazhivku = vantazhopidjomnist_vantazhivku;
           Naiavnist_prichepu = naiavnist_prichepu;
            if (naiavnist_prichepu != null) Vantazhopidjomnist_vantazhivku = vantazhopidjomnist_vantazhivku * 2;
        }
        public override void GetInformazia_pro_Transport()
        {
            Console.WriteLine("Iнформацiя про вантажiвку:{0},{1},{2},{3}", marka_transportu, nomer_transportu, Vantazhopidjomnist_vantazhivku, Naiavnist_prichepu);
        }
    }
class Baza
{
public List<Trans> baza = new List<Trans>();
public void AddTrans(Trans edit)
{
baza.Add(edit);
}
public void FindTrans(string nomer)
{
foreach (var p in baza.FindAll(p => p.nomer_transportu == nomer))
p.GetInformazia_pro_Transport();
}
}
}

namespace laboratorna_robota5
{internal class Program
{static void Main(string[] args)
{
int vubir = 0;
do
{
Console.Write("Яке завдання iз трьох Ви бажаєте перевiрити??(вибiр здiйснюється цифрою вiд 1 до 3)");
vubir = int.Parse(Console.ReadLine());
} while (vubir != 1 && vubir != 2 && vubir != 3);
switch (vubir)
{
case 1:
Console.WriteLine("ПЕРШЕ ЗАВДАННЯ:");
{
Detal Detal = new Detal("Двигун");
Detal.Show();
Console.WriteLine();

Mehanizm Mehanizm = new Mehanizm("Volkswagen", "Висока", "Нiмеччина");
Mehanizm.Show();
Console.WriteLine();

Vurib Vurib = new Vurib("Bosch", "Середня", "Швейцарiя", 1);
Vurib.Show();
Console.WriteLine();

Vuzol vuzol = new Vuzol("La Puerta Kol-da-Riko", "Низька", "Iспанiя", "Поглиблений");
vuzol.Show();
Console.WriteLine();
}
break;

//druge zavdannia
case 2:
Console.WriteLine("ДРУГЕ ЗАВДАННЯ:");
{
Detal2 Detal1 = new Detal2("Volkswagen");
Detal1.Show();
Console.WriteLine();
Detal2 Detal2 = new Detal2();
Detal2.Show();
Console.WriteLine();
Detal2 Detal3 = new Detal2(131);
Detal3.Show();
Console.WriteLine();

Mehanizm2 Mehanizm1 = new Mehanizm2("Volkswagen", "Висока", "Нiмеччина");
Mehanizm1.Show();
Console.WriteLine();
Mehanizm2 Mehanizm2 = new Mehanizm2("Volkswagen");
Mehanizm2.Show();
Console.WriteLine();
Mehanizm2 Mehanizm3 = new Mehanizm2("Висока", "Нiмеччина");
Mehanizm3.Show();
Console.WriteLine();

Vurib2 Vurib1 = new Vurib2("Bosch", "Середня", "Швейцарiя", 1);
Vurib1.Show();
Console.WriteLine();
Vurib2 Vurib2 = new Vurib2("Bosch");
Vurib2.Show();
Console.WriteLine();
Vurib2 Vurib3 = new Vurib2("Низька", "Швейцарiя");
Vurib3.Show();
Console.WriteLine();

Vuzol2 vuzol1 = new Vuzol2("La Puerta Kol-da-Riko", "Низька", "Iспанiя", "Поглиблений");
vuzol1.Show();
Console.WriteLine();
Vuzol2 vuzol2 = new Vuzol2("Карбюратор");
vuzol2.Show();
Console.WriteLine();
Vuzol2 vuzol3 = new Vuzol2("Висока", "Iспанiя");
vuzol3.Show();
Console.WriteLine();
}
break;
                    //третє
case 3:
Console.WriteLine("ТРЕТЄ ЗАВДАННЯ:");
{
Baza c = new Baza();

c.AddTrans(new Lehkove_avto("Volkswagen", "CE1488AA", 220, 500));
c.AddTrans(new Motozikl("Volvo", "CE1337LK", null,120));
c.AddTrans(new Vantazhivka("DUFF", "CE0228CH",1500, "Причеп наявний"));

Console.WriteLine("ВСI ТРАНСПОРТНI ЗАСОБИ ЗНАЙДЕНI В БАЗI:");
foreach (var p in c.baza)
{
p.GetInformazia_pro_Transport();
}
Console.WriteLine("/-----------------------------------------------------/");
Console.WriteLine("ВСI ТРАНСПОРТНI ЗАСОБИ ЗНАЙДЕНI ПО НОМЕРУ 'CE1488AA':");
c.FindTrans("CE1488AA");
Console.ReadLine();
}
break;
default:Console.WriteLine("Помилка!");
break;
}
}
}
}
